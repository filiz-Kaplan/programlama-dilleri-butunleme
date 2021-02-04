namespace programlama_dilleri_bütünleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Label();
            this.kod_blogu = new System.Windows.Forms.RichTextBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KOD";
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Location = new System.Drawing.Point(34, 328);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(45, 13);
            this.sonuc.TabIndex = 1;
            this.sonuc.Text = "SONUÇ";
            // 
            // kod_blogu
            // 
            this.kod_blogu.Location = new System.Drawing.Point(27, 83);
            this.kod_blogu.Name = "kod_blogu";
            this.kod_blogu.Size = new System.Drawing.Size(569, 228);
            this.kod_blogu.TabIndex = 2;
            this.kod_blogu.Text = "";
            this.kod_blogu.TextChanged += new System.EventHandler(this.kod_blogu_TextChanged);
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(487, 348);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(187, 54);
            this.hesapla.TabIndex = 3;
            this.hesapla.Text = "YÜRÜT";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 44);
            this.label2.MinimumSize = new System.Drawing.Size(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KODU ÇALIŞTIRABİLMEK İÇİN \"hesapla->\" SÖZCÜĞÜNÜ DURMASI İÇİN \"son\" SÖZCÜĞÜNÜ YAZM" +
    "ANIZ GEREKMEKTEDİR!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.kod_blogu);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.RichTextBox kod_blogu;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label label2;
    }
}

