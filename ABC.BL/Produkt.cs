﻿using Common;
using System;

namespace ABC.BL
{
    public class Produkt : KlasaBazowa
    {
        public Produkt()
        {

        }

        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        public int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        private string _NazwaProduktu;

        public string NazwaProduktu
        {
            get {
                
                return ObslugaStringa.WstawSpacje(_NazwaProduktu); 
            }
            set { _NazwaProduktu = value; }
        }
         

        /// <summary>
        /// Sprawdzamy dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;

            return poprawne;
        }

        public override string ToString()
        {
            return NazwaProduktu;
        }
    }
}
