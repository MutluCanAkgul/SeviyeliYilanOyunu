using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeviyeliYilanOyunu
{

    public partial class Form3 : Form
    {
        Panel parca;
        List<Panel> yilan = new List<Panel>();
        Panel yem = new Panel();
        string yon = "sağ";
        int puan = 0;
        int kalanSure = 100;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && yon != "sol")
            {
                yon = "sağ";
            }
            if (e.KeyCode == Keys.A && yon != "sağ")
            {
                yon = "sol";
            }
            if (e.KeyCode == Keys.W && yon != "asa")
            {
                yon = "yuk";
            }
            if (e.KeyCode == Keys.S && yon != "yuk")
            {
                yon = "asa";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int locX = yilan[0].Location.X;
            int locY = yilan[0].Location.Y;

            YemYendiMi();
            KuyrukTakip();
            CarpismaVarMi();

            if (puan == 2000)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Tebrikler 3.Seviyeyi Geçtiniz");
                button2.Visible = true;
                button2.Enabled = true;
            }
            else if (kalanSure <= 0)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Kaybettiniz Süre Doldu");
            }

            if (yon == "sağ")
            {
                if (locX < 580)
                {
                    locX += 20;
                }
                else locX = 0;
            }
            if (yon == "sol")
            {
                if (locX > 0)
                {
                    locX -= 20;
                }
                else locX = 580;
            }
            if (yon == "yuk")
            {
                if (locY > 0)
                {
                    locY -= 20;
                }
                else locY = 580;
            }
            if (yon == "asa")
            {
                if (locY < 580)
                {
                    locY += 20;
                }
                else locY = 0;
            }
            yilan[0].Location = new Point(locX, locY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YenidenBaslat();
            parca = new Panel();
            parca.Location = new Point(200, 200);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.Black;
            yilan.Add(parca);
            panel1.Controls.Add(parca);
            YemEkle();
            timer1.Enabled = true;
            timer2.Enabled = true;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Visible = false;
        }
        void YemEkle()
        {
            Random rnd = new Random();
            int x, y;
            x = rnd.Next(580);
            y = rnd.Next(580);
            y -= y % 20;
            x -= x % 20;
            yem.Size = new Size(20, 20);
            yem.Location = new Point(x, y);
            yem.BackColor = Color.Red;
            panel1.Controls.Add(yem);

        }
        void YemYendiMi()
        {
            label3.Text = "Puan = " + puan;
            if (yilan[0].Location == yem.Location)
            {
                puan += 50;
                panel1.Controls.Remove(yem);
                YemEkle();
                KuyrukEkle();
            }
        }
        void KuyrukEkle()
        {
            Panel kuyruk = new Panel();
            kuyruk.Size = new Size(20, 20);
            kuyruk.BackColor = Color.DarkCyan;
            yilan.Add(kuyruk);
            panel1.Controls.Add(kuyruk);
        }
        void KuyrukTakip()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }
        void CarpismaVarMi()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    MessageBox.Show("Kaybettiniz");
                }
            }
        }
        void YenidenBaslat()
        {
            panel1.Controls.Clear();
            puan = 0;
            yilan.Clear();
            kalanSure = 100;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            if (kalanSure < 60)
            {
                label2.Text = "Süre = " + (kalanSure % 60);
            }
            else
            {
                label2.Text = "Süre = " + (kalanSure / 60) + ":" + (kalanSure % 60);
            }
        }
    }
}
