namespace Banka
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bankaDataSet1 = new Banka.BankaDataSet();
            this.klijentTableAdapter1 = new Banka.BankaDataSetTableAdapters.KlijentTableAdapter();
            this.racunTableAdapter1 = new Banka.BankaDataSetTableAdapters.RacunTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDKlijentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxKlijenti = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.tbVeceOD = new System.Windows.Forms.TextBox();
            this.listBoxPrikaz = new System.Windows.Forms.ListBox();
            this.cbImePrezime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxObrada = new System.Windows.Forms.GroupBox();
            this.contextMenuStripObrada = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxRacun = new System.Windows.Forms.GroupBox();
            this.rtbDevizni = new System.Windows.Forms.RadioButton();
            this.rtbNenamesnki = new System.Windows.Forms.RadioButton();
            this.rtbDinarski = new System.Windows.Forms.RadioButton();
            this.rtbNamenski = new System.Windows.Forms.RadioButton();
            this.tbBrojOtvorenih = new System.Windows.Forms.TextBox();
            this.tbRacunSaNajNovca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.karticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            this.groupBoxKlijenti.SuspendLayout();
            this.groupBoxObrada.SuspendLayout();
            this.contextMenuStripObrada.SuspendLayout();
            this.groupBoxRacun.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bankaDataSet1
            // 
            this.bankaDataSet1.DataSetName = "BankaDataSet";
            this.bankaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klijentTableAdapter1
            // 
            this.klijentTableAdapter1.ClearBeforeFill = true;
            // 
            // racunTableAdapter1
            // 
            this.racunTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKlijentDataGridViewTextBoxColumn,
            this.imePrezimeDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn,
            this.racunDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klijentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(577, 122);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDKlijentDataGridViewTextBoxColumn
            // 
            this.iDKlijentDataGridViewTextBoxColumn.DataPropertyName = "IDKlijent";
            this.iDKlijentDataGridViewTextBoxColumn.HeaderText = "IDKlijent";
            this.iDKlijentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDKlijentDataGridViewTextBoxColumn.Name = "iDKlijentDataGridViewTextBoxColumn";
            this.iDKlijentDataGridViewTextBoxColumn.Width = 125;
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            this.imePrezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.HeaderText = "Stanje";
            this.stanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            this.stanjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // racunDataGridViewTextBoxColumn
            // 
            this.racunDataGridViewTextBoxColumn.DataPropertyName = "Racun";
            this.racunDataGridViewTextBoxColumn.DataSource = this.racunBindingSource;
            this.racunDataGridViewTextBoxColumn.DisplayMember = "Tip";
            this.racunDataGridViewTextBoxColumn.HeaderText = "Racun";
            this.racunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.racunDataGridViewTextBoxColumn.Name = "racunDataGridViewTextBoxColumn";
            this.racunDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.racunDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.racunDataGridViewTextBoxColumn.ValueMember = "IDRacun";
            this.racunDataGridViewTextBoxColumn.Width = 125;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.bankaDataSet1BindingSource;
            // 
            // bankaDataSet1BindingSource
            // 
            this.bankaDataSet1BindingSource.DataSource = this.bankaDataSet1;
            this.bankaDataSet1BindingSource.Position = 0;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataMember = "Klijent";
            this.klijentBindingSource.DataSource = this.bankaDataSet1BindingSource;
            // 
            // groupBoxKlijenti
            // 
            this.groupBoxKlijenti.Controls.Add(this.btnPretrazi);
            this.groupBoxKlijenti.Controls.Add(this.tbVeceOD);
            this.groupBoxKlijenti.Controls.Add(this.listBoxPrikaz);
            this.groupBoxKlijenti.Controls.Add(this.cbImePrezime);
            this.groupBoxKlijenti.Controls.Add(this.label4);
            this.groupBoxKlijenti.Controls.Add(this.label3);
            this.groupBoxKlijenti.Controls.Add(this.label2);
            this.groupBoxKlijenti.Location = new System.Drawing.Point(64, 170);
            this.groupBoxKlijenti.Name = "groupBoxKlijenti";
            this.groupBoxKlijenti.Size = new System.Drawing.Size(701, 145);
            this.groupBoxKlijenti.TabIndex = 1;
            this.groupBoxKlijenti.TabStop = false;
            this.groupBoxKlijenti.Text = "Klijenti";
            this.groupBoxKlijenti.Enter += new System.EventHandler(this.groupBoxKlijenti_Enter);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(523, 104);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 8;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // tbVeceOD
            // 
            this.tbVeceOD.Location = new System.Drawing.Point(523, 65);
            this.tbVeceOD.Name = "tbVeceOD";
            this.tbVeceOD.Size = new System.Drawing.Size(100, 20);
            this.tbVeceOD.TabIndex = 7;
            // 
            // listBoxPrikaz
            // 
            this.listBoxPrikaz.FormattingEnabled = true;
            this.listBoxPrikaz.Location = new System.Drawing.Point(206, 35);
            this.listBoxPrikaz.Name = "listBoxPrikaz";
            this.listBoxPrikaz.Size = new System.Drawing.Size(226, 95);
            this.listBoxPrikaz.TabIndex = 6;
            // 
            // cbImePrezime
            // 
            this.cbImePrezime.FormattingEnabled = true;
            this.cbImePrezime.Location = new System.Drawing.Point(37, 65);
            this.cbImePrezime.Name = "cbImePrezime";
            this.cbImePrezime.Size = new System.Drawing.Size(121, 21);
            this.cbImePrezime.TabIndex = 5;
            this.cbImePrezime.SelectedIndexChanged += new System.EventHandler(this.cbImePrezime_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stanje na racunu vise od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prikaz podataka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ime i prezime";
            // 
            // groupBoxObrada
            // 
            this.groupBoxObrada.ContextMenuStrip = this.contextMenuStripObrada;
            this.groupBoxObrada.Controls.Add(this.groupBoxRacun);
            this.groupBoxObrada.Controls.Add(this.tbBrojOtvorenih);
            this.groupBoxObrada.Controls.Add(this.tbRacunSaNajNovca);
            this.groupBoxObrada.Controls.Add(this.label6);
            this.groupBoxObrada.Controls.Add(this.label5);
            this.groupBoxObrada.Location = new System.Drawing.Point(64, 321);
            this.groupBoxObrada.Name = "groupBoxObrada";
            this.groupBoxObrada.Size = new System.Drawing.Size(701, 147);
            this.groupBoxObrada.TabIndex = 2;
            this.groupBoxObrada.TabStop = false;
            this.groupBoxObrada.Text = "Obrada";
            // 
            // contextMenuStripObrada
            // 
            this.contextMenuStripObrada.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripObrada.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obradaToolStripMenuItem});
            this.contextMenuStripObrada.Name = "contextMenuStripObrada";
            this.contextMenuStripObrada.Size = new System.Drawing.Size(114, 26);
            // 
            // obradaToolStripMenuItem
            // 
            this.obradaToolStripMenuItem.Name = "obradaToolStripMenuItem";
            this.obradaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.obradaToolStripMenuItem.Text = "Obrada";
            this.obradaToolStripMenuItem.Click += new System.EventHandler(this.obradaToolStripMenuItem_Click);
            // 
            // groupBoxRacun
            // 
            this.groupBoxRacun.Controls.Add(this.rtbDevizni);
            this.groupBoxRacun.Controls.Add(this.rtbNenamesnki);
            this.groupBoxRacun.Controls.Add(this.rtbDinarski);
            this.groupBoxRacun.Controls.Add(this.rtbNamenski);
            this.groupBoxRacun.Location = new System.Drawing.Point(37, 31);
            this.groupBoxRacun.Name = "groupBoxRacun";
            this.groupBoxRacun.Size = new System.Drawing.Size(200, 100);
            this.groupBoxRacun.TabIndex = 5;
            this.groupBoxRacun.TabStop = false;
            this.groupBoxRacun.Text = "Racun";
            // 
            // rtbDevizni
            // 
            this.rtbDevizni.AutoSize = true;
            this.rtbDevizni.Location = new System.Drawing.Point(120, 65);
            this.rtbDevizni.Name = "rtbDevizni";
            this.rtbDevizni.Size = new System.Drawing.Size(60, 17);
            this.rtbDevizni.TabIndex = 3;
            this.rtbDevizni.TabStop = true;
            this.rtbDevizni.Text = "Devizni";
            this.rtbDevizni.UseVisualStyleBackColor = true;
            this.rtbDevizni.CheckedChanged += new System.EventHandler(this.rtbDevizni_CheckedChanged);
            // 
            // rtbNenamesnki
            // 
            this.rtbNenamesnki.AutoSize = true;
            this.rtbNenamesnki.Location = new System.Drawing.Point(7, 65);
            this.rtbNenamesnki.Name = "rtbNenamesnki";
            this.rtbNenamesnki.Size = new System.Drawing.Size(84, 17);
            this.rtbNenamesnki.TabIndex = 2;
            this.rtbNenamesnki.TabStop = true;
            this.rtbNenamesnki.Text = "Nenamenski";
            this.rtbNenamesnki.UseVisualStyleBackColor = true;
            this.rtbNenamesnki.CheckedChanged += new System.EventHandler(this.rtbNenamesnki_CheckedChanged);
            // 
            // rtbDinarski
            // 
            this.rtbDinarski.AutoSize = true;
            this.rtbDinarski.Location = new System.Drawing.Point(120, 23);
            this.rtbDinarski.Name = "rtbDinarski";
            this.rtbDinarski.Size = new System.Drawing.Size(63, 17);
            this.rtbDinarski.TabIndex = 1;
            this.rtbDinarski.TabStop = true;
            this.rtbDinarski.Text = "Dinarski";
            this.rtbDinarski.UseVisualStyleBackColor = true;
            this.rtbDinarski.CheckedChanged += new System.EventHandler(this.rtbDinarski_CheckedChanged);
            // 
            // rtbNamenski
            // 
            this.rtbNamenski.AutoSize = true;
            this.rtbNamenski.Location = new System.Drawing.Point(7, 22);
            this.rtbNamenski.Name = "rtbNamenski";
            this.rtbNamenski.Size = new System.Drawing.Size(72, 17);
            this.rtbNamenski.TabIndex = 0;
            this.rtbNamenski.TabStop = true;
            this.rtbNamenski.Text = "Namenski";
            this.rtbNamenski.UseVisualStyleBackColor = true;
            this.rtbNamenski.CheckedChanged += new System.EventHandler(this.rtbNamenski_CheckedChanged);
            // 
            // tbBrojOtvorenih
            // 
            this.tbBrojOtvorenih.Location = new System.Drawing.Point(546, 98);
            this.tbBrojOtvorenih.Name = "tbBrojOtvorenih";
            this.tbBrojOtvorenih.Size = new System.Drawing.Size(100, 20);
            this.tbBrojOtvorenih.TabIndex = 4;
            // 
            // tbRacunSaNajNovca
            // 
            this.tbRacunSaNajNovca.Location = new System.Drawing.Point(546, 51);
            this.tbRacunSaNajNovca.Name = "tbRacunSaNajNovca";
            this.tbRacunSaNajNovca.Size = new System.Drawing.Size(100, 20);
            this.tbRacunSaNajNovca.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Broj otvorenih racuna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Racun sa najvise novca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kartica";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // karticaToolStripMenuItem
            // 
            this.karticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentToolStripMenuItem});
            this.karticaToolStripMenuItem.Name = "karticaToolStripMenuItem";
            this.karticaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.karticaToolStripMenuItem.Text = "Kartica";
            // 
            // klijentToolStripMenuItem
            // 
            this.klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            this.klijentToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.klijentToolStripMenuItem.Text = "Klijent";
            this.klijentToolStripMenuItem.Click += new System.EventHandler(this.klijentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxObrada);
            this.Controls.Add(this.groupBoxKlijenti);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            this.groupBoxKlijenti.ResumeLayout(false);
            this.groupBoxKlijenti.PerformLayout();
            this.groupBoxObrada.ResumeLayout(false);
            this.groupBoxObrada.PerformLayout();
            this.contextMenuStripObrada.ResumeLayout(false);
            this.groupBoxRacun.ResumeLayout(false);
            this.groupBoxRacun.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankaDataSet bankaDataSet1;
        private BankaDataSetTableAdapters.KlijentTableAdapter klijentTableAdapter1;
        private BankaDataSetTableAdapters.RacunTableAdapter racunTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.BindingSource bankaDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKlijentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn racunDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.GroupBox groupBoxKlijenti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxObrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVeceOD;
        private System.Windows.Forms.ListBox listBoxPrikaz;
        private System.Windows.Forms.ComboBox cbImePrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxRacun;
        private System.Windows.Forms.RadioButton rtbDevizni;
        private System.Windows.Forms.RadioButton rtbNenamesnki;
        private System.Windows.Forms.RadioButton rtbDinarski;
        private System.Windows.Forms.RadioButton rtbNamenski;
        private System.Windows.Forms.TextBox tbBrojOtvorenih;
        private System.Windows.Forms.TextBox tbRacunSaNajNovca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripObrada;
        private System.Windows.Forms.ToolStripMenuItem obradaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem karticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentToolStripMenuItem;
    }
}

