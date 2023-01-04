using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _250822Win_HataTurleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //çalışma zamanı hatalarını tespit edip yakalamak için try catch yapısı kullanılır.
            string sayi1 = textBox1.Text;
            string sayi2 = textBox2.Text;
            try
            {
                int s1 = Convert.ToInt32(sayi1);
                int s2 = Convert.ToInt32(sayi2);
                int toplam = s1 + s2;
                textBox3.Text = toplam.ToString();
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message+"Sayi Girmelisiniz.");
            }
         catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message+ "Daha küçük bir sayi girmelisiniz.");
            }
            finally
            {
//try içindeki komutlar hata versede finally bloğu her zaman çalışır.örn:bağlantı kapatılması
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mantıksal hataları breakpoint ile çözersin f10 ile bir sonraki adım,metot içine f11 ile girersin.
            int toplam = 0;
            for (int i=1; i<=100; i++)
            {
                toplam+=i;
            }
            MessageBox.Show(toplam.ToString());
        }
        
    }
}
