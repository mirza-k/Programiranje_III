namespace Februarski_3
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
            this.lblBrojStudenata = new System.Windows.Forms.Label();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblProsjekSvih = new System.Windows.Forms.Label();
            this.BrojIndeksa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrojStudenata
            // 
            this.lblBrojStudenata.AutoSize = true;
            this.lblBrojStudenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojStudenata.Location = new System.Drawing.Point(453, 284);
            this.lblBrojStudenata.Name = "lblBrojStudenata";
            this.lblBrojStudenata.Size = new System.Drawing.Size(60, 24);
            this.lblBrojStudenata.TabIndex = 2;
            this.lblBrojStudenata.Text = "label1";
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojIndeksa,
            this.Ime,
            this.Prezime,
            this.Spol,
            this.Polozeni});
            this.dgvStudenti.Location = new System.Drawing.Point(1, 51);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(698, 230);
            this.dgvStudenti.TabIndex = 3;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(1, 18);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(359, 27);
            this.txtPretraga.TabIndex = 4;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(534, 18);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(75, 27);
            this.btnDetalji.TabIndex = 5;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(624, 18);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 27);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblProsjekSvih
            // 
            this.lblProsjekSvih.AutoSize = true;
            this.lblProsjekSvih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProsjekSvih.Location = new System.Drawing.Point(-3, 284);
            this.lblProsjekSvih.Name = "lblProsjekSvih";
            this.lblProsjekSvih.Size = new System.Drawing.Size(60, 24);
            this.lblProsjekSvih.TabIndex = 7;
            this.lblProsjekSvih.Text = "label1";
            // 
            // BrojIndeksa
            // 
            this.BrojIndeksa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojIndeksa.DataPropertyName = "BrojIndeksa";
            this.BrojIndeksa.HeaderText = "Broj indeksa";
            this.BrojIndeksa.Name = "BrojIndeksa";
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Spol
            // 
            this.Spol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            // 
            // Polozeni
            // 
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.Text = "Polozeni";
            this.Polozeni.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 312);
            this.Controls.Add(this.lblProsjekSvih);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.lblBrojStudenata);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBrojStudenata;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblProsjekSvih;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojIndeksa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
    }
}

