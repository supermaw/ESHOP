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
    public partial class ZakaznikRegister : Form
    {
        public ZakaznikRegister()
        {
            InitializeComponent();
        }

        public string Meno { get; set; }
        public string Priezvisko { get; set; }
        public string Mail { get; set; }
        public string Heslo { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Meno = this.textBoxMeno.Text;
            this.Priezvisko = this.textBoxPriezvisko.Text;
            this.Mail = this.textBoxEmail.Text;
            this.Heslo = this.textBoxHeslo.Text;
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
