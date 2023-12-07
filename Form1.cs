namespace SeviyeliYilanOyunu
{
    public partial class Form1 : Form
    {
        Panel parca;
        List<Panel> yilan = new List<Panel>();
        Panel yem = new Panel();
        string yon = "sað";
        int puan = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            button3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int locX = yilan[0].Location.X;
            int locY = yilan[0].Location.Y;
            if (puan == 1000)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler 1.Seviyeyi Geçtiniz");
                button3.Visible = true;
                button3.Enabled = true;
            }


            YemYendiMi();
            KuyrukTakip();
            CarpismaVarMi();
            if (yon == "sað")
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
            if (yon == "asa")
            {
                if (locY < 580)
                {
                    locY += 20;
                }
                else locY = 0;
            }
            if (yon == "yuk")
            {
                if (locY > 0)
                {
                    locY -= 20;
                }
                else locY = 580;
            }
            yilan[0].Location = new Point(locX, locY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && yon != "sol")
            {
                yon = "sað";
            }
            if (e.KeyCode == Keys.A && yon != "sað")
            {
                yon = "sol";
            }
            if (e.KeyCode == Keys.S && yon != "yuk")
            {
                yon = "asa";
            }
            if (e.KeyCode == Keys.W && yon != "asa")
            {
                yon = "yuk";
            }
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

        }
        void YemEkle()
        {
            Random rnd = new Random();
            int x, y;
            x = rnd.Next(580);
            y = rnd.Next(580);
            x -= x % 20;
            y -= y % 20;
            yem.Location = new Point(x, y);
            yem.Size = new Size(20, 20);
            yem.BackColor = Color.Red;
            panel1.Controls.Add(yem);
        }
        void YemYendiMi()
        {
            label2.Text = "Puan = " + puan;
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
                    MessageBox.Show("Kaybettiniz");

                }
            }
        }


        void YenidenBaslat()
        {
            panel1.Controls.Clear();
            puan = 0;
            yilan.Clear();
        }
    }
}