namespace ApartmanUygulaması
{
    partial class formMenü
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
            this.btnDaireler = new System.Windows.Forms.Button();
            this.btnBilgiler = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDaireler
            // 
            this.btnDaireler.BackColor = System.Drawing.Color.MintCream;
            this.btnDaireler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDaireler.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDaireler.Location = new System.Drawing.Point(12, 12);
            this.btnDaireler.Name = "btnDaireler";
            this.btnDaireler.Size = new System.Drawing.Size(181, 80);
            this.btnDaireler.TabIndex = 0;
            this.btnDaireler.Text = "Daireler";
            this.btnDaireler.UseVisualStyleBackColor = false;
            // 
            // btnBilgiler
            // 
            this.btnBilgiler.BackColor = System.Drawing.Color.MintCream;
            this.btnBilgiler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiler.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBilgiler.Location = new System.Drawing.Point(199, 12);
            this.btnBilgiler.Name = "btnBilgiler";
            this.btnBilgiler.Size = new System.Drawing.Size(181, 80);
            this.btnBilgiler.TabIndex = 1;
            this.btnBilgiler.Text = "Bilgiler";
            this.btnBilgiler.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.MintCream;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnKaydet.Location = new System.Drawing.Point(12, 98);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(181, 80);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kayıt";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.MintCream;
            this.btnCikis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCikis.Location = new System.Drawing.Point(199, 98);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(181, 80);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // formMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(391, 189);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnBilgiler);
            this.Controls.Add(this.btnDaireler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDaireler;
        private System.Windows.Forms.Button btnBilgiler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCikis;
    }
}