namespace Februarski_3
{
    partial class PrikazPredmeta
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
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProsjekPredmeta = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.dateTimePolaganje = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.chbPolozeni = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Ocjena,
            this.Datum});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(1, 78);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.RowTemplate.Height = 24;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(651, 150);
            this.dgvPolozeniPredmeti.TabIndex = 0;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // lblProsjekPredmeta
            // 
            this.lblProsjekPredmeta.AutoSize = true;
            this.lblProsjekPredmeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProsjekPredmeta.Location = new System.Drawing.Point(-3, 231);
            this.lblProsjekPredmeta.Name = "lblProsjekPredmeta";
            this.lblProsjekPredmeta.Size = new System.Drawing.Size(53, 20);
            this.lblProsjekPredmeta.TabIndex = 1;
            this.lblProsjekPredmeta.Text = "label1";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(1, 12);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(261, 28);
            this.cmbPredmeti.TabIndex = 2;
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Location = new System.Drawing.Point(283, 12);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(55, 28);
            this.cmbOcjena.TabIndex = 3;
            // 
            // dateTimePolaganje
            // 
            this.dateTimePolaganje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePolaganje.Location = new System.Drawing.Point(360, 13);
            this.dateTimePolaganje.Name = "dateTimePolaganje";
            this.dateTimePolaganje.Size = new System.Drawing.Size(172, 27);
            this.dateTimePolaganje.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(566, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(61, 28);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(487, 231);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(61, 28);
            this.btnAsync.TabIndex = 6;
            this.btnAsync.Text = "Async";
            this.btnAsync.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(566, 231);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(75, 28);
            this.btnIzvjestaj.TabIndex = 7;
            this.btnIzvjestaj.Text = "Izvjestaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // chbPolozeni
            // 
            this.chbPolozeni.AutoSize = true;
            this.chbPolozeni.Location = new System.Drawing.Point(1, 46);
            this.chbPolozeni.Name = "chbPolozeni";
            this.chbPolozeni.Size = new System.Drawing.Size(101, 21);
            this.chbPolozeni.TabIndex = 8;
            this.chbPolozeni.Text = "Nepolozeni";
            this.chbPolozeni.UseVisualStyleBackColor = true;
            this.chbPolozeni.CheckedChanged += new System.EventHandler(this.chbPolozeni_CheckedChanged);
            // 
            // PrikazPredmeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 260);
            this.Controls.Add(this.chbPolozeni);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dateTimePolaganje);
            this.Controls.Add(this.cmbOcjena);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.lblProsjekPredmeta);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Name = "PrikazPredmeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrikazPredmeta";
            this.Load += new System.EventHandler(this.PrikazPredmeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.Label lblProsjekPredmeta;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.ComboBox cmbOcjena;
        private System.Windows.Forms.DateTimePicker dateTimePolaganje;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.CheckBox chbPolozeni;
    }
}