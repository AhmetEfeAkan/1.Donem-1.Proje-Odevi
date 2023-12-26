using System;
using System.Windows.Forms;

namespace _1_Donem_1_proje_Ahmet_efe_AKAN_10_B
{
    public partial class Form2_Firinci : Form
    {
        public Form2_Firinci()
        {
            InitializeComponent();
        }

        private void Form2_Firinci_Load(object sender, EventArgs e)
        {

        }
        double simitsayisi, ekmeksayisi, pogacasayisi, toplamÜcret,vergiÜcret;
        double simitÜcret, pogacaÜcret, ekmekÜcret;

        private void button1_Click(object sender, EventArgs e)
        {
            ekmeksayisi = Convert.ToDouble(textBox1.Text);
            pogacasayisi = Convert.ToDouble(textBox2.Text);
            simitsayisi = Convert.ToDouble(textBox3.Text);
            simitÜcret= 5 * simitsayisi;
            pogacaÜcret = 4 * pogacasayisi;
            ekmekÜcret=3.75 * ekmeksayisi;
            toplamÜcret = ekmekÜcret + pogacaÜcret + simitÜcret;
            vergiÜcret = toplamÜcret /100*18;

            richTextBox1.Text = "Fırıncı Hesaplama Otomasyonu Çıkış Ekranı\n\nÜrün Girişleri;\n" + ekmeksayisi + " adet ekmek   x    3,75 TL    = " + ekmekÜcret + "\n";
            richTextBox1.Text += pogacasayisi + " adet poğaça   x    4,00 TL    = " + pogacaÜcret + "\n";
            richTextBox1.Text += simitsayisi + " adet simit   x    5,00 TL    = " +simitÜcret + "\n\n";
            richTextBox1.Text += "Hesaplanan;\n" + toplamÜcret + " TL     Satıştan Elde Edilen Ücret\n" + vergiÜcret + " TL     Vergi Ödemeniz (tüm ürünlerin toplamının %18'i üzerinden hesaplandı)\n";
            richTextBox1.Text += " __\n";
            richTextBox1.Text += "____________________________________\n";
            richTextBox1.Text += toplamÜcret-vergiÜcret + " TL Kazancınız Bulunmaktadır.";

            //bu kodları yazarken bayağı bir debug işlemi yapmam gerekti,Nedeni Makinem eski olduğu için(sanırım)mantıksız hatalar veriyordu. Makineme bazı dll ler ekledim.//DLL'lerin güvenli olduğunu kontrol ettim.
            //Debug işlemi Projemin 1-2 gün daha uzamasına sebep oldu

            //son düzenlenme tarihi:  2.11.2022 20.00 UTC-3 İstanbul/Türkiye Avrupa
        }
    }
}
