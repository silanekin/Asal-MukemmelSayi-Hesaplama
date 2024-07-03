using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.ShowBalloonTip(2500, "Programa Hoşgeldiniz", "Nesneye Yönelik Programlama Ödevi", ToolTipIcon.Info);
        }
        private bool asalSayiKontrol(int sayi)
        {
            int sayac = 0;
            for (int j = 2; j < sayi; j++)
            {
                if (sayi % j == 0)
                {
                    sayac++;
                    break;
                }
            }
            if (sayac == 0)
                return true;
            else
                return false;
        }
        private bool mukemmelSayiKontrol(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam == sayi)

                return true;
            else
                return false;

        }
        private void BtnHesapla_Click(object sender, EventArgs e)
        {

            int baslangicSayi, bitisSayi, i, asalSayi, ciftSayac = 0, tekSayac = 0, asalSayac = 0, mukemmelSayac = 0;
            double ciftCarpim = 1, tekCarpim = 1, asalCarpim = 1, mukemmelCarpim = 1;
            baslangicSayi = Convert.ToInt32(maskedTextBoxbaslangic.Text);
            bitisSayi = Convert.ToInt32(maskedTextBoxbitis.Text);

            for (i = baslangicSayi; i <= bitisSayi; i++)
            {
                if (i % 2 == 0)
                {
                    listViewcift.Items.Add(Convert.ToString(i));
                    ciftSayac += i;
                    ciftCarpim = ciftCarpim * i;
                }
                else
                {
                    listViewtek.Items.Add(Convert.ToString((int)i));
                    tekSayac += i;
                    tekCarpim = tekCarpim * i;
                }
            }
            listBox2.Items.Add(ciftSayac);
            listBox1.Items.Add(ciftCarpim);
            listBox3.Items.Add(tekSayac);
            listBox4.Items.Add(tekCarpim);

            for ( i = 2; i <= bitisSayi; i++)
            {
                if (asalSayiKontrol(i))
                {
                    listViewasal.Items.Add(i.ToString());
                }
            }

            for ( i = baslangicSayi; i <= bitisSayi; i++)
            {
                if (asalSayiKontrol(i))
                {
                    asalSayac += i;
                    asalCarpim = asalCarpim * i;
                }
            }
            listBox5.Items.Add(asalSayac);
            listBox6.Items.Add(asalCarpim);
            for ( i = baslangicSayi; i <= bitisSayi; i++)
            {
                if (mukemmelSayiKontrol(i))
                {
                    listViewmukemmel.Items.Add(i.ToString());
                }
            }
            for ( i = baslangicSayi; i <= bitisSayi; i++)
            {
                if (mukemmelSayiKontrol(i))
                {
                    mukemmelSayac += i;
                }
            }
            for (i = baslangicSayi; i <= bitisSayi; i++)
            {
                if (mukemmelSayiKontrol(i))
                {
                    mukemmelCarpim *= i;
                }
            }
            listBox7.Items.Add(mukemmelSayac);
            listBox8.Items.Add(mukemmelCarpim);


           maskedTextBoxbaslangic.Clear();
           maskedTextBoxbitis.Clear();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
     }
            
      