using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_shop_Library
{
    public class Moto : Veicolo
    {
        public Moto() : base("Default", "Default", "Default", 000, 00.0, DateTime.Now, false, false, 000, 000, "moto.png")
        {
            Sella = "Default";
        }

        public Moto(string marca, string modello, string colore, int cilindrata, double potenza,
            DateTime matricolazione, bool usato, bool km0, int kmFatti, double prezzo, string img, string sella)
            : base(marca, modello, colore, cilindrata, potenza, matricolazione, usato, km0, kmFatti, prezzo, img)
        {
            Sella = sella;
        }

        public string Sella { get; set; }

        public override string ToString() { return $"Moto: {base.ToString()} - Sella {Sella} - {Prezzo} €"; }
    }
}
