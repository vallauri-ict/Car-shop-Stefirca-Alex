using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Car_shop_Library;


namespace Car_shop_Stefirca
{
    public partial class FormGestione : Form
    {
        List<Control> controls;
        string veicolo;
        int selectedIndex;
        FormMain fm;
        private ErrorProviderUtilities erProv = new ErrorProviderUtilities();


        public FormGestione(FormMain formMain)
        {
            InitializeComponent();
            Control[] aus = { txtMarca, txtModello, txtColore, nCilindrata, nPotenza, nKmFatti, nPrezzo, nAirbag };
            controls = new List<Control>(aus);
            this.fm = formMain;
            veicolo = "AUTO";

            Text = "Aggiungi";
            btnAddModify.Text = "Aggiungi";
            btnCancel.DialogResult = DialogResult.Cancel;
            Tipo_veicolo.Enabled = true;
            Tipo_veicolo.SelectedIndex = 0;
            lblSaddleBrand.Location = lblNAirbag.Location;
            txtSella.Location = nAirbag.Location;
            DataMatricolazione.MaxDate = DateTime.Today;
            DataMatricolazione.Value = DateTime.Today;
            txtSella.Visible = lblSaddleBrand.Visible = false;
        }

        public FormGestione(FormMain formMain, int selectedIndex) : this(formMain)
        {
            Text = "Modifica";
            Tipo_veicolo.Enabled = false;
            txtMarca.Text = formMain.ListaVeicoli[selectedIndex].Marca;
            txtModello.Text = formMain.ListaVeicoli[selectedIndex].Modello;
            txtColore.Text = formMain.ListaVeicoli[selectedIndex].Colore;
            nCilindrata.Value = formMain.ListaVeicoli[selectedIndex].Cilindrata;
            nPotenza.Value = Convert.ToDecimal(formMain.ListaVeicoli[selectedIndex].Potenza);
            DataMatricolazione.Value = formMain.ListaVeicoli[selectedIndex].Matricolazione;
            chkUsato.Checked = formMain.ListaVeicoli[selectedIndex].Usato;
            chkKm0.Checked = formMain.ListaVeicoli[selectedIndex].Km0;
            nKmFatti.Value = formMain.ListaVeicoli[selectedIndex].KmFatti;
            nPrezzo.Value = Convert.ToDecimal(formMain.ListaVeicoli[selectedIndex].Prezzo);
            if (formMain.ListaVeicoli[selectedIndex] is Moto)
            {
                Tipo_veicolo.SelectedIndex = 1;
                txtSella.Text = (formMain.ListaVeicoli[selectedIndex] as Moto).Sella;
            }
            else
                nAirbag.Value = (formMain.ListaVeicoli[selectedIndex] as Auto).NumAirbag;
            btnAddModify.Text = "Modifica";
            this.selectedIndex = selectedIndex;
        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            bool correct = inputControl();
            if (btnAddModify.Text == "Aggiungi")
            {
                if (correct)
                {

                    if (veicolo == "AUTO")
                    {
                        fm.ListaVeicoli.Add(new Auto(txtMarca.Text, txtModello.Text, txtColore.Text,
                                                           Convert.ToInt32(nCilindrata.Value),
                                                           Convert.ToDouble(nPotenza.Value),
                                                           DataMatricolazione.Value, chkUsato.Checked,
                                                           chkKm0.Checked, Convert.ToInt32(nKmFatti.Value),
                                                           Convert.ToInt32(nPrezzo.Value), "auto.png",
                                                           Convert.ToInt32(nAirbag.Value)));
                    }
                    else
                    {
                        fm.ListaVeicoli.Add(new Moto(txtMarca.Text, txtModello.Text, txtColore.Text,
                                                           Convert.ToInt32(nCilindrata.Value),
                                                           Convert.ToDouble(nPotenza.Value),
                                                           DataMatricolazione.Value, chkUsato.Checked,
                                                           chkKm0.Checked, Convert.ToInt32(nKmFatti.Value),
                                                           Convert.ToInt32(nPrezzo.Value), "moto.png",
                                                           txtSella.Text));
                    }
                    Close();
                }

            }
            else
            {
                if (correct && MessageBox.Show("Operazione non reversibile, vuoi procedere?", "Vuoi modificare l'elemento selezionato?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    fm.ListaVeicoli[selectedIndex].Marca = txtMarca.Text;
                    fm.ListaVeicoli[selectedIndex].Modello = txtModello.Text;
                    fm.ListaVeicoli[selectedIndex].Colore = txtColore.Text;
                    fm.ListaVeicoli[selectedIndex].Cilindrata= Convert.ToInt32(nCilindrata.Value);
                    fm.ListaVeicoli[selectedIndex].Potenza = Convert.ToDouble(nPotenza.Value);
                    fm.ListaVeicoli[selectedIndex].Matricolazione= DataMatricolazione.Value;
                    fm.ListaVeicoli[selectedIndex].Usato = chkUsato.Checked;
                    fm.ListaVeicoli[selectedIndex].Km0 = chkKm0.Checked;
                    fm.ListaVeicoli[selectedIndex].KmFatti = Convert.ToInt32(nKmFatti.Value);
                    fm.ListaVeicoli[selectedIndex].Prezzo = Convert.ToInt32(nPrezzo.Value);
                    if (fm.ListaVeicoli[selectedIndex] is Moto)
                        (fm.ListaVeicoli[selectedIndex] as Moto).Sella = txtSella.Text;
                    else
                        (fm.ListaVeicoli[selectedIndex] as Auto).NumAirbag = Convert.ToInt32(nAirbag.Value);

                    DialogResult = DialogResult.OK;
                }
            }
        }


        private void Tipo_veicolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            veicolo = Tipo_veicolo.Text;
            if (veicolo == "AUTO") setValVeicolo(true, false, nAirbag);
            else setValVeicolo(false, true, txtSella);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            erProv.resetError(error, sender as Control);
        }


        private void setValVeicolo(bool auto, bool moto, Control control)
        {
            nAirbag.Visible = lblNAirbag.Visible = auto;
            txtSella.Visible = lblSaddleBrand.Visible = moto;
            controls.RemoveAt(controls.Count - 1);
            controls.Add(control);
        }

        private bool inputControl()
        {
            bool correct = true;
            for (int i = 0; i < controls.Count && correct; i++)
            {
                correct = controls[i].Text != string.Empty;
                if (!correct)
                    erProv.setError(error, controls[i], "Devi completare tutti i campi richiesti!");
            }
            return correct;
        }

    }
}