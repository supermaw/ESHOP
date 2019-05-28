namespace System.Data.SQLite.Core_pouziti
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogDatabaze = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogDatabaze = new System.Windows.Forms.SaveFileDialog();
            this.toolStripMenuItemDatabaze = new System.Windows.Forms.ToolStripMenuItem();
            this.vytvořitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.připojitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSQLite = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxObjednavky = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonPridat = new System.Windows.Forms.Button();
            this.listBoxProdukty = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxProduktyZakaznik = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxKosik = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogDatabaze
            // 
            this.openFileDialogDatabaze.Filter = "Soubory SQLite|*.sqlite";
            // 
            // saveFileDialogDatabaze
            // 
            this.saveFileDialogDatabaze.Filter = "Soubory SQLite|*.sqlite";
            // 
            // toolStripMenuItemDatabaze
            // 
            this.toolStripMenuItemDatabaze.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vytvořitToolStripMenuItem,
            this.připojitToolStripMenuItem});
            this.toolStripMenuItemDatabaze.Name = "toolStripMenuItemDatabaze";
            this.toolStripMenuItemDatabaze.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItemDatabaze.Text = "Databáze";
            // 
            // vytvořitToolStripMenuItem
            // 
            this.vytvořitToolStripMenuItem.Name = "vytvořitToolStripMenuItem";
            this.vytvořitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.vytvořitToolStripMenuItem.Text = "Vytvořit";
            this.vytvořitToolStripMenuItem.Click += new System.EventHandler(this.vytvořitToolStripMenuItem_Click);
            // 
            // připojitToolStripMenuItem
            // 
            this.připojitToolStripMenuItem.Name = "připojitToolStripMenuItem";
            this.připojitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.připojitToolStripMenuItem.Text = "Připojit";
            this.připojitToolStripMenuItem.Click += new System.EventHandler(this.připojitToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSQLite
            // 
            this.toolStripMenuItemSQLite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItemSQLite.Name = "toolStripMenuItemSQLite";
            this.toolStripMenuItemSQLite.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItemSQLite.Text = "SQLite";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDatabaze,
            this.toolStripMenuItemSQLite});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.label4);
            this.tabPageAdmin.Controls.Add(this.listBoxObjednavky);
            this.tabPageAdmin.Controls.Add(this.button1);
            this.tabPageAdmin.Controls.Add(this.buttonDelete);
            this.tabPageAdmin.Controls.Add(this.buttonEdit);
            this.tabPageAdmin.Controls.Add(this.buttonPridat);
            this.tabPageAdmin.Controls.Add(this.listBoxProdukty);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(1090, 457);
            this.tabPageAdmin.TabIndex = 0;
            this.tabPageAdmin.Text = "Administrator";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produkty";
            // 
            // listBoxObjednavky
            // 
            this.listBoxObjednavky.FormattingEnabled = true;
            this.listBoxObjednavky.Location = new System.Drawing.Point(486, 29);
            this.listBoxObjednavky.Name = "listBoxObjednavky";
            this.listBoxObjednavky.Size = new System.Drawing.Size(434, 420);
            this.listBoxObjednavky.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 61);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Smazat";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(3, 32);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Editovat";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonPridat
            // 
            this.buttonPridat.Location = new System.Drawing.Point(3, 3);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(75, 23);
            this.buttonPridat.TabIndex = 1;
            this.buttonPridat.Text = "Přidat";
            this.buttonPridat.UseVisualStyleBackColor = true;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // listBoxProdukty
            // 
            this.listBoxProdukty.FormattingEnabled = true;
            this.listBoxProdukty.Location = new System.Drawing.Point(90, 29);
            this.listBoxProdukty.Name = "listBoxProdukty";
            this.listBoxProdukty.Size = new System.Drawing.Size(390, 420);
            this.listBoxProdukty.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdmin);
            this.tabControl1.Controls.Add(this.tabPageUser);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 483);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.button6);
            this.tabPageUser.Controls.Add(this.label9);
            this.tabPageUser.Controls.Add(this.button5);
            this.tabPageUser.Controls.Add(this.label8);
            this.tabPageUser.Controls.Add(this.label7);
            this.tabPageUser.Controls.Add(this.label6);
            this.tabPageUser.Controls.Add(this.label5);
            this.tabPageUser.Controls.Add(this.listBoxProduktyZakaznik);
            this.tabPageUser.Controls.Add(this.button4);
            this.tabPageUser.Controls.Add(this.button3);
            this.tabPageUser.Controls.Add(this.listBoxKosik);
            this.tabPageUser.Controls.Add(this.button2);
            this.tabPageUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(1090, 457);
            this.tabPageUser.TabIndex = 1;
            this.tabPageUser.Text = "Uživatel";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(975, 421);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Vytvoriť";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(867, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Vytvoriť objednávku";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(740, 421);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Odstrániť";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(561, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Odstrániť vybraný produkt z košíku";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vložiť vybraný produkt do košíku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Produkty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Košík";
            // 
            // listBoxProduktyZakaznik
            // 
            this.listBoxProduktyZakaznik.FormattingEnabled = true;
            this.listBoxProduktyZakaznik.Location = new System.Drawing.Point(84, 29);
            this.listBoxProduktyZakaznik.Name = "listBoxProduktyZakaznik";
            this.listBoxProduktyZakaznik.Size = new System.Drawing.Size(474, 381);
            this.listBoxProduktyZakaznik.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Registrovať";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Prihlásiť";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxKosik
            // 
            this.listBoxKosik.FormattingEnabled = true;
            this.listBoxKosik.Location = new System.Drawing.Point(564, 29);
            this.listBoxKosik.Name = "listBoxKosik";
            this.listBoxKosik.Size = new System.Drawing.Size(518, 381);
            this.listBoxKosik.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Do košíku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prhlásený používateľ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(992, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1003, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "offline";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ESHOP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageAdmin.ResumeLayout(false);
            this.tabPageAdmin.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Windows.Forms.OpenFileDialog openFileDialogDatabaze;
        private Windows.Forms.SaveFileDialog saveFileDialogDatabaze;
        private Windows.Forms.ToolStripMenuItem toolStripMenuItemDatabaze;
        private Windows.Forms.ToolStripMenuItem vytvořitToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem připojitToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem toolStripMenuItemSQLite;
        private Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private Windows.Forms.MenuStrip menuStrip1;
        private Windows.Forms.TabPage tabPageAdmin;
        private Windows.Forms.Button button1;
        private Windows.Forms.Button buttonDelete;
        private Windows.Forms.Button buttonEdit;
        private Windows.Forms.Button buttonPridat;
        private Windows.Forms.ListBox listBoxProdukty;
        private Windows.Forms.TabControl tabControl1;
        private Windows.Forms.TabPage tabPageUser;
        private Windows.Forms.Button button2;
        private Windows.Forms.ListBox listBoxKosik;
        private Windows.Forms.Button button3;
        private Windows.Forms.Button button4;
        private Windows.Forms.Label label1;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label3;
        private Windows.Forms.ListBox listBoxProduktyZakaznik;
        private Windows.Forms.ListBox listBoxObjednavky;
        private Windows.Forms.Label label4;
        private Windows.Forms.Label label6;
        private Windows.Forms.Label label5;
        private Windows.Forms.Button button5;
        private Windows.Forms.Label label8;
        private Windows.Forms.Label label7;
        private Windows.Forms.Button button6;
        private Windows.Forms.Label label9;
    }
}

