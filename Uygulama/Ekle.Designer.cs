namespace Uygulama
{
    partial class Ekle
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(48, 372);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(108, 51);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kişiyi Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(215, 372);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(108, 51);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Ana Menüye Dön";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 138);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kişi Ekleme Menüsü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı:";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(185, 199);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(137, 22);
            this.tbAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı:";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(185, 257);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(137, 22);
            this.tbSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefonu:";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(185, 310);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(137, 22);
            this.tbTel.TabIndex = 3;
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Ekle";
            this.Text = "Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTel;
    }
}