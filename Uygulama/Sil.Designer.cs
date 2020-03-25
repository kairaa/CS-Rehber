namespace Uygulama
{
    partial class Sil
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
            this.label1 = new System.Windows.Forms.Label();
            this.btSil = new System.Windows.Forms.Button();
            this.btnMenü = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSilAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 165);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişi Silme Menüsü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSil
            // 
            this.btSil.Location = new System.Drawing.Point(28, 350);
            this.btSil.Name = "btSil";
            this.btSil.Size = new System.Drawing.Size(117, 54);
            this.btSil.TabIndex = 1;
            this.btSil.Text = "Kişiyi Sil";
            this.btSil.UseVisualStyleBackColor = true;
            this.btSil.Click += new System.EventHandler(this.btSil_Click);
            // 
            // btnMenü
            // 
            this.btnMenü.Location = new System.Drawing.Point(173, 350);
            this.btnMenü.Name = "btnMenü";
            this.btnMenü.Size = new System.Drawing.Size(117, 54);
            this.btnMenü.TabIndex = 1;
            this.btnMenü.Text = "Ana Menüye Dön";
            this.btnMenü.UseVisualStyleBackColor = true;
            this.btnMenü.Click += new System.EventHandler(this.btnMenü_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Silinecek Kişinin Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSilAd
            // 
            this.tbSilAd.Location = new System.Drawing.Point(146, 205);
            this.tbSilAd.Name = "tbSilAd";
            this.tbSilAd.Size = new System.Drawing.Size(127, 22);
            this.tbSilAd.TabIndex = 3;
           
            // 
            // Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.tbSilAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMenü);
            this.Controls.Add(this.btSil);
            this.Controls.Add(this.label1);
            this.Name = "Sil";
            this.Text = "Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSil;
        private System.Windows.Forms.Button btnMenü;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSilAd;
    }
}