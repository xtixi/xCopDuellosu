using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;


namespace ÇopDuellosu
{
    public partial class Form1 : Form
    {
        //private SoundPlayer sp;

        public Form1()
        {
            InitializeComponent();
            //player.SoundLocation = "background.wav";
            //sp = new SoundPlayer("bh.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            // System.Media.SoundPlayer gs = new System.Media.SoundPlayer();
            // gs.SoundLocation = "gs.wav";


            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            //5-17 cross
            label1.BackColor = Color.Transparent;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            BackgroundImage = Image.FromFile("AnaMenu.png");
            label1.Visible = false;
            label2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            this.KeyPreview = true;
            //player.Play();

        }



        public int seviye;
        public int seviyetext;
        Random zaman = new Random();
        Random cross = new Random();
        Random cross2 = new Random();
        public int rastgelezaman;
        public int a = 0;
        public bool dusmanhareket = false;
        public int b = 0;
        public bool oldun = false;
        public bool oyuncuvurdu = false;
        public bool oldungoster = false;
        public bool oyuncukazandi = false;
        public bool kazandingoster = false;
        public int crosssure;
        public int crosssecim;
        public int c = 0;
        public int k = 1;
        public int m = 0;
        public bool berabere1 = false;//kendi ölüşü
        public bool berabere2 = false;//düşman ölüşü
        public int aasfasfdasfg;

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("Back.png");
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button7.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label1.Visible = true;
            seviye = 10;
            seviyetext = 1;
            label1.Text = Convert.ToString(seviyetext);
            timer1.Interval = 1000; // bunu değişmeyi unutma
            timer4.Interval = 1000;
            timer3.Interval = 100;
            timer6.Interval = 25;
            if (seviye == 10)
                timer2.Interval = 550;
            else if (seviye == 9)
                timer2.Interval = 500;
            else if (seviye == 8)
                timer2.Interval = 450;
            else if (seviye == 7)
                timer2.Interval = 400;
            else if (seviye == 6)
                timer2.Interval = 350;
            else if (seviye == 5)
                timer2.Interval = 300;
            else if (seviye == 5)
                timer2.Interval = 256;
            else if (seviye == 3)
                timer2.Interval = 200;
            else if (seviye == 2)
                timer2.Interval = 150;
            else if (seviye == 1)
                timer2.Interval = 100;
            timer1.Start();
            timer2.Start();
            //timer3.Start();
            rastgelezaman = zaman.Next(2, 10);
            //sp.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == rastgelezaman)
            {
                dusmanhareket = true;
            }
        }


        //ÖLÜŞ
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (dusmanhareket == true)
            {
                if (b == 0)
                    b++;
                b++;
                if (b == 2)
                    pictureBox3.Image = Image.FromFile("da2.png");
                else if (b == 3)
                    pictureBox3.Image = Image.FromFile("da3.png");
                else if (b == 4)
                {
                    berabere1 = true;
                    pictureBox3.Image = Image.FromFile("da4.png");
                    timer2.Interval = 25;
                    oldun = true;
                }
                else if (b == 5)
                    pictureBox3.Image = Image.FromFile("da5.png");
                else if (b == 6)
                    pictureBox3.Image = Image.FromFile("da6.png");
                else if (b == 7)
                    pictureBox3.Image = Image.FromFile("da7.png");
                else if (b == 8)
                    pictureBox3.Image = Image.FromFile("da8.png");
                else if (b == 9)
                    pictureBox3.Image = Image.FromFile("da9.png");
                else if (b == 10)
                    pictureBox3.Image = Image.FromFile("da10.png");
                else if (b == 11)
                {
                    timer2.Interval = 200;
                    pictureBox2.Image = Image.FromFile("o2.png");
                }
                else if (b == 12)
                    pictureBox2.Image = Image.FromFile("o3.png");
                else if (b == 13)
                    pictureBox2.Image = Image.FromFile("o4.png");
                else if (b == 14)
                    pictureBox2.Image = Image.FromFile("o5.png");
                else if (b == 15)
                    pictureBox2.Image = Image.FromFile("o6.png");
                else if (b == 16)
                    pictureBox2.Image = Image.FromFile("o7.png");
                else if (b == 17)
                    pictureBox2.Image = Image.FromFile("o8.png");
                else if (b == 18)
                    pictureBox2.Image = Image.FromFile("o9.png");
                else if (b == 19)
                    pictureBox2.Image = Image.FromFile("o10.png");
                else if (b == 20)
                    pictureBox2.Image = Image.FromFile("o11.png");
                else if (b == 21)
                {
                    pictureBox2.Image = Image.FromFile("o12.png");
                    oldungoster = true;
                    timer3.Start();
                }



            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {



            if (oldungoster == true || kazandingoster == true)
            {
                if (berabere1 == true && berabere2 == true)
                {
                    timer1.Stop();
                    timer2.Stop();
                    label2.Visible = true;
                    button4.Visible = true;
                    if (oldungoster == true)
                    {
                        label2.Text = "Berabere Bitti ancak öldünüz :(";
                        button4.Text = "Tekrar Oyna";
                    }
                    timer3.Stop();
                }
                else if (oldungoster == true)
                {
                    label2.Text = "Maalesef Kaybettiniz";
                    button4.Text = "Tekrar Oyna";
                }
                else if (kazandingoster == true)
                {
                    if (seviyetext==10)
                    {
                        label2.Text = "Tebrikler! Oyunu bitirdiniz.\n İşte Ödülünüz.\n Oynadığınız için Teşekkürler!";
                        button4.Text = "Tekrar Oyna";
                        Process.Start("https://www.youtube.com/watch?v=mLXQltR7vUQ");
                        seviye = 10;
                        seviyetext = 1;
                        label1.Text = Convert.ToString(seviyetext);
                    }
                    else
                    {
                        label2.Text = "Tebrikler! Seviyeyi Geçtiniz";
                        button4.Text = "Sonraki Seviye";
                        seviye--;
                        seviyetext++;
                        label1.Text = Convert.ToString(seviyetext);
                    }

                }
                timer1.Stop();
                timer2.Stop();
                label2.Visible = true;
                button4.Visible = true;

                timer3.Stop();

            }

        }


        
        //restart
        private void button4_Click(object sender, EventArgs e)
        {
            if (oldungoster == true || kazandingoster == true)
            {
                if (oldungoster == true)
                {
                    seviye = 10;
                    seviyetext = 1;
                    label1.Text = Convert.ToString(seviyetext);
                }
                berabere1 = false;
                berabere2 = false;
                oyuncukazandi = false;
                kazandingoster = false;
                oldungoster = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button7.Visible = false;
                button5.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                label1.Visible = true;
                pictureBox2.Image = Image.FromFile("CowBoyAnaT.png");
                pictureBox3.Image = Image.FromFile("CowBoyEnemy.png");
                BackgroundImage = Image.FromFile("back.png");
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                dusmanhareket = false;
                if (seviye == 10)
                    timer2.Interval = 500;
                else if (seviye == 9)
                    timer2.Interval = 450;
                else if (seviye == 8)
                    timer2.Interval = 400;
                else if (seviye == 7)
                    timer2.Interval = 350;
                else if (seviye == 6)
                    timer2.Interval = 300;
                else if (seviye == 5)
                    timer2.Interval = 250;
                else if (seviye == 4)
                    timer2.Interval = 200;
                else if (seviye == 3)
                    timer2.Interval = 150;
                else if (seviye == 2)
                    timer2.Interval = 100;
                else if (seviye == 1)
                    timer2.Interval = 50;
                label1.Text = Convert.ToString(seviyetext);
                label2.Visible = false;
                button4.Visible = false;
                timer1.Interval = 1000; // bunu değişmeyi unutma
                timer3.Interval = 100;
                timer6.Interval = 25;
                timer1.Start();
                timer6.Start();
                timer2.Start();
                timer4.Stop();
                timer5.Stop();
                b = 0;
                a = 0;
                c = 0;
                k = 0;
                m = 0;
                oldun = false;
                oyuncuvurdu = false;
                oldungoster = false;
                timer3.Start();
                rastgelezaman = zaman.Next(2, 10);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (oyuncuvurdu == true)
            {
                c++;
                if (c == crosssure)
                {
                    if (crosssecim == 1)
                    {
                        pictureBox5.Visible = true;
                    }
                    else if (crosssecim == 2)
                    {
                        pictureBox6.Visible = true;
                    }
                    else if (crosssecim == 3)
                    {
                        pictureBox7.Visible = true;
                    }
                    else if (crosssecim == 4)
                    {
                        pictureBox8.Visible = true;
                    }
                    else if (crosssecim == 5)
                    {
                        pictureBox9.Visible = true;
                    }
                    else if (crosssecim == 6)
                    {
                        pictureBox10.Visible = true;
                    }
                    else if (crosssecim == 7)
                    {
                        pictureBox11.Visible = true;
                    }
                    else if (crosssecim == 8)
                    {
                        pictureBox12.Visible = true;
                    }
                    else if (crosssecim == 9)
                    {
                        pictureBox13.Visible = true;
                    }
                    else if (crosssecim == 10)
                    {
                        pictureBox14.Visible = true;
                    }
                    else if (crosssecim == 11)
                    {
                        pictureBox15.Visible = true;
                    }
                    else if (crosssecim == 12)
                    {
                        pictureBox16.Visible = true;
                    }
                    else if (crosssecim == 13)
                    {
                        pictureBox17.Visible = true;
                    }
                }
                else if (c >= crosssure + (seviye*0.1))
                {
                    if (crosssecim == 1)
                    {
                        pictureBox5.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 2)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 3)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 4)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 5)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 6)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 7)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 8)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 9)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 10)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 11)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 12)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                    else if (crosssecim == 13)
                    {
                        pictureBox6.Visible = false;
                        oldungoster = true;
                        timer5.Start();
                    }
                }
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && dusmanhareket == true && oldun == false)
            {
                timer2.Stop();
                dusmanhareket = false;
                BackgroundImage = Image.FromFile("back2.png"); ;
                crosssure = cross.Next(2, 7);
                crosssecim = cross2.Next(1, 14);
                oyuncuvurdu = true;
                timer4.Start();
            }
            else if (e.KeyCode == Keys.S && dusmanhareket != true && oldun == false && oyuncuvurdu != true)
            {
                timer5.Start();
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }




        //ÖLÜŞ 2
        private void timer5_Tick(object sender, EventArgs e)
        {
            //asd
            k++;
            if (k == 2)
            {
                timer5.Interval = 25;
                pictureBox3.Image = Image.FromFile("da2.png");
            }
            else if (k == 3)
                pictureBox3.Image = Image.FromFile("da3.png");
            else if (k == 4)
            {
                berabere1 = true;
                timer3.Start();
                BackgroundImage = Image.FromFile("back.png");
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                oldun = true;
                pictureBox3.Image = Image.FromFile("da4.png");
            }
            else if (k == 5)
                pictureBox3.Image = Image.FromFile("da5.png");
            else if (k == 6)
                pictureBox3.Image = Image.FromFile("da6.png");
            else if (k == 7)
                pictureBox3.Image = Image.FromFile("da7.png");
            else if (k == 8)
                pictureBox3.Image = Image.FromFile("da8.png");
            else if (k == 9)
                pictureBox3.Image = Image.FromFile("da9.png");
            else if (k == 10)
                pictureBox3.Image = Image.FromFile("da10.png");
            else if (k == 11)
            {
                timer5.Interval = 200;
                pictureBox2.Image = Image.FromFile("o2.png");
            }
            else if (k == 12)
                pictureBox2.Image = Image.FromFile("o3.png");
            else if (k == 13)
                pictureBox2.Image = Image.FromFile("o4.png");
            else if (k == 14)
                pictureBox2.Image = Image.FromFile("o5.png");
            else if (k == 15)
                pictureBox2.Image = Image.FromFile("o6.png");
            else if (k == 16)
                pictureBox2.Image = Image.FromFile("o7.png");
            else if (k == 17)
                pictureBox2.Image = Image.FromFile("o8.png");
            else if (k == 18)
                pictureBox2.Image = Image.FromFile("o9.png");
            else if (k == 19)
                pictureBox2.Image = Image.FromFile("o10.png");
            else if (k == 20)
                pictureBox2.Image = Image.FromFile("o11.png");
            else if (k == 21)
            {
                pictureBox2.Image = Image.FromFile("o12.png");
                oldungoster = true;
            }
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = false;
            oyuncukazandi = true;
            timer6.Start();
        }


        //kazanç
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (oyuncukazandi == true)
            {

                m++;
                timer4.Stop();
                if (m == 1)
                {
                    BackgroundImage = Image.FromFile("back.png");
                    pictureBox2.Image = Image.FromFile("a2.png");
                    berabere2 = true;
                    timer3.Start();
                }

                else if (m == 2)
                    pictureBox2.Image = Image.FromFile("a3.png");
                else if (m == 3)
                    pictureBox2.Image = Image.FromFile("a4.png");
                else if (m == 4)
                    pictureBox2.Image = Image.FromFile("a5.png");
                else if (m == 5)
                    pictureBox2.Image = Image.FromFile("a6.png");
                else if (m == 6)
                    pictureBox2.Image = Image.FromFile("a7.png");
                else if (m == 7)
                    pictureBox2.Image = Image.FromFile("a8.png");
                else if (m == 8)
                    pictureBox2.Image = Image.FromFile("a9.png");
                else if (m == 9)
                {
                    pictureBox2.Image = Image.FromFile("a10.png");
                    timer6.Interval = 200;
                }
                else if (m == 10)
                    pictureBox3.Image = Image.FromFile("do2.png");
                else if (m == 11)
                    pictureBox3.Image = Image.FromFile("do3.png");
                else if (m == 12)
                    pictureBox3.Image = Image.FromFile("do4.png");
                else if (m == 13)
                    pictureBox3.Image = Image.FromFile("do5.png");
                else if (m == 14)
                    pictureBox3.Image = Image.FromFile("do6.png");
                else if (m == 15)
                    pictureBox3.Image = Image.FromFile("do7.png");
                else if (m == 16)
                    pictureBox3.Image = Image.FromFile("do8.png");
                else if (m == 17)
                    pictureBox3.Image = Image.FromFile("do9.png");
                else if (m == 18)
                    pictureBox3.Image = Image.FromFile("do10.png");
                else if (m == 19)
                    pictureBox3.Image = Image.FromFile("do11.png");
                else if (m == 20)
                {
                    m = 0;
                    timer6.Stop();
                    pictureBox3.Image = Image.FromFile("do12.png");
                    kazandingoster = true;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aasfasfdasfg++;
            button6.Text = "Müziği Kapat";
            System.Media.SoundPlayer so = new System.Media.SoundPlayer();

            so.SoundLocation = "bb.wav";
            if (aasfasfdasfg % 2 != 0)
                so.Play();
            else
                so.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berkcan Ciboğlu\nİletişim: berkcan112233@gmail.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun Basit bir duello oyunudur. Oyunda kazanma koşulu rakip elini silaha götürürken S tuşuna basmak ve ardından karşınıza çıkan düşmanın üstünde beliren hedefi belirli bir zamanda vurmaktır. Eğer rakip elini oynatmadan tuşa basarsanız, rakibin üstündeki hedefi belirli zamanda vuramazsanız kaybedersiniz. Oyun 10 seviyeden oluşmaktadır ve her seviyenin zorluk seviyesi artacak şekilde ayarlanmıştır. 10.seviyeyi geçerseniz oyun biter ve küçük ödülünüzü alırsınız. İyi eğlenceler. ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xtixi");
        }
    }
}
