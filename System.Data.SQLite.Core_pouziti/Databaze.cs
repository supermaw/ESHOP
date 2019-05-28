using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Core_pouziti
{
    class Databaze
    {

        private readonly string databazeFileName;
        private readonly string connectionString;
        private string pass;

        public Zakaznik zakaznikZobrazeny { get; private set; }

        public Databaze(string databazeFileName)
        {
            this.databazeFileName = databazeFileName;
            connectionString = $"Data Source={databazeFileName};Version=3;";
        }


        public bool JeDatabazeVytvorena()
        {
            if (System.IO.File.Exists(databazeFileName))
            {
                return true;
            }
            return false;
        }


        public void VytvorDatabazi()
        {
            if (JeDatabazeVytvorena())
            {
                return;
            }

            SQLiteConnection.CreateFile(databazeFileName);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"CREATE TABLE IF NOT EXISTS {Produkt.TableName} ({Produkt.IDString} integer primary key, {Produkt.NazevString} varchar(20) not null, {Produkt.KategorieString} varchar(20) not null, {Produkt.CenaString} int not null, {Produkt.PopisString} varchar(500) not null)";
                SQLiteCommand command = new SQLiteCommand(commandText, connection);
                command.ExecuteNonQuery();

                string commandText2 = $"CREATE TABLE IF NOT EXISTS {Zakaznik.TableName} ({Zakaznik.IDString} integer primary key autoincrement, {Zakaznik.MenoString} varchar(20) not null, {Zakaznik.PriezviskoString} varchar(20) not null, {Zakaznik.MailString} varchar(50) not null, {Zakaznik.HesloString} varchar(30) not null, {Zakaznik.OnlineString} int not null)";
                SQLiteCommand command2 = new SQLiteCommand(commandText2, connection);
                command2.ExecuteNonQuery();                

                string commandText3 = $"CREATE TABLE IF NOT EXISTS {Kosik.TableName} ({Kosik.IDString} integer primary key, {Kosik.ProduktIDString} varchar(10000) not null,{Kosik.NazevString} varchar(20) not null, {Kosik.KategorieString} varchar(20) not null, {Kosik.CenaString} int not null, {Kosik.PopisString} varchar(500) not null )";
                SQLiteCommand command3 = new SQLiteCommand(commandText3, connection);
                command3.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void RegistrujZakaznika(string meno, string priezvisko, string mail, string heslo)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"INSERT INTO {Zakaznik.TableName} ({Zakaznik.MenoString}, {Zakaznik.PriezviskoString}, {Zakaznik.MailString}, {Zakaznik.HesloString},{Zakaznik.OnlineString}) values(@{Zakaznik.MenoString}, @{Zakaznik.PriezviskoString}, @{Zakaznik.MailString}, @{Zakaznik.HesloString}, 0 )";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.MenoString}", meno);
                    command.Parameters.AddWithValue($"@{Zakaznik.PriezviskoString}", priezvisko);
                    command.Parameters.AddWithValue($"@{Zakaznik.MailString}", mail);
                    command.Parameters.AddWithValue($"@{Zakaznik.HesloString}", heslo);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        

        public bool SkontrolujZakaznika(string mail, string heslo)
        {
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT {Zakaznik.HesloString} FROM {Zakaznik.TableName} WHERE {Zakaznik.MailString} = @{Zakaznik.MailString} ";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.MailString}", mail);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             pass = (string)reader[Zakaznik.HesloString];
                        }

                    }
                }
                connection.Close();
            }

            if (pass == heslo)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

       /* public Zakaznik ZobrazZakaznika(string zakaznikMail)
        {
            Zakaznik zakaznik;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT * FROM {Zakaznik.TableName} WHERE {Zakaznik.MailString} = @{Zakaznik.MailString} ";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.MailString}", zakaznikMail);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = (long)reader[Zakaznik.IDString];
                            string meno = (string)reader[Zakaznik.MenoString];
                            string priezvisko = (string)reader[Zakaznik.PriezviskoString];
                            string mail = (string)reader[Zakaznik.MailString];
                            string heslo = (string)reader[Zakaznik.HesloString];
                            int online = (int)reader[Zakaznik.OnlineString];

                            zakaznik = new Zakaznik(id,meno,priezvisko,mail,heslo,online);
                            Zakaznik zakaznikZobrazeny = zakaznik;
                        }
                    }
                }
                connection.Close();
            }
            return zakaznikZobrazeny;

        }*/


        public void VlozProdukt(string nazev, string kategorie, int cena, string popis)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"INSERT INTO {Produkt.TableName} ({Produkt.NazevString}, {Produkt.KategorieString}, {Produkt.CenaString}, {Produkt.PopisString}) values(@{Produkt.NazevString}, @{Produkt.KategorieString}, @{Produkt.CenaString}, @{Produkt.PopisString})";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Produkt.NazevString}", nazev);
                    command.Parameters.AddWithValue($"@{Produkt.KategorieString}", kategorie);
                    command.Parameters.AddWithValue($"@{Produkt.CenaString}", cena);
                    command.Parameters.AddWithValue($"@{Produkt.PopisString}", popis);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        //<><>vložte metodu pro update jednoho konkrétního produktu
        public void UpravProdukt(long idcko,string nazev, string kategorie, int cena, string popis)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText =$"UPDATE {Produkt.TableName} SET {Produkt.NazevString}=@{Produkt.NazevString},{Produkt.KategorieString}=@{Produkt.KategorieString},{Produkt.CenaString}=@{Produkt.CenaString},{Produkt.PopisString}=@{Produkt.PopisString} WHERE {Produkt.IDString}=@{idcko} ";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Produkt.NazevString}", nazev);
                    command.Parameters.AddWithValue($"@{Produkt.KategorieString}", kategorie);
                    command.Parameters.AddWithValue($"@{Produkt.CenaString}", cena);
                    command.Parameters.AddWithValue($"@{Produkt.PopisString}", popis);
                    command.Parameters.AddWithValue($"@{idcko}", idcko);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }


        //<><>vložte metodu pro smazání jednoho konkrétního produktu

        public void ZmazProdukt(long idcko)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"DELETE FROM  {Produkt.TableName} WHERE {Produkt.IDString} =@{idcko} ";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{idcko}", idcko);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        //vkladanie do kosika

        public void VlozProduktKosik(long produktID, string nazev, string kategorie, int cena, string popis)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"INSERT INTO {Kosik.TableName} ({Kosik.ProduktIDString}, {Kosik.NazevString}, {Kosik.KategorieString}, {Kosik.CenaString}, {Kosik.PopisString}) values(@{Kosik.ProduktIDString}, @{Kosik.NazevString}, @{Kosik.KategorieString}, @{Kosik.CenaString}, @{Kosik.PopisString})";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Kosik.ProduktIDString}", produktID);
                    command.Parameters.AddWithValue($"@{Kosik.NazevString}", nazev);
                    command.Parameters.AddWithValue($"@{Kosik.KategorieString}", kategorie);
                    command.Parameters.AddWithValue($"@{Kosik.CenaString}", cena);
                    command.Parameters.AddWithValue($"@{Kosik.PopisString}", popis);                    
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }


        //odstranovanie z kosika
        public void OdstranProduktKosik(long id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"DElETE FROM {Kosik.TableName} WHERE {Kosik.IDString} = @{Kosik.IDString} ";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Kosik.IDString}", id);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }





        public List<Produkt> VratVsechnyProdukty()
        {
            List<Produkt> produkty = new List<Produkt>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT * FROM {Produkt.TableName}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = (long)reader[Produkt.IDString];
                            string nazev = (string)reader[Produkt.NazevString];
                            string kategorie = (string)reader[Produkt.KategorieString];
                            int cena = (int)reader[Produkt.CenaString];
                            string popis = (string)reader[Produkt.PopisString];

                            Produkt produkt = new Produkt(id, nazev, kategorie, cena, popis);
                            produkty.Add(produkt);
                        }
                    }
                }

                connection.Close();
            }

            return produkty;
        }


        public List<Kosik> VratVsechnyProduktyKosiku()
        {
            List<Kosik> produktyKosiku = new List<Kosik>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT * FROM {Kosik.TableName}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = (long)reader[Kosik.IDString];
                            string produktID = (string)reader[Kosik.ProduktIDString];
                            string nazev = (string)reader[Kosik.NazevString];
                            string kategorie = (string)reader[Kosik.KategorieString];
                            int cena = (int)reader[Kosik.CenaString];
                            string popis = (string)reader[Kosik.PopisString];

                            Kosik produkt = new Kosik(id, produktID, nazev, kategorie, cena, popis);
                            produktyKosiku.Add(produkt);
                        }
                    }
                }

                connection.Close();
            }

            return produktyKosiku;
        }
    }
}
