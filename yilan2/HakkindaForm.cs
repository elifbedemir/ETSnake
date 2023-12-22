using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETsnake
{
    public partial class HakkindaForm : Form
    {
        Random rnd = new Random();
        string[] names = { "Tolgahan KANAT", "Elif DEMİR" };
        int yaziHizi = 5;
        int currentIndex = 0;

        public HakkindaForm()
        {
            InitializeComponent();
            timer1.Start();
            DoubleBuffered = true;
        }

        string uygulamaVersiyon = "1.0";
        string uygulamaWebVersiyon = WebVersion("https://jakef.com.tr/snake/version.txt");
        string setupUrl = "https://jakef.com.tr/snake/setup.exe";

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (guncellemeVarmi(uygulamaVersiyon, uygulamaWebVersiyon))
            {
                DialogResult dlg = MessageBox.Show("Güncelleme Bulundu\nindirilsin mi ?", "Güncelleme", MessageBoxButtons.OKCancel);
                if (dlg == DialogResult.OK)
                {
                    GuncellemeIndir();
                }
            }
            else
            {
                MessageBox.Show("Uygulama Güncel");
            }
        }

        private void GuncellemeIndir()
        {
            try
            {
                Process.Start(new ProcessStartInfo(setupUrl) { UseShellExecute = true});
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_isimler.ForeColor = Color.Red;
            lbl_isimler.Text = names[currentIndex];
            int x = lbl_isimler.Location.X;
            int y = lbl_isimler.Location.Y;

            y -= yaziHizi;

            lbl_isimler.Location = new Point(x, y);

            if (lbl_isimler.Location.Y < panel1.Location.Y)
            {
                lbl_isimler.Location = new Point(lbl_isimler.Location.X, panel2.Location.Y);
                currentIndex++;
                if (currentIndex >= names.Length)
                {
                    currentIndex = 0;
                }
            }
        }

        static string WebVersion(string url)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    return client.DownloadString(url).Trim();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sürüm Kontrolü Yapılamadı: " + ex.Message);
                    return string.Empty;
                }
            }
        }

        static bool guncellemeVarmi(string uygulamaV, string webV)
        {
            Version uygulama = new Version(uygulamaV);
            Version web = new Version(webV);

            return web > uygulama;
        }
    }
}
