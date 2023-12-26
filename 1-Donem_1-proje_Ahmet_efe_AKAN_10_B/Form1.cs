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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void labelyuzde_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonBitir_Click(object sender, EventArgs e)
        {
            int dogrusayisi, yanlissayisi, basariorani;//değişkenleri "int"veri tipi ile oluşturdum
            dogrusayisi = 0;
            yanlissayisi = 0;
            basariorani = 0;//hepsini başlangıçta sıfırladım

            if (radioButton4.Checked == true )//soru 1 için if ve else komutları 
           
            {
                dogrusayisi = dogrusayisi + 1;//doğru sayısını arttırıyor
            }
            else
            {
                yanlissayisi= yanlissayisi + 1;//yanlış sayısını arttırıyor
            }
            
            if (radioButton7.Checked == true)//soru 2 için if ve else komutları
            {
                dogrusayisi = dogrusayisi + 1;
            }
            else
            {
                yanlissayisi = yanlissayisi + 1;
            }

            if (radioButton10.Checked == true)//soru 3 için if ve else komutları
            {
                dogrusayisi = dogrusayisi + 1;
            }
            else
            {
                yanlissayisi = yanlissayisi + 1;
            }

            if (radioButton13.Checked == true)//soru 4 için if ve else komutları
            {
                dogrusayisi = dogrusayisi + 1;
            }
            else
            {
                yanlissayisi = yanlissayisi + 1;
            }

            if (radioButton19.Checked == true)//soru 5 için if ve else komutları
            {
                dogrusayisi = dogrusayisi + 1;
            }
            else
            {
                yanlissayisi = yanlissayisi + 1;
            }



            //textbox'ların enabled özelliğini değiştirmeden sadece "readonly"i true yaparak textbox'un görünüşünün saydam olmasını engelledim.



            textboxDogru.Text = (dogrusayisi).ToString();//doğru sayısını textbox'a yazdırdım
            textBoxYanlis.Text = (yanlissayisi).ToString();//yanlış sayısını textbox'a yazdırdım
            basariorani = dogrusayisi * 20;//başarı oranını atadım aslında değişkene gerek yoktu
            //textBoxBasariOrani.Text=dogrusayisi * 20  şeklinde yazabilirdim
            //ram'i baya yemiş olduk boşu boşuna
            //değişkenleri kullanarak yazdırmak istedim
            textBoxBasariOrani.Text=basariorani.ToString();//başarı oranını yazdırdım
        }

        private void GroupboxSonuclar_Enter(object sender, EventArgs e)
        {

        }
    }
}
