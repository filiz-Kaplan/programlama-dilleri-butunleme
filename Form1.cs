using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programlama_dilleri_bütünleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            string kod = kod_blogu.Text;
            derle drl = new derle(kod);
            drl.islem();
            sonuc.Text += " " + drl.islem_sonuc;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kod_blogu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
