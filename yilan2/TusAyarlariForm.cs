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
    public partial class TusAyarlariForm : Form
    {
        public TusAyarlariForm()
        {
            InitializeComponent();
            sesPlayer.Init(ses);
            if (ayarlar.Default.tusKac == 1)
            {
                BackgroundImage = Properties.Resources.tus1;
            }
            else
            {
                BackgroundImage = Properties.Resources.tus2;
            }
        }

        WaveOutEvent sesPlayer = new WaveOutEvent();

        AudioFileReader ses = new AudioFileReader("butonSesi.wav");

        private void wasdButon_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.tus1;
            ayarlar.Default.tusKac = 1;
            ayarlar.Default.yonTuslari = true;
            ayarlar.Default.Save();
        }

        private void okButon_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.tus2;
            ayarlar.Default.tusKac = 2;
            ayarlar.Default.yonTuslari = false;
            ayarlar.Default.Save();
        }

        private void wasdButon_MouseEnter(object sender, EventArgs e)
        {
            if (ayarlar.Default.tusKac == 1)
            {
            }
            else
            {
                BackgroundImage = Properties.Resources.tus3;
            }

            ses.Position = 0;
            if(ayarlar.Default.oyunSesi) sesPlayer.Play();
        }

        private void okButon_MouseEnter(object sender, EventArgs e)
        {
            if (ayarlar.Default.tusKac == 2)
            {
            }
            else
            {
                BackgroundImage = Properties.Resources.tus3;
            }
            ses.Position = 0;
            if (ayarlar.Default.oyunSesi) sesPlayer.Play();
        }

        private void wasdButon_MouseLeave(object sender, EventArgs e)
        {
            if (ayarlar.Default.tusKac == 1)
            {
                BackgroundImage = Properties.Resources.tus1;
            }
            else if (ayarlar.Default.tusKac == 2)
            {
                BackgroundImage = Properties.Resources.tus2;
            }
        }

        private void okButon_MouseLeave(object sender, EventArgs e)
        {
            if (ayarlar.Default.tusKac == 1)
            {
                BackgroundImage = Properties.Resources.tus1;
            }
            else if (ayarlar.Default.tusKac == 2)
            {
                BackgroundImage = Properties.Resources.tus2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
