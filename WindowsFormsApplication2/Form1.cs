using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] harita = new int[6, 6];
        int sutun_sayisi;
        int satir_sayisi;

        private void butonlar(Button mybutton, int xx, int yy)
        {


            int x = harita[xx, yy];
            if (x == 0)
            {

                mybutton.Text = x.ToString();
                mybutton.Enabled = false;
            }

            else if (x == 1)
            {

                mybutton.Text = x.ToString();
                mybutton.Enabled = false;
            }
            else if (x == 2)
            {

                mybutton.Text = x.ToString();
                mybutton.Enabled = false;
            }
            else if (x == 3)
            {
                mybutton.Text = x.ToString();
                mybutton.Enabled = false;
            }

            else if (x >= 100)
            {


                Button[] sifirlanacak_buttonlar = new Button[0];


                    Array.Resize(ref sifirlanacak_buttonlar, 36);
                    for (int i = 0; i < 36; i++)
                    {

                        sifirlanacak_buttonlar[i] = (Button)this.Controls["button" + (i + 1).ToString()];

                    }
                    int siradaki_button = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int k = 0; k < 6; k++)
                        {
                            oyun_bitti(sifirlanacak_buttonlar[siradaki_button], i, k);
                            siradaki_button++;
                        }
                    }
            }
        }

        private void butonlari_sifirla1(Button[] myButton)
        {

            for (int i = 0; i < 36; i++)
            {
                myButton[i].BackgroundImage = null;
                myButton[i].Enabled = true;
                myButton[i].Text = "";
            }


        }

        

       

        private void Form1_Load(object sender, EventArgs e)
        {
            baslangic_ayarlari1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            butonlar(button1, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            butonlar(button2, 0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            butonlar(button3, 0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            butonlar(button4, 0, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            butonlar(button5, 0, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            butonlar(button6, 0, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            butonlar(button7, 1, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            butonlar(button8, 1, 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            butonlar(button9, 1, 2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            butonlar(button10, 1, 3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            butonlar(button11, 1, 4);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            butonlar(button12, 1, 5);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            butonlar(button13, 2, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            butonlar(button14, 2, 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            butonlar(button15, 2, 2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            butonlar(button16, 2, 3);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            butonlar(button17, 2, 4);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            butonlar(button18, 2, 5);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            butonlar(button19, 3, 0);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            butonlar(button20, 3, 1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            butonlar(button21, 3, 2);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            butonlar(button22, 3, 3);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            butonlar(button23, 3, 4);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            butonlar(button24, 3, 5);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            butonlar(button25, 4, 0);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            butonlar(button26, 4, 1);
        }

        private void button27_Click(object sender, EventArgs e)
        {

            butonlar(button27, 4, 2);
        }

        private void button28_Click(object sender, EventArgs e)
        {

            butonlar(button28, 4, 3);
        }

        private void button29_Click(object sender, EventArgs e)
        {

            butonlar(button29, 4, 4);
        }

        private void button30_Click(object sender, EventArgs e)
        {

            butonlar(button30, 4, 5);
        }

        private void button31_Click(object sender, EventArgs e)
        {

            butonlar(button31, 5, 0);
        }

        private void button32_Click(object sender, EventArgs e)
        {

            butonlar(button32, 5, 1);
        }

        private void button33_Click(object sender, EventArgs e)
        {

            butonlar(button33, 5, 2);
        }

        private void button34_Click(object sender, EventArgs e)
        {

            butonlar(button34, 5, 3);
        }

        private void button35_Click(object sender, EventArgs e)
        {

            butonlar(button35, 5, 4);
        }

        private void button36_Click(object sender, EventArgs e)
        {

            butonlar(button36, 5, 5);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            baslangic_ayarlari1();

        }
        private void baslangic_ayarlari1()
        {
            harita = new int[6, 6];

            Random rnd = new Random();


            for (int i = 0; i <=10; i++)
            {
                int x = rnd.Next(0, 6);
                int y = rnd.Next(0, 6);
                harita[x, y] = 100;

            }

            for (int i = 0; i < 6; i++)
            {

                for (int k = 0; k < 6; k++)
                {
                    if (harita[i, k] >= 100)
                    {
                        if (i + 1 < 6)
                        {
                            harita[i + 1, k]++;

                        }
                        if (i - 1 >= 0)
                        {
                            harita[i - 1, k]++;

                        }

                        if (k + 1 < 6)
                        {
                            harita[i, k + 1]++;

                        }

                        if (k - 1 >= 0)
                        {
                            harita[i, k - 1]++;

                        }
                        if ((i - 1 >= 0 && k - 1 >= 0))
                        {
                            harita[i - 1, k - 1]++;
                        }

                        if ((i - 1 >= 0 && k + 1 < 6))
                        {
                            harita[i - 1, k + 1]++;
                        }

                        if ((i + 1 < 6 && k + 1 < 6))
                        {
                            harita[i + 1, k + 1]++;
                        }

                        if ((i + 1 < 6 && k - 1 >= 0))
                        {
                            harita[i + 1, k - 1]++;
                        }





                    }

                }


            }

            Button[] sifirlanacak_buton2 = new Button[0];
            Array.Resize(ref sifirlanacak_buton2, 36);
            for (int i = 0; i < 36; i++)
            {

                sifirlanacak_buton2[i] = (Button)this.Controls["button" + (i + 1).ToString()];

            }


            butonlari_sifirla1(sifirlanacak_buton2);

        }
        private void oyun_bitti(Button myButton, int x, int y)
        {


            myButton.Enabled = false;
            if (harita[x, y] < 100)
            {
                myButton.Text = harita[x, y].ToString();
            }

            if (harita[x, y] >= 100)
            {

                myButton.BackgroundImage = Image.FromFile("cc.ico");
            }

        }

       




    }
}
