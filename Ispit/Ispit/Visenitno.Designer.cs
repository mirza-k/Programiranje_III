namespace Februarski_3
{
    partial class Visenitno
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
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(37, 74);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(320, 259);
            this.txtIspis.TabIndex = 0;
            // 
            // btnPokreni
            // 
            this.btnPokreni.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPokreni.Location = new System.Drawing.Point(716, 0);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(84, 450);
            this.btnPokreni.TabIndex = 1;
            this.btnPokreni.Text = "Pokreni";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // Visenitno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.txtIspis);
            this.Name = "Visenitno";
            this.Text = "Visenitno";
            this.Load += new System.EventHandler(this.Visenitno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnPokreni;
    }
}