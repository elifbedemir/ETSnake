using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ETsnake
{
    public partial class RenkAyarlariForm : Form
    {
        public RenkAyarlariForm()
        {
            InitializeComponent();
            Liste2();
            Liste3();
            Liste4();

        }

        private void RenkAyarlariForm_Load(object sender, EventArgs e)
        {
            lbl_arkaplanrenk.BackColor = ayarlar.Default.arkaPlanRenk;

            listView2.BackColor = Color.FromArgb(23, 92, 48);
            listView3.BackColor = Color.FromArgb(23, 92, 48);
            listView4.BackColor = Color.FromArgb(23, 92, 48);
        }

        public void Liste2()
        {
            Bitmap[] bitmaps = new Bitmap[]
            {
                Properties.Resources.parca1,
                Properties.Resources.parca2,
                Properties.Resources.parca3,
                Properties.Resources.parca4,
                Properties.Resources.parca5,
                Properties.Resources.parca6,
                Properties.Resources.parca7,
                Properties.Resources.parca8,
                Properties.Resources.parca9,
                Properties.Resources.parca10,
                Properties.Resources.parca11,
                Properties.Resources.parca12,
                Properties.Resources.parca13,
                Properties.Resources.parca14,
            };

            ImageList imageList = new ImageList();

            foreach (Bitmap bitmap in bitmaps)
            {
                imageList.Images.Add(bitmap);
            }

            listView2.LargeImageList = imageList;
            listView2.LargeImageList.ImageSize = new Size(40, 40);
            //imageList.ImageSize = new Size(20, 20);

            for (int i = 0; i < bitmaps.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                listView2.Items.Add(item);
            }
        }

        public void Liste3()
        {
            Bitmap[] bitmaps = new Bitmap[]
            {
                Properties.Resources.parca1,
                Properties.Resources.parca2,
                Properties.Resources.parca3,
                Properties.Resources.parca4,
                Properties.Resources.parca5,
                Properties.Resources.parca6,
                Properties.Resources.parca7,
                Properties.Resources.parca8,
                Properties.Resources.parca9,
                Properties.Resources.parca10,
                Properties.Resources.parca11,
                Properties.Resources.parca12,
                Properties.Resources.parca13,
                Properties.Resources.parca14,
            };

            ImageList imageList = new ImageList();

            foreach (Bitmap bitmap in bitmaps)
            {
                imageList.Images.Add(bitmap);
            }

            listView3.LargeImageList = imageList;
            listView3.LargeImageList.ImageSize = new Size(40, 40);
            //imageList.ImageSize = new Size(20, 20);

            for (int i = 0; i < bitmaps.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                listView3.Items.Add(item);
            }
        }

        public void Liste4()
        {
            Bitmap[] bitmaps = new Bitmap[]
            {
                Properties.Resources.parca1,
                Properties.Resources.parca2,
                Properties.Resources.parca3,
                Properties.Resources.parca4,
                Properties.Resources.parca5,
                Properties.Resources.parca6,
                Properties.Resources.parca7,
                Properties.Resources.parca8,
                Properties.Resources.parca9,
                Properties.Resources.parca10,
                Properties.Resources.parca11,
                Properties.Resources.parca12,
                Properties.Resources.parca13,
                Properties.Resources.parca14,
            };

            ImageList imageList = new ImageList();

            foreach (Bitmap bitmap in bitmaps)
            {
                imageList.Images.Add(bitmap);
            }

            listView4.LargeImageList = imageList;
            listView4.LargeImageList.ImageSize = new Size(40, 40);
            //imageList.ImageSize = new Size(20, 20);

            for (int i = 0; i < bitmaps.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                listView4.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_arkaplanrenk_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.FullOpen = true;
            DialogResult dlg = color.ShowDialog();

            if (dlg == DialogResult.OK)
            {
                lbl_arkaplanrenk.BackColor = color.Color;
                ayarlar.Default.arkaPlanRenk = color.Color;
                ayarlar.Default.Save();
            }
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView2.SelectedIndices[0];
                ayarlar.Default.yilanKafaGorsel = selectedIndex + 1;
                ayarlar.Default.Save();
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView3.SelectedIndices[0];
                ayarlar.Default.govdeGorsel = selectedIndex + 1;
                ayarlar.Default.Save();
            }
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView4.SelectedIndices.Count > 0)
            {
                int selectedIndex = listView4.SelectedIndices[0];
                ayarlar.Default.elmaGorsel = selectedIndex + 1;
                ayarlar.Default.Save();
            }
        }
    }
}
