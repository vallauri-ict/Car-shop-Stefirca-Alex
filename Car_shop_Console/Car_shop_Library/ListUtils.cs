using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using System.Data.OleDb;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Car_shop_Library
{
    [Serializable]
    public class SerializableBindingList<T> : BindingList<T> { }

    public class ListUtils
    {
        public ListUtils() { }
        public DBUtils dbUtils = new DBUtils();

        public void OpenDBInList(SerializableBindingList<Veicolo> list, string connectStr)
        {
            if (connectStr != null)
            {
                OleDbConnection con = new OleDbConnection(connectStr);
                using (con)
                {
                    con.Open();

                    InsertItemInList(list, con, "Auto");
                    InsertItemInList(list, con, "Moto");
                }
            }
        }

        private void InsertItemInList(SerializableBindingList<Veicolo> list, OleDbConnection con, string tableName)
        {
            OleDbCommand command = new OleDbCommand($"SELECT * FROM {tableName}", con);

            OleDbDataReader rdr = command.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    bool usato = rdr.GetString(7) == "Si" ? true : false;
                    bool km0 = rdr.GetString(8) == "Si" ? true : false;
                    if (tableName == "Auto")
                    {
                        list.Add(new Auto(rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                            rdr.GetInt32(4), rdr.GetInt32(5), rdr.GetDateTime(6), usato,
                            km0, rdr.GetInt32(9), Convert.ToDouble(rdr.GetDecimal(10)), rdr.GetString(12),
                            rdr.GetInt32(11)));
                    }
                    else
                    {
                        list.Add(new Moto(rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                            rdr.GetInt32(4), rdr.GetInt32(5), rdr.GetDateTime(6), usato,
                            km0, rdr.GetInt32(9), Convert.ToDouble(rdr.GetDecimal(10)), rdr.GetString(12),
                            rdr.GetString(11)));
                    }
                }
            }
            else MessageBox.Show("Non è stato trovato alcun dato", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            rdr.Close();
        }

        public void UpdateDb(SerializableBindingList<Veicolo> list, string connStr)
        {
            if (connStr != null)
            {
                OleDbConnection con = new OleDbConnection(connStr);
                using (con)
                {
                    con.Open();

                    dbUtils.DropTable("Auto");
                    dbUtils.DropTable("Moto");
                    dbUtils.CreateTable("Auto");
                    dbUtils.CreateTable("Moto");
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] is Auto)
                        {
                            dbUtils.AddNewItem("Auto", list[i].Marca,
                                    list[i].Modello, list[i].Colore, list[i].Cilindrata,
                                    list[i].Potenza, list[i].Matricolazione,
                                    list[i].Usato, list[i].Km0, list[i].KmFatti,
                                    list[i].Prezzo, (list[i] as Auto).NumAirbag, "", list[i].Img);
                        }
                        else
                        {
                            dbUtils.AddNewItem("Moto", list[i].Marca,
                                    list[i].Modello, list[i].Colore, list[i].Cilindrata,
                                    list[i].Potenza, list[i].Matricolazione,
                                    list[i].Usato, list[i].Km0, list[i].KmFatti,
                                    list[i].Prezzo, 0, (list[i] as Moto).Sella, list[i].Img);
                        }
                    }
                }
            }
        }

        public void CreateHtml(SerializableBindingList<Veicolo> list, string pathName, string skeletonPathName = @".\www\index-skeleton.html")
        {
            string html = File.ReadAllText(skeletonPathName);
            html = html.Replace("{{head-title}}", "Autosalone da Stefirca");
            html = html.Replace("{{body-title}}", "Veicoli nuovi e usati");
            html = html.Replace("{{body-subtitle}}", "prezzi scontati ogni giorno!");


            string mainContent = "<h3> Veicoli disponibili </h3>";
            for (int i = 0; i < list.Count; i++)
                CreateBody(ref mainContent, list, i);

            html = html.Replace("{{main-content}}", mainContent);
            File.WriteAllText(pathName, html);
        }

        private void CreateBody(ref string mainContent, SerializableBindingList<Veicolo> list, int i)
        {
            string usato = string.Empty;
            string km0 = string.Empty;

            if (list[i].Km0) km0 = "Chilometro zero,";

            if (list[i].Usato) usato = "Usato";
            else usato = "Nuovo";


            mainContent += "<div class = \"veicolo\">";
            mainContent += $"<img src = \"../img/{list[i].Img}\">";
            mainContent += $"<div class = \"titolo\">{list[i].Marca} {list[i].Modello}";
            mainContent += $"<div class = \"didascalia\"> Colore: {list[i].Colore}<br> Cilindrata: {list[i].Cilindrata}<br> Immatricolazione: {list[i].Matricolazione.ToString("dd/MM/yyyy")}<br> {km0} {usato} <br> Chilometri percorsi: {list[i].KmFatti}<br> Potenza: {list[i].Potenza} <br> Prezzo: {list[i].Prezzo} € </div>";
            mainContent += "</div>";
            mainContent += "</div>";
        }
    }
}
