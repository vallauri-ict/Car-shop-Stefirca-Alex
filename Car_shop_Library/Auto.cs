﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_shop_Library
{
    public class Auto : Veicolo
    {
        public Auto() : base("Default", "Default", "Default", 0000, 00.0, DateTime.Now, false, false, 000000, 00000, "auto.png")
        {
            NumAirbag = 0;
        }
        public Auto(string marca, string modelllo, string colore, int cilindrata, double potenza,
            DateTime matricolazione, bool usato, bool km0, int kmFatti, double prezzo, string img, int numAirbag)
            : base(marca, modelllo, colore, cilindrata, potenza, matricolazione, usato, km0, kmFatti, prezzo, img)
        {
            NumAirbag = numAirbag;
        }

        public int NumAirbag { get; set; }

        public override string ToString() { return $"Auto: {base.ToString()} - {NumAirbag} Airbag - {Prezzo} €"; }
    }
}
