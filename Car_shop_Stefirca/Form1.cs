using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_shop_Library;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Car_shop_Stefirca
{
    public partial class FormMain : Form
    {
        private ListUtils listUtils = new ListUtils();
        private DBUtils dbUtils = new DBUtils();
        private Word wordUtils = new Word();
        private Excell excellUtils = new Excell();
        private GeneralUtils generalUtils = new GeneralUtils();

        public static string dbFilePath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Car_shop_Data\\Car_shop_Stefirca.accdb";
        public static string connectStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFilePath}";
        public SerializableBindingList<Veicolo> ListaVeicoli; 
        public FormMain()
        {
            InitializeComponent();
            ListaVeicoli = new SerializableBindingList<Veicolo>();
            ListBoxV.DataSource = ListaVeicoli;
            Start();
        }

        private void Nuovo_Click(object sender, EventArgs e)
        {
            FormDialogVehicle dialogAddMod = new FormDialogVehicle(this);
            dialogAddMod.ShowDialog();
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            dbUtils.CreateBackup(dbFilePath);
            listUtils.UpdateDb(ListaVeicoli, connectStr);
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler eliminare l'elemento selezionato?", "CANCELLA VEICOLO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ListaVeicoli.RemoveAt(ListBoxV.SelectedIndex);
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            FormDialogVehicle dialogAddMod = new FormDialogVehicle(this, ListBoxV.SelectedIndex);
            if (dialogAddMod.ShowDialog() == DialogResult.OK)
            {
                dbUtils.CreateBackup(dbFilePath);
                listUtils.UpdateDb(ListaVeicoli, connectStr);
                Start();
            }
        }

        private void Stampa_Click(object sender, EventArgs e)
        {
            if (ListaVeicoli.Count > 0)
            {
                string homepagePath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Car_shop_Data\\www\\index.html";
                string skeletonPath = $"{ Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Car_shop_Data\\www\\index-skeleton.html";
                listUtils.CreateHtml(ListaVeicoli, homepagePath, skeletonPath);
                Process.Start(homepagePath);
            }
            else
                MessageBox.Show("Inserisci almeno un veicolo prima di visualizzare!");
        }

        private void Word_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filepath = generalUtils.OutputFileName(FolderBrowserDialog.SelectedPath, "docx");

                    using (WordprocessingDocument doc = WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
                    {
                        MainDocumentPart mainPart = doc.AddMainDocumentPart();

                        mainPart.Document = new Document();
                        Body body = mainPart.Document.AppendChild(new Body());

                        wordUtils.AddStyle(mainPart, true, true, true, false, "MyHeading1", "Title", "Serif", 16, "0000FF");
                        wordUtils.AddStyle(mainPart, true, false, false, false, "MyHeading2", "Subtitle", "Serif", 14, "0000FF");
                        wordUtils.AddStyle(mainPart, false, false, false, false, "MyStartParagraph", "First", "Calibri", 15, "000000");
                        wordUtils.AddStyle(mainPart, false, false, false, false, "MyParagraph2", "Second", "Calibri", 12, "000000");

                        AddParagraph(body, "MyHeading1", "Autosalone - VEICOLI NUOVI E USATI", JustificationValues.Center);
                        AddParagraph(body, "MyHeading2", "Offerte ogni giorno!", JustificationValues.Center);
                        AddParagraph(body, "MyStartParagraph", "Lista dei veicoli disponibili:");

                        wordUtils.CreateBulletNumberingPart(mainPart, "•");
                        for (int i = 0; i < ListaVeicoli.Count; i++)
                        {
                            AddParagraph(body, "MyParagraph2", $"{ListaVeicoli[i].Marca} {ListaVeicoli[i].Modello}");
                            string usato = ListaVeicoli[i].Usato ? "Si" : "No";
                            string km0 = ListaVeicoli[i].Km0 ? "Si" : "No";
                            string[] elements = { $"Colore: {ListaVeicoli[i].Colore}",
                            $"Cilindrata: {ListaVeicoli[i].Cilindrata}", $"Potenza: {ListaVeicoli[i].Potenza} Kw",
                            $"matricolazione: {ListaVeicoli[i].Matricolazione.ToShortDateString()}",
                            $"Usato: {usato}", $"Km0: {km0}", $"Km Percorsi: {ListaVeicoli[i].KmFatti}",
                            $"Prezzo: {ListaVeicoli[i].Prezzo} €"};
                            List<Paragraph> bulletList = new List<Paragraph>();
                            wordUtils.CreateBulletOrNumberedList(100, 200, bulletList, elements);
                            foreach (Paragraph paragraph in bulletList)
                                body.Append(paragraph);
                        }
                        ProcedureCompleted("Il documento è pronto!", filepath);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemi con il documento. Se è aperto da un altro programma, chiudilo e riprova...");
                }
            }
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filepath = generalUtils.OutputFileName(FolderBrowserDialog.SelectedPath, "xlsx");

                    List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
                    for (int i = 0; i < ListaVeicoli.Count; i++)
                    {
                        string usato = ListaVeicoli[i].Usato ? "Si" : "No";
                        string km0 = ListaVeicoli[i].Km0 ? "Si" : "No";
                        Dictionary<string, string> excelContent = new Dictionary<string, string>();

                        excelContent.Add("Marca", ListaVeicoli[i].Marca);
                        excelContent.Add("Modello", ListaVeicoli[i].Modello);
                        excelContent.Add("Colore", ListaVeicoli[i].Colore);
                        excelContent.Add("Cilindrata", ListaVeicoli[i].Cilindrata.ToString());
                        excelContent.Add("Potenza", ListaVeicoli[i].Potenza.ToString() + " kw");
                        excelContent.Add("matricolazione", ListaVeicoli[i].Matricolazione.ToShortDateString());
                        excelContent.Add("Usato", usato);
                        excelContent.Add("Km Zero", km0);
                        excelContent.Add("KmFatti", ListaVeicoli[i].KmFatti.ToString());
                        excelContent.Add("Prezzo", ListaVeicoli[i].Prezzo.ToString() + " €");
                        if ((ListaVeicoli[i] is Auto)) excelContent.Add("Numero Airbag/Marca sella", (ListaVeicoli[i] as Auto).NumAirbag.ToString());
                        else excelContent.Add("Numero Airbag/sella", (ListaVeicoli[i] as Moto).Sella);
                        list.Add(excelContent);
                    }
                    using (SpreadsheetDocument package = SpreadsheetDocument.Create(filepath, SpreadsheetDocumentType.Workbook))
                    {

                        excellUtils.CreatePartsForExcel(package, list);

                        ProcedureCompleted("Il documento è pronto!", filepath);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemi con il documento. Se è aperto da un altro programma, chiudilo e riprova...");
                }
            }
        }
        private void Start()
        {
            ListaVeicoli.Clear();
            listUtils.OpenDBInList(ListaVeicoli, connectStr);
        }

        private void AddParagraph(Body body, string idStyle, string text, JustificationValues justification = JustificationValues.Left)
        {
            Paragraph headingPar = wordUtils.CreateParagraphWithStyle(idStyle, justification);
            wordUtils.AddTextToParagraph(headingPar, text);
            body.AppendChild(headingPar);
        }

        private void ProcedureCompleted(string msg, string filepath)
        {
            MessageBox.Show(msg);
            Process.Start(filepath);
        }
    }

}
