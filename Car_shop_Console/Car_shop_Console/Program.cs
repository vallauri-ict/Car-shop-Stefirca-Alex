using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Car_shop_Library;

namespace Car_shop_Console
{
    class Program
    {
        public static DBUtils DBUtils = new DBUtils();
        public static string dbFilePath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Car_shop_Data\\Car_shop_Stefirca.accdb";
        public static string table, marca, modello, colore, sella;
        public static int id, cilindrata, kmFatti, numAirbag;
        public static double potenza, prezzo;
        public static bool usato, km0;
        public static DateTime matricolazione;

        static void Main(string[] args)
        {
            char choice;
            do
            {
                menu();
                Console.Write("Seleziona un'opzione ");
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        table = veicolo();
                        if (table != "x")
                        {
                            DBUtils.CreateTable(table);
                            Console.WriteLine("\nTabella creata");
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        table = veicolo();
                        if (table != "x")
                        {
                            takeParameters();
                            DBUtils.AddNewItem(table, marca, modello, colore, cilindrata, potenza, matricolazione, usato, km0, kmFatti, prezzo, numAirbag, sella);
                            Console.WriteLine("\nNuovo elemento aggiunto");
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        table = veicolo();
                        if (table != "x") DBUtils.ListTable(table);
                        break;
                    case '4':
                        table = veicolo();
                        if (table != "x")
                        {
                            id = takeId(table);
                            takeParameters();
                            DBUtils.Update(table, id, marca, modello, colore, cilindrata, potenza, matricolazione, usato, km0, kmFatti, prezzo, numAirbag, sella);
                            id = 0;
                            Console.WriteLine($"\nTabella {table} aggiornata");
                            Console.ReadKey();
                        }
                        break;
                    case '5':
                        table = veicolo();
                        if (table != "x")
                        {
                            id = takeId(table);
                            DBUtils.Delete(table, id);
                            id = 0;
                            Console.WriteLine("\nElemento rimosso");
                            Console.ReadKey();
                        }
                        break;
                    case '6':
                        table = veicolo();
                        if (table != "x")
                        {
                            DBUtils.DropTable(table);
                            Console.WriteLine($"\nTabella {table} rimossa");
                            Console.ReadKey();
                        }
                        break;
                    case '7':
                        DBUtils.CreateBackup(dbFilePath);
                        Console.WriteLine($"\nBackup creato");
                        Console.ReadKey();
                        break;
                    case '8':
                        DBUtils.RestoresBackup(dbFilePath);
                        Console.WriteLine($"\nBackup ripristinato");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
            while (choice != 'X' && choice != 'x');
        }
        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("---  Autosalone - Comandi DB  ---\n");
            Console.WriteLine("1 - Crea tabella");
            Console.WriteLine("2 - Aggiungi nuovo elemento");
            Console.WriteLine("3 - Lista");
            Console.WriteLine("4 - Aggiorna elemento");
            Console.WriteLine("5 - Elimina elemento");
            Console.WriteLine("6 - Elimina tabella");
            Console.WriteLine("7 - Crea Backup");
            Console.WriteLine("8 - Ripristina");
            Console.WriteLine("\nX - Esci\n\n");
        }

        private static void takeParameters()
        {
            Console.Write("\nBrand: ");
            marca = Console.ReadLine();

            Console.Write("Model: ");
            modello = Console.ReadLine();

            Console.Write("Color: ");
            colore = Console.ReadLine();

            cilindrata = Convert.ToInt32(typeVerifier("Displacement: "));

            potenza = Convert.ToDouble(typeVerifier("Power: ", "double"));

            matricolazione = dateVerifier("Matriculation: ");

            usato = boolRequest("Used");

            km0 = boolRequest("Km Zero");

            kmFatti = Convert.ToInt32(typeVerifier("Km Done: "));

            prezzo = Convert.ToInt32(typeVerifier("Price: ", "double"));

            numAirbag = -1;
            sella = string.Empty;
            if (table == "Auto") numAirbag = Convert.ToInt32(typeVerifier("numAirbag: "));
            else
            {
                Console.Write("Sella: ");
                sella = Console.ReadLine();
            }
        }

        private static string veicolo()
        {
            char table;
            do
            {
                Console.WriteLine("\na- Auto (Auto)");
                Console.WriteLine("m- Moto (Moto)");
                Console.WriteLine("X - Canc\n");
                Console.Write("Scegli una tabella: ");
                table = Console.ReadKey().KeyChar;
            } while (table != 'a' && table != 'A' && table != 'm' && table != 'M' && table != 'x' && table != 'X');

            if (table == 'a' || table == 'A') return "Auto";
            else if (table == 'm' || table == 'M') return "Moto";
            else return "x";
        }

        private static object typeVerifier(string consoleWrite, string verifier = "integer")
        {
            int iVerifier = 0;
            double dVerifier = 0;
            do
            {
                Console.Write(consoleWrite);
                try
                {
                    if (verifier == "integer") iVerifier = Convert.ToInt32(Console.ReadLine());
                    else dVerifier = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine($"Dovresti mettere un {verifier}!");
                    if (verifier == "integer") iVerifier = -2;
                    else dVerifier = -2;
                }
            } while (iVerifier == -2 || dVerifier == -2);

            if (verifier == "integer")
                return iVerifier;
            else
                return dVerifier;
        }

        private static bool boolRequest(string consoleWrite)
        {
            string answer;
            string parameter;
            if (consoleWrite == "Usato") parameter = "usato";
            else parameter = "km0";
            do
            {
                Console.Write($"{consoleWrite} S/N: ");
                answer = Console.ReadLine();
            } while (answer != "S" && answer != "N" && answer != "s" && answer != "n" && answer != "-1");

            if (answer == "S" || answer == "s") return true;
            else if (answer == "N" || answer == "n") return false;
            else if (DBUtils.takeActualValue(parameter, table, id) == "Si") return true;
            else return false;
        }

        private static DateTime dateVerifier(string consoleWrite)
        {
            DateTime verifier = DateTime.Now;
            bool correct;
            do
            {
                Console.Write(consoleWrite);
                try
                {
                    string aus = Console.ReadLine();
                    if (aus == "-1") aus = "31/12/2222";
                    verifier = Convert.ToDateTime(aus);
                    correct = true;
                }
                catch (Exception)
                {
                    correct = false;
                }
            } while (!correct);

            return verifier;
        }

        private static int takeId(string table)
        {
            int maxId = DBUtils.ItemsCounter(table);
            int id;
            do
            {
                id = Convert.ToInt32(typeVerifier($"\nInserisci un numero da 1 a {maxId}: "));
            } while (id < 1 || id > maxId);

            return id;
        }
    }
}
