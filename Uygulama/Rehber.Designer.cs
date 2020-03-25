namespace Uygulama
{
    partial class Rehber
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmİd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRehberGor = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmİd,
            this.clmSoyad,
            this.clmTeller});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 319);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmİd
            // 
            this.clmİd.Text = "Adlar";
            // 
            // clmSoyad
            // 
            this.clmSoyad.Text = "Soyadlar";
            this.clmSoyad.Width = 113;
            // 
            // clmTeller
            // 
            this.clmTeller.Text = "Telefon Noları";
            this.clmTeller.Width = 258;
            // 
            // btnRehberGor
            // 
            this.btnRehberGor.Location = new System.Drawing.Point(130, 352);
            this.btnRehberGor.Name = "btnRehberGor";
            this.btnRehberGor.Size = new System.Drawing.Size(127, 50);
            this.btnRehberGor.TabIndex = 1;
            this.btnRehberGor.Text = "Rehberi Görüntüle";
            this.btnRehberGor.UseVisualStyleBackColor = true;
            this.btnRehberGor.Click += new System.EventHandler(this.btnRehberGor_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(130, 425);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(127, 50);
            this.btnAnaMenu.TabIndex = 1;
            this.btnAnaMenu.Text = "Ana Menüye Dön";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // Rehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 521);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnRehberGor);
            this.Controls.Add(this.listView1);
            this.Name = "Rehber";
            this.Text = "Rehber";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmİd;
        private System.Windows.Forms.ColumnHeader clmSoyad;
        private System.Windows.Forms.ColumnHeader clmTeller;
        private System.Windows.Forms.Button btnRehberGor;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}