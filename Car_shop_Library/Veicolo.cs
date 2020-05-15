using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_shop_Library
{
    public class Veicolo
    {
        private string marca;
        public Veicolo(string marca, string modello, string colore, int cilindrata, double potenza, DateTime matricolazione, bool usato, bool km0, int kmFatti, double prezzo, string img)
        {
            Marca = marca;
            Modello = modello;
            Colore = colore;
            Cilindrata = cilindrata;
            Potenza = potenza;
            Matricolazione = matricolazione;
            Usato = usato;
            Km0 = km0;
            KmFatti = kmFatti;
            Prezzo = prezzo;
            Img = img;
        }

        public string Marca { get => marca.ToUpper(); set => marca = value; }
        public string Modello { get; set; }
        public string Colore { get; set; }
        public int Cilindrata { get; set; }
        public double Potenza { get; set; }
        public DateTime Matricolazione { get; set; }
        public bool Usato { get; set; }
        public bool Km0 { get; set; }
        public int KmFatti { get; set; }
        public double Prezzo { get; set; }
        public string Img { get; set; }

        public override string ToString() { return $" {Marca} - Modello: {Modello} ({Matricolazione.Year})"; }
    }
}
