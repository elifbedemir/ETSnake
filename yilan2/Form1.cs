using NAudio.Wave;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ETsnake.metot;

namespace ETsnake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            elmaSes.Init(elmaSesi);
            baslaSes.Init(oyunBaslaSes);
            bitisSes.Init(oyunSonuSes);
            arkaplanSes.Init(arkaPlanSesi);
            DoubleBuffered = true;
        }

        WaveOutEvent baslaSes = new WaveOutEvent();
        WaveOutEvent bitisSes = new WaveOutEvent();
        WaveOutEvent elmaSes = new WaveOutEvent();
        WaveOutEvent arkaplanSes = new WaveOutEvent();

        AudioFileReader oyunBaslaSes = new AudioFileReader("oyunBaslaSes.wav");
        AudioFileReader oyunSonuSes = new AudioFileReader("oyunSonuSes.wav");
        AudioFileReader elmaSesi = new AudioFileReader("elmaSes.wav");
        AudioFileReader arkaPlanSesi = new AudioFileReader("arkaplan.wav");

        PictureBox parca;
        PictureBox elma = new PictureBox();
        List<PictureBox> yilan = new List<PictureBox>();

        bool basladiMi = false;
        string yon = "sað";
        int hiz = 100;
        int puan = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = hiz;
            puanLabel.Text = puan.ToString();

            arkaplanSes.Volume = ayarlar.Default.muzikSesi;
            arkaplanSes.PlaybackStopped += ArkaplanSes_PlaybackStopped;

            elmaYedimi();
            hareket();
            carptiMi();
            yonler();
        }

        private void ArkaplanSes_PlaybackStopped(object? sender, StoppedEventArgs e)
        {
            arkaPlanSesi.Position = 0;
            arkaplanSes.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunAlani.BackColor = ayarlar.Default.arkaPlanRenk;
            rekorLabel.Text = ayarlar.Default.rekor.ToString();
        }

        void elmaOlustur()
        {
        yeniden:
            Random random = new Random();
            int x, y;

            x = random.Next(580);
            y = random.Next(580);

            x -= x % 20;
            y -= y % 20;

            elma.Size = new Size(20, 20);
            elma.Location = new Point(x, y);
            elma.Paint += paint.Elma_Paint;

            for (int i = 0; i < yilan.Count; i++)
            {
                if (elma.Location == yilan[i].Location)
                {
                    goto yeniden;
                }
            }

            oyunAlani.Controls.Add(elma);
        }

        void hareket()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }

        void yonler()
        {
            int x = yilan[0].Location.X;
            int y = yilan[0].Location.Y;

            if (yon == "sað")
            {
                if (x < 580)
                {
                    x += 20;
                }
                else if (x == 580)
                {
                    x = 0;
                }
            }

            else if (yon == "sol")
            {
                if (x > 0)
                {
                    x -= 20;
                }
                else if (x == 0)
                {
                    x = 580;
                }
            }

            else if (yon == "yukarý")
            {
                if (y > 0)
                {
                    y -= 20;
                }
                else if (y == 0)
                {
                    y = 580;
                }
            }

            else if (yon == "aþaðý")
            {
                if (y < 580)
                {
                    y += 20;
                }
                else if (y == 580)
                {
                    y = 0;
                }
            }

            yilan[0].Location = new Point(x, y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ayarlarToolStripMenuItem.PerformClick();
            }

            if (ayarlar.Default.yonTuslari && e.KeyCode != Keys.Escape)
            {
                if (e.KeyCode == Keys.W && yon != "aþaðý")
                {
                    yon = "yukarý";
                }

                else if (e.KeyCode == Keys.A && yon != "sað")
                {
                    yon = "sol";
                }

                else if (e.KeyCode == Keys.D && yon != "sol")
                {
                    yon = "sað";
                }

                else if (e.KeyCode == Keys.S && yon != "yukarý")
                {
                    yon = "aþaðý";
                }
            }
            else
            {
                if (e.KeyCode == Keys.Up && yon != "aþaðý")
                {
                    yon = "yukarý";
                }

                else if (e.KeyCode == Keys.Left && yon != "sað")
                {
                    yon = "sol";
                }

                else if (e.KeyCode == Keys.Right && yon != "sol")
                {
                    yon = "sað";
                }

                else if (e.KeyCode == Keys.Down && yon != "yukarý")
                {
                    yon = "aþaðý";
                }
            }
        }

        void elmaYedimi()
        {
            if (yilan[0].Location == elma.Location)
            {
                elmaSesi.Position = 0;
                if (ayarlar.Default.oyunSesi) elmaSes.Play();

                oyunAlani.Controls.Remove(elma);
                elmaOlustur();
                parcaEkle();
                puan++;
            }

        }

        void parcaEkle()
        {
            parca = new PictureBox();
            parca.Size = new Size(20, 20);
            parca.Paint += paint.Parca_Paint;
            yilan.Add(parca);

            oyunAlani.Controls.Add(parca);
        }

        void carptiMi()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    oyunSonu();
                }
            }
        }

        void oyunSonu()
        {
            basladiMi = false;
            oyunSonuSes.Position = 0;
            if (ayarlar.Default.oyunSesi) bitisSes.Play();

            timer1.Stop();
            MessageBox.Show("Çarptýnýz..\n" + "Puanýnýz : " + puan);

            if (puan > ayarlar.Default.rekor)
            {
                rekorKaydet();
            }
        }

        void rekorKaydet()
        {
            ayarlar.Default.rekor = puan;
            rekorLabel.Text = ayarlar.Default.rekor.ToString();
            ayarlar.Default.Save();
        }

        private void Ayarlar_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();

            oyunAlani.BackColor = ayarlar.Default.arkaPlanRenk;

            if (basladiMi)
            {
                if (ayarlar.Default.yeniOyun)
                {
                    yeniOyunToolStripMenuItem.PerformClick();
                    ayarlar.Default.yeniOyun = false;
                    ayarlar.Default.Save();
                }
                else
                {
                    timer1.Start();
                }
            }

            else if (ayarlar.Default.yeniOyun)
            {
                yeniOyunToolStripMenuItem.PerformClick();
                ayarlar.Default.yeniOyun = false;
                ayarlar.Default.Save();
            }
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basladiMi = true;

            oyunBaslaSes.Position = 0;
            if (ayarlar.Default.oyunSesi) baslaSes.Play();

            arkaPlanSesi.Position = 0;
            arkaplanSes.Volume = ayarlar.Default.muzikSesi;
            arkaplanSes.Play();

            oyunAlani.Controls.Clear();
            yilan.Clear();
            yon = "sað";
            puan = 0;

            elmaOlustur();

            parca = new PictureBox();
            parca.Size = new Size(20, 20);
            parca.Location = new Point(40, 240);
            parca.Paint += paint.Yilan_Paint;


            yilan.Add(parca);

            oyunAlani.Controls.Add(yilan[0]);

            timer1.Start();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyarlarForm ayarlar = new AyarlarForm();
            ayarlar.Show(this);
            timer1.Stop();
            ayarlar.FormClosed += Ayarlar_FormClosed;
            this.Hide();
        }
    }
}
