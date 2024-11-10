using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOLDERBROWSERDİALOG1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaAd, dosyaYol, dosyaFormat;
       

        private void klasorsec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Bir Klasör Seçiniz.";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string seciliklasor = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dizinbilgi = new DirectoryInfo(seciliklasor);
                FileSystemInfo[] dosyabilgi = dizinbilgi.GetFileSystemInfos();

                foreach (FileSystemInfo dosya in dosyabilgi)
                {
                    if (dosya is DirectoryInfo)
                    {
                        listBox1.Items.Add("Klasör: " + dosya.Name);

                    }
                    else if (dosya is FileInfo)
                    {
                        listBox1.Items.Add("Dosya: " + dosya.Name);

                    }
                }
                label3.Text = seciliklasor;
                dosyaYol = seciliklasor;

                
            }

        }

        private void resmigoster_Click(object sender, EventArgs e)
        {
            string[] dosyaresim = Directory.GetFiles(dosyaYol, "*.jpg");
            foreach(string dosya in dosyaresim) 
            {
                Image resim = Image.FromFile(dosya);
                ımageList1.Images.Add(resim);
            }
            if (ımageList1.Images.Count > 0) 
            {
                pictureBox1.Image = ımageList1.Images[0];
            }
        }
        int gecis = 0;
        private void geri_Click(object sender, EventArgs e)
        {
            gecis--;
            if (gecis < 0) 
            {
                gecis = ımageList1.Images.Count - 1;
            }
            pictureBox1.Image = ımageList1.Images[gecis];
            
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            gecis++;
            if(gecis == ımageList1.Images.Count) 
            {
                gecis = 0;
            }
            pictureBox1.Image = ımageList1.Images[gecis];
        }

        private void olustur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)) 
            {
                dosyaAd = textBox2.Text;

                if (radioButton1.Checked) 
                {
                    dosyaFormat = ".docx";
                }
                else if (radioButton2.Checked) 
                {
                    dosyaFormat = ".xlsx";
                }
                else if (radioButton3.Checked) 
                {
                    dosyaFormat = ".pptx";
                }
                if (!string.IsNullOrEmpty(dosyaFormat)) 
                {
                    StreamWriter sw = File.CreateText(dosyaYol + "\\" + dosyaAd + dosyaFormat);
                    sw.Close();
                    MessageBox.Show("Dosyanız Başarıyla Oluşturuldu!", "Bilgilendirme Satırıdır.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else 
                {
                    MessageBox.Show("Bir Yol Seçmelisiniz!");
                }
            }
        }

        private void yolsec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) 
            {
                dosyaYol = folderBrowserDialog1.SelectedPath;
                textBox1.Text = dosyaYol;
            }
        }
    }
}
