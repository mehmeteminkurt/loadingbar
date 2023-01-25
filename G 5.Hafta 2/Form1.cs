using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //Thread.sleep komutunu kullanmak için //

namespace G_5.Hafta_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            for (int i = 0; i <= 50; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(100); // Bu komut milisaniye cinsinden kodu yavaşlatır
            }
            Thread.Sleep(100);
            label1.Text = "İşlem tamamlandı";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
