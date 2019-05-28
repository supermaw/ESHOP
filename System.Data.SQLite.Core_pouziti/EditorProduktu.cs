using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Data.SQLite.Core_pouziti
{
    public partial class EditorProduktu : Form
    {
        public EditorProduktu()
        {
            InitializeComponent();
        }

        public string Nazev { get; set; }
        public string Kategorie { get; set; }
        public int Cena { get; set; }
        public string Popis { get; set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled)
                && ZkontrolujNazev()
                && ZkontrolujKategorii()
                && ZkontrolujCenu()
                && ZkontrolujPopis())
            {
                this.Nazev = this.textBoxNazev.Text;
                this.Kategorie = this.textBoxKategorie.Text;
                try
                {
                    this.Cena = Convert.ToInt32(this.textBoxCena.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při převádění ceny na číslo: " + ex.Message);
                    return;
                }
                this.Popis = this.textBoxPopis.Text;

                //nastavení vracení hodnoty DialogResult.Ok a zavření formuláře
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void buttonStorno_Click(object sender, EventArgs e)
        {
            //zavření formuláře (pozn. tlačítko je již nastaveno, aby vracelo DialogResult.Cancel)
            this.Close();
        }



        private void textBoxNazev_Validating(object sender, CancelEventArgs e)
        {
            ZkontrolujNazev();
        }

        private bool ZkontrolujNazev()
        {
            bool OK = false;
            if (String.IsNullOrWhiteSpace(this.textBoxNazev.Text))
            {
                this.errorProviderNazev.SetError(this.textBoxNazev, "Název nesmí být prázdný!");
            }
            else
            {
                this.errorProviderNazev.SetError(this.textBoxNazev, String.Empty);
                OK = true;
            }
            return OK;
        }



        private void textBoxKategorie_Validating(object sender, CancelEventArgs e)
        {
            ZkontrolujKategorii();
        }

        private bool ZkontrolujKategorii()
        {
            bool OK = false;
            if (String.IsNullOrWhiteSpace(this.textBoxKategorie.Text))
            {
                this.errorProviderNazev.SetError(this.textBoxKategorie, "Kategorie nesmí být prázdná!");
            }
            else
            {
                this.errorProviderNazev.SetError(this.textBoxKategorie, String.Empty);
                OK = true;
            }
            return OK;
        }




        private void textBoxCena_Validating(object sender, CancelEventArgs e)
        {
            ZkontrolujCenu();
        }

        private bool ZkontrolujCenu()
        {
            bool OK = false;
            uint cena = 0;
            if (String.IsNullOrWhiteSpace(this.textBoxCena.Text))
            {
                this.errorProviderNazev.SetError(this.textBoxCena, "Cena nesmí být prázdná!");
            }
            else if (uint.TryParse(this.textBoxCena.Text, out cena) == false)
            {
                this.errorProviderNazev.SetError(this.textBoxCena, "Cena musí být zadána jako celé, kladné číslo!");
            }
            else
            {
                this.errorProviderNazev.SetError(this.textBoxCena, String.Empty);
                OK = true;
            }
            return OK;
        }



        private void textBoxPopis_Validating(object sender, CancelEventArgs e)
        {
            this.ZkontrolujPopis();
        }

        private bool ZkontrolujPopis()
        {
            bool OK = false;
            if (String.IsNullOrWhiteSpace(this.textBoxPopis.Text))
            {
                this.errorProviderNazev.SetError(this.textBoxPopis, "Popis nesmí být prázdný!");
            }
            else
            {
                this.errorProviderNazev.SetError(this.textBoxPopis, String.Empty);
                OK = true;
            }
            return OK;
        }


    }
}
