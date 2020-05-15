using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace Car_shop_Library
{
    public class DBUtils
    {
        public DBUtils() { }
        public string connectStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Car_shop_Data\\Car_shop_Stefirca.accdb";

        public void CreateTable(string tableName)
        {
            if (connectStr != null)
            {
                OleDbConnection con = new OleDbConnection(connectStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;

                     
                    try
                    {
                        string command = $@"CREATE TABLE {tableName}(
                                id INT identity(1,1) NOT NULL PRIMARY KEY,
                                marca VARCHAR(255) NOT NULL, modello VARCHAR(255) NOT NULL,
                                colore VARCHAR(255), cilindrata INT, potenza INT,
                                matricolazione DATE, usato VARCHAR(255), kmZero VARCHAR(255),
                                kmFatti INT, prezzo MONEY,";
                        if (tableName == "Auto") command += " numAirbag INT,";
                        else command += " Sella VARCHAR(255),";
                        command += " img VARCHAR(255))";
                        cmd.CommandText = command;
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine($"\n\n{ex.Message}");
                        Console.ReadKey();
                        return;
                    }
                }
            }
        }

        public void AddNewItem(string tableName, string marca, string modello, string colore, int cilindrata, double potenza, DateTime matricolazione, bool usato, bool km0, int kmFatti, double prezzo, int numAirbag, string sella, string img = "default.png")
        {
            if (connectStr != null)
            {
                OleDbConnection con = new OleDbConnection(connectStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string command = string.Empty;
                    if (tableName == "Auto")
                        command = $"INSERT INTO {tableName}(marca, modello, colore, cilindrata, potenza, matricolazione, usato, kmZero, kmFatti, prezzo, numAirbag, img) VALUES(@marca, @modello, @colore, @cilindrata, @potenza, @matricolazione, @usato, @km0, @kmFatti, @prezzo, @numAirbag, @img)";
                    else
                        command = $"INSERT INTO {tableName}(marca, modello, colore, cilindrata, potenza, matricolazione, usato, kmZero, kmFatti, prezzo, sella, img) VALUES(@marca, @modello, @colore, @cilindrata, @potenza, @matricolazione, @usato, @km0, @kmFatti, @prezzo, @sella, @img)";
                    cmd.CommandText = command;

                    string isUsato = usato ? "Si" : "No";
                    string isKm0 = km0 ? "Si" : "No";
                    cmd.Parameters.Add(new OleDbParameter("@marca", OleDbType.VarChar, 255)).Value = marca;
                    cmd.Parameters.Add(new OleDbParameter("@modello", OleDbType.VarChar, 255)).Value = modello;
                    cmd.Parameters.Add(new OleDbParameter("@colore", OleDbType.VarChar, 255)).Value = colore;
                    cmd.Parameters.Add("@cilindrata", OleDbType.Integer).Value = cilindrata;
                    cmd.Parameters.Add("@potenza", OleDbType.Integer).Value = potenza;
                    cmd.Parameters.Add(new OleDbParameter("@matricolazione", OleDbType.Date)).Value = matricolazione.ToShortDateString();
                    cmd.Parameters.Add(new OleDbParameter("@usato", OleDbType.VarChar, 255)).Value = isUsato;
                    cmd.Parameters.Add(new OleDbParameter("@km0", OleDbType.VarChar, 255)).Value = isKm0;
                    cmd.Parameters.Add("@kmFatti", OleDbType.Integer).Value = kmFatti;
                    cmd.Parameters.Add("@prezzo", OleDbType.Double).Value = prezzo;
                    if (tableName == "Auto")
                        cmd.Parameters.Add("@numAirbag", OleDbType.Integer).Value = numAirbag;
                    else
                        cmd.Parameters.Add(new OleDbParameter("@sella", OleDbType.VarChar, 255)).Value = sella;
                    cmd.Parameters.Add(new OleDbParameter("@img", OleDbType.VarChar, 255)).Value = img;
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void ListTable(string tableName)
        {
            if (connectStr != null)
            {
                OleDbConnection con = new OleDbConnection(connectStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand command = new OleDbCommand($"SELECT * FROM {tableName}", con);

                    OleDbDataReader rdr = command.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        Console.WriteLine("\n");
                        while (rdr.Read())
                        {
                            string matriculation = rdr.GetDateTime(6).ToShortDateString();

                            string output = $"{rdr.GetInt32(0)} - {rdr.GetString(1)} - {rdr.GetString(2)} - " +
                                            $"{rdr.GetString(3)} - {rdr.GetInt32(4)} - {rdr.GetInt32(5)} - " +
                                            $"{matriculation} - {rdr.GetString(7)} - {rdr.GetString(8)} - " +
                                            $"{rdr.GetInt32(9)} - {rdr.GetDecimal(10)}";
                            if (tableName == "Auto") output += $" - {rdr.GetInt32(11)}";
                            else output += $" - {rdr.GetString(11)}";
                            Console.WriteLine(output);
                        }
                    }
                    else Console.WriteLine("\n\nNo rows found.");
                    rdr.Close();
                }
                Console.ReadKey();
            }
        }

        public void Update(string tableName, int id, string marca, string modello, string colore, int cilindrata, double potenza, DateTime matricolazione, bool usato, bool km0, int kmFatti, double prezzo, int numAirbag, string sella, string img = "")
        {
            if (connectStr != null)
            {
                OleDbConnection con = new OleDbConnection(connectStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string command = $"UPDATE {tableName}";
                    string set = " SET ";
                    set += parametersControl(marca != "-1", " marca=@marca");
                    set += parametersControl(modello != "-1", " , modello=@modello");
                    set += parametersControl(colore != "-1", " , colore=@colore");
                    set += parametersControl(cilindrata != -1, " , cilindrata=@cilindrata");
                    set += parametersControl(potenza != -1, " , potenza=@potenza");
                    set += parametersControl(matricolazione.ToString("dd/MM/yyyy") != "01/01/9999", " , matricolazione=@matricolazione");
                    set += " , usato=@usato";
                    set += " , kmZero=@km0";
                    set += parametersControl(kmFatti != -1, " , kmFatti=@kmFatti");
                    set += parametersControl(prezzo != -1, " , prezzo=@prezzo");
                    if (tableName == "Auto")
                        set += parametersControl(numAirbag != -1, " , numAirbag=@numAirbag");
                    else
                        set += parametersControl(sella != "-1", " , sella=@sella");
                    set += parametersControl(img != "", " , img=@img");
                    if (set.Contains("SET  ,"))
                        set = set.Replace("SET  ,", "SET");
                    command += $" {set} WHERE id={id}";
                    cmd.CommandText = command;

                    string isUsato = usato ? "Si" : "No";
                    string isKm0 = km0 ? "Si" : "No";
                    if (command.Contains("@marca"))
                        cmd.Parameters.Add(new OleDbParameter("@marca", OleDbType.VarChar, 255)).Value = marca;
                    if (command.Contains("@modello"))
                        cmd.Parameters.Add(new OleDbParameter("@modello", OleDbType.VarChar, 255)).Value = modello;
                    if (command.Contains("@colore"))
                        cmd.Parameters.Add(new OleDbParameter("@colore", OleDbType.VarChar, 255)).Value = colore;
                    if (command.Contains("@cilindrata"))
                        cmd.Parameters.Add("@cilindrata", OleDbType.Integer).Value = cilindrata;
                    if (command.Contains("@potenza"))
                        cmd.Parameters.Add("@potenza", OleDbType.Integer).Value = potenza;
                    if (command.Contains("@matriculation"))
                        cmd.Parameters.Add(new OleDbParameter("@matriclazione", OleDbType.Date)).Value = matricolazione.ToShortDateString();
                    if (command.Contains("@usato"))
                        cmd.Parameters.Add(new OleDbParameter("@usato", OleDbType.VarChar, 255)).Value = isUsato;
                    if (command.Contains("@isKm0"))
                        cmd.Parameters.Add(new OleDbParameter("@km0", OleDbType.VarChar, 255)).Value = isKm0;
                    if (command.Contains("@kmFatti"))
                        cmd.Parameters.Add("@kmFatti", OleDbType.Integer).Value = kmFatti;
                    if (command.Contains("@prezzo"))
                        cmd.Parameters.Add("@prezzo", OleDbType.Double).Value = prezzo;
                    if (command.Contains("@numAirbag"))
                        cmd.Parameters.Add("@numAirbag", OleDbType.Integer).Value = numAirbag;
                    if (command.Contains("@sella"))
                        cmd.Parameters.Add(new OleDbParameter("@sella", OleDbType.VarChar, 255)).Value = sella;
                    if (command.Contains("@img"))
                        cmd.Parameters.Add(new OleDbParameter("@img", OleDbType.VarChar, 255)).Value = img;
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private string parametersControl(bool condition, string rtn)
        {
            if (condition) return rtn;
            else return "";
        }

        public void Delete(string tableName, int id)
        {
            if (connectStr != null)
            {
                OleDbConnection con = new OleDbConnection(connectStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand($"DELETE FROM {tableName} WHERE id={id}", con);

                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string ActualValue(string parameter, string tableName, int id)
        {
            if (connectStr != null)
            {
                OleDbConnection con = new OleDbConnection(connectStr);

                using (con)
                {
                    con.Open();

                    OleDbCommand command = new OleDbCommand($"SELECT {parameter} FROM {tableName} WHERE id={id}", con);

                    OleDbDataReader rdr = command.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            return rdr.GetString(0);
                        }
                    }
                    else Console.WriteLine("\n\nNo rows found.");
                    rdr.Close();
                }
            }
            return "No";
        }

        public int ItemsCounter(string tableName)
        {
            if (connectStr != null)
            {
                OleDbConnection con = new OleDbConnection(connectStr);

                using (con)
                {
                    con.Open();

                    OleDbCommand command = new OleDbCommand($"SELECT MAX(id) FROM {tableName}", con);

                    OleDbDataReader rdr = command.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            return rdr.GetInt32(0);
                        }
                    }
                    else Console.WriteLine("\n\nNo rows found.");
                    rdr.Close();
                }
            }
            return -1;
        }

        public void DropTable(string tableName)
        {
            if (connectStr != null)
            {
                OleDbConnection con = new OleDbConnection(connectStr);
                using (con)
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    string command = $"DROP TABLE {tableName}";
                    cmd.CommandText = command;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CreateBackup(string dbFilePath)
        {
            string backupDBFilePath = dbFilePath.Replace("Car_shop_Stefirca.accdb", "Backup_car_shop_Stefirca.accdb");
            if (File.Exists(backupDBFilePath)) File.Delete(backupDBFilePath);
            File.Copy(dbFilePath, backupDBFilePath);
        }

        public void RestoresBackup(string dbFilePath)
        {
            string backupDBFilePath = dbFilePath.Replace("Car_shop_Stefirca.accdb", "Backup_car_shop_Stefirca.accdb");
            if (File.Exists(dbFilePath)) File.Delete(dbFilePath);
            File.Copy(backupDBFilePath, dbFilePath);
        }
    }
}

