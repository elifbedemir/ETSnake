using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETsnake
{
    public partial class AyarlarForm : Form
    {
        public AyarlarForm()
        {
            InitializeComponent();
            butonsesPlayer.Init(butonSes);
        }

        WaveOutEvent butonsesPlayer = new WaveOutEvent();
        AudioFileReader butonSes = new AudioFileReader("butonSesi.wav");

        private void AyarlarForm_Load(object sender, EventArgs e)
        {

        }

        private void yeniButon_MouseEnter(object sender, EventArgs e)
        {
            butonSes.Position = 0;
            if (ayarlar.Default.oyunSesi) butonsesPlayer.Play();
        }



        private void AyarlarForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void yeniButon_Click(object sender, EventArgs e)
        {
            ayarlar.Default.yeniOyun = true;
            ayarlar.Default.Save();
            Close();
        }

        private void devamButon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tusButon_Click(object sender, EventArgs e)
        {
            TusAyarlariForm tus = new TusAyarlariForm();
            tus.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sesButon_Click(object sender, EventArgs e)
        {
            SesAyarlariForm ses = new SesAyarlariForm();
            ses.ShowDialog();
        }

        private void renkButon_Click(object sender, EventArgs e)
        {
            RenkAyarlariForm renk = new RenkAyarlariForm();
            renk.ShowDialog();
        }

        private void hakkindaButon_Click(object sender, EventArgs e)
        {
            HakkindaForm hakkinda = new HakkindaForm();
            hakkinda.ShowDialog();
        }
    }
}
