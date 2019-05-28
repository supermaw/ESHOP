using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Data.SQLite.Core_pouziti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Databaze databaze = null;
        private List<Produkt> produkty;
        private List<Kosik> produktyKosik;
        public BindingSource bindingSource = new BindingSource();
        public BindingSource bindingSourceKosik = new BindingSource();
        public bool adminJePrihlaseny { get; set; }
        public bool zakaznikJePrihlaseny { get; set; }

        private void vytvořitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogDatabaze.ShowDialog() == DialogResult.OK)
            {
                databaze = new Databaze(saveFileDialogDatabaze.FileName);

                if (databaze.JeDatabazeVytvorena())
                {
                    File.Delete(saveFileDialogDatabaze.FileName);
                }
                databaze.VytvorDatabazi();

                this.produkty = new List<Produkt>();
                this.produktyKosik = new List<Kosik>();

                this.PripojSeznam();
                this.PripojSeznamKosik();
            }
        }




        private void připojitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogDatabaze.ShowDialog() == DialogResult.OK)
            {
                databaze = new Databaze(openFileDialogDatabaze.FileName);

                if (!databaze.JeDatabazeVytvorena())
                {
                    databaze.VytvorDatabazi();
                }

                try
                {
                    this.produkty = databaze.VratVsechnyProdukty();
                    this.produktyKosik = databaze.VratVsechnyProduktyKosiku();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při pokusu výběru všech produktů: " + ex.Message);
                    return;
                }

                this.PripojSeznam();
                this.PripojSeznamKosik();

            }

        }



        private void PripojSeznam()
        {
            //napojení na DataGridView pomocí prvku BindingSource
            //toto způsobí, že se napojený seznam automaticky změní podle toho, co provedeme v dataGridView
            if (bindingSource != null && this.produkty != null)
            {
                //Produkty admin
                if (listBoxProdukty.DataSource == null)
                {
                    listBoxProdukty.Items.Clear();
                }
                bindingSource.DataSource = this.produkty;
                listBoxProdukty.DataSource = bindingSource;

                //Produkty zakaznik
                if (listBoxProduktyZakaznik.DataSource == null)
                {
                    listBoxProduktyZakaznik.Items.Clear();
                }
                bindingSource.DataSource = this.produkty;
                listBoxProduktyZakaznik.DataSource = bindingSource;

            }
        }


        private void PripojSeznamKosik()
        {
            //napojení na DataGridView pomocí prvku BindingSource
            //toto způsobí, že se napojený seznam automaticky změní podle toho, co provedeme v dataGridView
            if (bindingSourceKosik != null && this.produktyKosik != null)
            {
                //Produkty kosiku
                if (listBoxKosik.DataSource == null)
                {
                    listBoxKosik.Items.Clear();
                }
                bindingSourceKosik.DataSource = this.produktyKosik;
                listBoxKosik.DataSource = bindingSourceKosik;
            }
        }


        //pridanie produktu
        private void buttonPridat_Click(object sender, EventArgs e)
        {
            if (databaze == null)
            {
                MessageBox.Show("Pripoj databazu");
            }
            else if (!adminJePrihlaseny)
            {
                AdminLogin adminPrihlasenie = new AdminLogin();
                adminPrihlasenie.ShowDialog();
                if (adminPrihlasenie.adminPrihlaseny)
                {
                    adminJePrihlaseny = true;
                }
            }

            else if (databaze != null && adminJePrihlaseny)
            {
                EditorProduktu editorProduktu = new EditorProduktu();
                if (editorProduktu.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        databaze.VlozProdukt(editorProduktu.Nazev, editorProduktu.Kategorie, editorProduktu.Cena, editorProduktu.Popis);

                        //refresh produktů v ListBoxu
                        this.produkty = databaze.VratVsechnyProdukty();
                        this.PripojSeznam();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Při vkládání produktu do databáze došlo k chybě: " + ex.Message);
                    }
                }
            }
        }

        //edit produktu
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (databaze == null)
            {
                MessageBox.Show("Pripoj databazu");
            }
            else if (!adminJePrihlaseny)
            {
                AdminLogin adminPrihlasenie = new AdminLogin();
                adminPrihlasenie.ShowDialog();
                if (adminPrihlasenie.adminPrihlaseny)
                {
                    adminJePrihlaseny = true;
                }
            }

            else if (databaze != null && adminJePrihlaseny)
            {
                int zvolenyIndex = listBoxProdukty.SelectedIndex;
                Produkt upravovanyProdukt = produkty[zvolenyIndex];

                EditorProduktu editorProduktu = new EditorProduktu();

                if (editorProduktu.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {

                        databaze.UpravProdukt(upravovanyProdukt.Id,editorProduktu.Nazev, editorProduktu.Kategorie, editorProduktu.Cena, editorProduktu.Popis);

                        //refresh produktů v ListBoxu
                        this.produkty = databaze.VratVsechnyProdukty();
                        this.PripojSeznam();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Při uprave produktu v databázi došlo k chybě: " + ex.Message);
                    }
                }
            }
        }

        //mazanie produktu
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (databaze == null)
            {
                MessageBox.Show("Pripoj databazu");
            }
            else if (!adminJePrihlaseny)
            {
                AdminLogin adminPrihlasenie = new AdminLogin();
                adminPrihlasenie.ShowDialog();
                if (adminPrihlasenie.adminPrihlaseny)
                {
                    adminJePrihlaseny = true;
                }
                 
            }

            else if (databaze != null && adminJePrihlaseny)
            {

                int zvolenyIndex = listBoxProdukty.SelectedIndex;                    
                Produkt mazanyProdukt = produkty[zvolenyIndex];


                if (MessageBox.Show($"Smazat {mazanyProdukt} ?"," Mazanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        databaze.ZmazProdukt(mazanyProdukt.Id);

                        //refresh produktů v ListBoxu
                        this.produkty = databaze.VratVsechnyProdukty();
                        this.PripojSeznam();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Při mazani produktu v databázi došlo k chybě: " + ex.Message);
                    }
                }
            }
            
            //<><>doplňte kód pro smazání produktu
        }



        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Pro práci s SQLite je nutné nainstalovat NuGet package (balíček NuGet) s názvem \"System.Data.SQLite.Core\"" + Environment.NewLine;
            message += "Po kliknutí pravým tlačítkem na References (Odkazy) vyberte z kontextového menu \"Manage NuGet Packages...\" (\"Spravovat balíčky NuGet...\")" + Environment.NewLine;
            message += "V okně klikněte na procházet a zadejte vyhledání \"System.Data.SQLite.Core\"." + Environment.NewLine;
            message += "Klikněte na nalezený balíček a poté na tlačítko Install (Nainstalovat)." + Environment.NewLine;
            MessageBox.Show(message);
        }

        // registracia zakaznik
        private void button4_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                ZakaznikRegister zakaznikRegister = new ZakaznikRegister();
                zakaznikRegister.ShowDialog();
                try
                {
                    databaze.RegistrujZakaznika(zakaznikRegister.Meno, zakaznikRegister.Priezvisko, zakaznikRegister.Mail, zakaznikRegister.Heslo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pri registracii nastala chyba: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Pripoj databazu");
            }

        }

        // login zakaznik
        private void button3_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                if (!zakaznikJePrihlaseny)
                {
                    ZakaznikLogin zakaznikLogin = new ZakaznikLogin();
                    zakaznikLogin.ShowDialog();
                    try
                    {
                        if (databaze.SkontrolujZakaznika(zakaznikLogin.Mail, zakaznikLogin.Heslo))
                        {
                            zakaznikJePrihlaseny = true;
                            label3.Text = zakaznikLogin.Mail;

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Pri prihlaseni nastala chyba: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pripoj databazu");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        //pridanie do kosiku

        private void button2_Click(object sender, EventArgs e)
        {
            if (databaze == null)
            {
                MessageBox.Show("Pripoj databazu");
            }
            else if (!zakaznikJePrihlaseny)
            {
                MessageBox.Show("Prihlas sa prosim");
            }

            else if (databaze != null && zakaznikJePrihlaseny)
            {
                int zvolenyIndex = listBoxProduktyZakaznik.SelectedIndex;
                Produkt pridavanyProduktDoKosika = produkty[zvolenyIndex];

                try
                {
                    databaze.VlozProduktKosik(pridavanyProduktDoKosika.Id, pridavanyProduktDoKosika.Nazev, pridavanyProduktDoKosika.Kategorie, pridavanyProduktDoKosika.Cena, pridavanyProduktDoKosika.Popis);

                    this.produktyKosik = databaze.VratVsechnyProduktyKosiku();
                    this.PripojSeznamKosik();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pri vkladani do kosiku nastala chyba: " + ex.Message);
                }
            }
        }


        //odstranovanie z košíku
        private void button5_Click(object sender, EventArgs e)
        {

            if (databaze == null)
            {
                MessageBox.Show("Pripoj databazu");
            }
            else if (!zakaznikJePrihlaseny)
            {
                MessageBox.Show("Prihlas sa prosim");
            }

            else if (databaze != null && zakaznikJePrihlaseny)
            {
                int zvolenyIndex = listBoxKosik.SelectedIndex;
                if (zvolenyIndex < 0)
                {
                    MessageBox.Show("Nespravne zvoleny produkt: ");
                }
                else
                {
                    Kosik mazanyProduktDoKosika = produktyKosik[zvolenyIndex];

                    try
                    {
                        databaze.OdstranProduktKosik(mazanyProduktDoKosika.Id);
                        this.produktyKosik = databaze.VratVsechnyProduktyKosiku();
                        this.PripojSeznamKosik();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Pri odstraneni produktu z kosiku nastala chyba: " + ex.Message);
                    }
                }
            }

            

        }
    }
}
