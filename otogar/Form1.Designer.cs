namespace otogar
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btncikis = new System.Windows.Forms.Button();
            this.btnyonetici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Silver;
            this.btncikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis.FlatAppearance.BorderSize = 0;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Image = ((System.Drawing.Image)(resources.GetObject("btncikis.Image")));
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.Location = new System.Drawing.Point(212, 103);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(150, 36);
            this.btncikis.TabIndex = 7;
            this.btncikis.Text = "Çıkış Yap";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnyonetici
            // 
            this.btnyonetici.BackColor = System.Drawing.Color.Silver;
            this.btnyonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyonetici.FlatAppearance.BorderSize = 0;
            this.btnyonetici.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnyonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyonetici.Image = ((System.Drawing.Image)(resources.GetObject("btnyonetici.Image")));
            this.btnyonetici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyonetici.Location = new System.Drawing.Point(12, 12);
            this.btnyonetici.Name = "btnyonetici";
            this.btnyonetici.Size = new System.Drawing.Size(350, 85);
            this.btnyonetici.TabIndex = 6;
            this.btnyonetici.Text = "Yönetici Girişi";
            this.btnyonetici.UseVisualStyleBackColor = false;
            this.btnyonetici.Click += new System.EventHandler(this.btnyonetici_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(374, 148);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnyonetici);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnyonetici;
    }
}

