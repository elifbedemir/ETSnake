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
    public partial class SesAyarlariForm : Form
    {
        public SesAyarlariForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SesAyarlariForm_Load(object sender, EventArgs e)
        {
            myTrackBar1.Value = Convert.ToInt32(ayarlar.Default.muzikSesi * 100);
            trackbar_label.Text = myTrackBar1.Value.ToString();

            if (ayarlar.Default.oyunSesi)
            {
                BackgroundImage = Properties.Resources.ses1;
            }
            else
            {
                BackgroundImage = Properties.Resources.ses2;
            }
        }

        private void oyunSesButon_Click(object sender, EventArgs e)
        {
            if (ayarlar.Default.oyunSesi)
            {
                BackgroundImage = Properties.Resources.ses2;
                ayarlar.Default.oyunSesi = false;
                ayarlar.Default.Save();
            }
            else
            {
                BackgroundImage = Properties.Resources.ses1;
                ayarlar.Default.oyunSesi = true;
                ayarlar.Default.Save();
            }
        }

        private void myTrackBar1_Scroll(object sender, EventArgs e)
        {
            float deger = myTrackBar1.Value;
            ayarlar.Default.muzikSesi = deger / 100;
            ayarlar.Default.Save();
            trackbar_label.Text = "%" + myTrackBar1.Value.ToString();
        }
    }
}
