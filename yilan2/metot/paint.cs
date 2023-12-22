using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETsnake.metot
{
    internal class paint
    {
        public static void Elma_Paint(object? sender, PaintEventArgs e)
        {
            using (Image image = Al(ayarlar.Default.elmaGorsel))
            {
                e.Graphics.DrawImage(image, new Rectangle(0, 0, 20, 20));
            }
            
        }

        public static void Yilan_Paint(object? sender, PaintEventArgs e)
        {
            using (Image image = Al(ayarlar.Default.yilanKafaGorsel))
            {
                e.Graphics.DrawImage(image, new Rectangle(0, 0, 20, 20));
            }
        }

        public static void Parca_Paint(object sender, PaintEventArgs e)
        {
            using (Image image = Al(ayarlar.Default.govdeGorsel))
            {
                e.Graphics.DrawImage(image, new Rectangle(0, 0, 20, 20));
            }
        }

        public static Bitmap Al(int parametre)
        {
            switch(parametre)
            {
                case 1:
                    return Properties.Resources._1;
                    break;
                case 2:
                    return Properties.Resources._2;
                    break;
                case 3:
                    return Properties.Resources._3;
                    break;
                case 4:
                    return Properties.Resources._4;
                    break;
                case 5:
                    return Properties.Resources._5;
                    break;
                case 6:
                    return Properties.Resources._6;
                    break;
                case 7:
                    return Properties.Resources._7;
                    break;
                case 8:
                    return Properties.Resources._8;
                    break;
                case 9:
                    return Properties.Resources._9;
                    break;
                case 10:
                    return Properties.Resources._10;
                    break;
                case 11:
                    return Properties.Resources._11;
                    break;
                case 12:
                    return Properties.Resources._12;
                    break;
                case 13:
                    return Properties.Resources._13;
                    break;
                case 14:
                    return Properties.Resources._14;
                    break;
                default:
                    return Properties.Resources._1;
                    break;
            }
        }
    }
}
