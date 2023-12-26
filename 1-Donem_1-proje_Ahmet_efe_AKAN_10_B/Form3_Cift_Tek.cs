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
    public partial class Form3_Cift_Tek : Form
    {
        public Form3_Cift_Tek()
        {
            InitializeComponent();
        }
        int cevap,sayi;
        bool değer;
        private void button1_Click(object sender, EventArgs e)
        {
           sayi=Convert.ToInt32(textBox1.Text);
            if(sayi%2==0)
            {
                değer = true;
                
            }
            else 
            {
                değer = false;
            }
            if (değer==true)
            {
               cevap= sayi / 2 ;
            }
            else if (değer==false)
            {
                cevap = sayi * 2;
            }
            label3.Text= "Sonuç: "+cevap.ToString();
        }
    }
}
