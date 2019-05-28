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
    public partial class ZakaznikLogin : Form
    {
        public ZakaznikLogin()
        {
            InitializeComponent();
        }
        public string Mail { get; set; }
        public string Heslo { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Mail =this.textBoxMail.Text;
            this.Heslo = this.textBoxHeslo.Text;
            this.Close();
        }
    }
}
