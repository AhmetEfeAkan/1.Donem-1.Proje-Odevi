using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace _1_Donem_1_proje_Ahmet_efe_AKAN_10_B
{
    public partial class Form4_Magaza_İndirim : Form
    {
        public Form4_Magaza_İndirim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fiyat,İndirimliFiyat,İndirimOrani;
            fiyat = Convert.ToSingle(textBox1.Text);
            
            
            if (fiyat >= 300)
            {
                
                İndirimOrani= fiyat * 20 / 100;
                İndirimliFiyat = fiyat - İndirimOrani;
                indirimsiztext.Text = fiyat.ToString()+" TL";
                indirimlitext.Text =  İndirimliFiyat.ToString()+" TL";
                orantext.Text = "%20  -" + İndirimOrani.ToString()+"TL";
            }
            else if (fiyat >= 200)
            {

                İndirimOrani = fiyat * 15 / 100;
                İndirimliFiyat = fiyat - İndirimOrani;
                indirimsiztext.Text = fiyat.ToString() + " TL";
                indirimlitext.Text = İndirimliFiyat.ToString() + " TL";
                orantext.Text = "%15  -" + İndirimOrani.ToString() + "TL";
            }
            else if (fiyat >= 100)
            {

                İndirimOrani = fiyat * 10 / 100;
                İndirimliFiyat = fiyat - İndirimOrani;
                indirimsiztext.Text = fiyat.ToString() + " TL";
                indirimlitext.Text = İndirimliFiyat.ToString() + " TL";
                orantext.Text = "%10  -" + İndirimOrani.ToString() + "TL";
            }
            else if (fiyat < 100)
            {

                
                
                indirimsiztext.Text = fiyat.ToString() + " TL";
                indirimlitext.Text = fiyat.ToString()+" TL";
                orantext.Text = "%0  -0TL";
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Magaza_İndirim_Load(object sender, EventArgs e)
        {

        }

        


















        //Bu form çalıştığı zaman üzerisindeki form border olmadan sürüklemeyi yapabilmek için araştırdım.
        //istersem form border'i <none> yapmayabilirdim ama grafiksel açıdan bir mağaza yapmak istediğim için bu yolu tercih ettim.
        //Opera yada MS Virsual Studio'da olduğu gibi bir border yapmak istedim.

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
