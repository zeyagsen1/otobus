namespace otogar
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnkullaniciduzenle = new System.Windows.Forms.Button();
            this.txtparolaekle = new System.Windows.Forms.TextBox();
            this.txtkullaniciadiekle = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkullaniciduzenle
            // 
            this.btnkullaniciduzenle.BackColor = System.Drawing.Color.Silver;
            this.btnkullaniciduzenle.FlatAppearance.BorderSize = 0;
            this.btnkullaniciduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkullaniciduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkullaniciduzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnkullaniciduzenle.Image")));
            this.btnkullaniciduzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkullaniciduzenle.Location = new System.Drawing.Point(10, 78);
            this.btnkullaniciduzenle.Name = "btnkullaniciduzenle";
            this.btnkullaniciduzenle.Size = new System.Drawing.Size(208, 40);
            this.btnkullaniciduzenle.TabIndex = 56;
            this.btnkullaniciduzenle.Text = "Parola Değiştir";
            this.btnkullaniciduzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkullaniciduzenle.UseVisualStyleBackColor = false;
            this.btnkullaniciduzenle.Click += new System.EventHandler(this.btnkullaniciduzenle_Click);
            // 
            // txtparolaekle
            // 
            this.txtparolaekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparolaekle.Location = new System.Drawing.Point(43, 47);
            this.txtparolaekle.Multiline = true;
            this.txtparolaekle.Name = "txtparolaekle";
            this.txtparolaekle.Size = new System.Drawing.Size(175, 25);
            this.txtparolaekle.TabIndex = 55;
            this.txtparolaekle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtparolaekle.TextChanged += new System.EventHandler(this.txtparolaekle_TextChanged);
            // 
            // txtkullaniciadiekle
            // 
            this.txtkullaniciadiekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadiekle.Location = new System.Drawing.Point(43, 12);
            this.txtkullaniciadiekle.Multiline = true;
            this.txtkullaniciadiekle.Name = "txtkullaniciadiekle";
            this.txtkullaniciadiekle.Size = new System.Drawing.Size(175, 25);
            this.txtkullaniciadiekle.TabIndex = 54;
            this.txtkullaniciadiekle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtkullaniciadiekle.TextChanged += new System.EventHandler(this.txtkullaniciadiekle_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 29);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(228, 129);
            this.Controls.Add(this.btnkullaniciduzenle);
            this.Controls.Add(this.txtparolaekle);
            this.Controls.Add(this.txtkullaniciadiekle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkullaniciduzenle;
        public System.Windows.Forms.TextBox txtparolaekle;
        public System.Windows.Forms.TextBox txtkullaniciadiekle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}