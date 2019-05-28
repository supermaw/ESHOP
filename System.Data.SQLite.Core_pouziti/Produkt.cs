using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Core_pouziti
{
    class Produkt
    {

        public const string TableName = "PRODUKT";
        public const string IDString = "id";
        public const string NazevString = "nazev";
        public const string KategorieString = "kategorie";
        public const string CenaString = "cena";
        public const string PopisString = "popis";


        public long Id { get; set; }
        public string Nazev { get; set; }
        public string Kategorie { get; set; }
        public int Cena { get; set; }
        public string Popis { get; set; }

        public Produkt(long id, string nazev, string kategorie, int cena, string popis)
        {
            Id = id;
            Nazev = nazev;
            Kategorie = kategorie;
            Cena = cena;
            Popis = popis;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nazev: {Nazev}, Kategorie: {Kategorie}, Cena: {Cena}, Popis: {Popis}";
        }
    }
}
