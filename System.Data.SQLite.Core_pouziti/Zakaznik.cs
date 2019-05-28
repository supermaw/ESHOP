using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Core_pouziti
{
    class Zakaznik
    {
        public const string TableName = "ZAKAZNIK";
        public const string IDString = "id";
        public const string MenoString = "meno";
        public const string PriezviskoString = "priezvisko";
        public const string MailString = "mail";
        public const string HesloString = "heslo";
        public const string OnlineString = "online";


        public long Id { get; set; }
        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Mail { get; set; }
        public string Heslo { get; set; }
        public int Online { get; set; }

        public Zakaznik(long id, string meno, string priezvisko, string mail, string heslo, int online)
        {
            Id = id;
            Meno = meno;
            Priezvisko = priezvisko;
            Mail = mail;
            Heslo = heslo;
            Online = online;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Meno: {Meno}, Priezvisko: {Priezvisko}, Mail: {Mail}, Heslo: {Heslo}, Stav Onlne: {Online}";
        }
    }
}
