using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Donem_1_proje_Ahmet_efe_AKAN_10_B
{
    public partial class Form5_Form_Secim_Ekrani : Form
    {
        public Form5_Form_Secim_Ekrani()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Ekranda Programlar Arasında Hızlı Bir Geçiş Yapabilirsiniz.\nAhmet Efe Akan 2022","Hakkında",MessageBoxButtons.OK);
        }

        private void hakkındaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Ekranda Programlar Arasında Hızlı Bir Geçiş Yapabilirsiniz.\nAhmet Efe Akan 2022", "Hakkında", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2_Firinci form2 = new Form2_Firinci();

            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3_Cift_Tek form3 = new Form3_Cift_Tek();

            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4_Magaza_İndirim form4 = new Form4_Magaza_İndirim();

            form4.Show();
        }
    }
}
