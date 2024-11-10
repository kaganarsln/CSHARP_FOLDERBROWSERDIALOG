namespace FOLDERBROWSERDİALOG1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.olustur = new System.Windows.Forms.Button();
            this.yolsec = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ileri = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resmigoster = new System.Windows.Forms.Button();
            this.klasorsec = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.olustur);
            this.groupBox1.Controls.Add(this.yolsec);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(58, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BELGE OLUŞTURMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dosya Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dosya Adı:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(628, 119);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 20);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "pptx";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(628, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "xlsx";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(628, 61);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "docx";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // olustur
            // 
            this.olustur.Location = new System.Drawing.Point(466, 118);
            this.olustur.Name = "olustur";
            this.olustur.Size = new System.Drawing.Size(127, 38);
            this.olustur.TabIndex = 3;
            this.olustur.Text = "OLUŞTUR";
            this.olustur.UseVisualStyleBackColor = true;
            this.olustur.Click += new System.EventHandler(this.olustur_Click);
            // 
            // yolsec
            // 
            this.yolsec.Location = new System.Drawing.Point(466, 51);
            this.yolsec.Name = "yolsec";
            this.yolsec.Size = new System.Drawing.Size(127, 40);
            this.yolsec.TabIndex = 2;
            this.yolsec.Text = "YOLU SEÇ";
            this.yolsec.UseVisualStyleBackColor = true;
            this.yolsec.Click += new System.EventHandler(this.yolsec_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 118);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 38);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 40);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ileri);
            this.groupBox2.Controls.Add(this.geri);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.resmigoster);
            this.groupBox2.Controls.Add(this.klasorsec);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(58, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(825, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KLASÖR İÇERİK LİSTELEME";
            // 
            // ileri
            // 
            this.ileri.Location = new System.Drawing.Point(718, 106);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(69, 55);
            this.ileri.TabIndex = 6;
            this.ileri.Text = ">";
            this.ileri.UseVisualStyleBackColor = true;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(418, 106);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 55);
            this.geri.TabIndex = 5;
            this.geri.Text = "<";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(499, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "YOL:";
            // 
            // resmigoster
            // 
            this.resmigoster.Location = new System.Drawing.Point(205, 203);
            this.resmigoster.Name = "resmigoster";
            this.resmigoster.Size = new System.Drawing.Size(159, 23);
            this.resmigoster.TabIndex = 2;
            this.resmigoster.Text = "RESMİ GÖSTER";
            this.resmigoster.UseVisualStyleBackColor = true;
            this.resmigoster.Click += new System.EventHandler(this.resmigoster_Click);
            // 
            // klasorsec
            // 
            this.klasorsec.Location = new System.Drawing.Point(27, 203);
            this.klasorsec.Name = "klasorsec";
            this.klasorsec.Size = new System.Drawing.Size(144, 23);
            this.klasorsec.TabIndex = 1;
            this.klasorsec.Text = "KLASÖR SEÇ";
            this.klasorsec.UseVisualStyleBackColor = true;
            this.klasorsec.Click += new System.EventHandler(this.klasorsec_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 164);
            this.listBox1.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(150, 150);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(898, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button olustur;
        private System.Windows.Forms.Button yolsec;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resmigoster;
        private System.Windows.Forms.Button klasorsec;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

