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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        public bool adminPrihlaseny { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Nesprávne meno alebo heslo");
                adminPrihlaseny = false;

            }
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Close();
                adminPrihlaseny = true;
            }
        }

    }
}
