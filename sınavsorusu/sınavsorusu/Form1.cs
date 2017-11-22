using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sınavsorusu
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush b = new SolidBrush(Color.Blue);
        Color renk;
        int topx = 50, topy = 50;
        int w, h;
        bool tavan;
        bool kenar;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            renk = this.BackColor;
            Brush b2 = new SolidBrush(renk);
            w = this.Width;
            h = this.Height;
            if (topx <= 0)
            {
                kenar = true;
            }
            if (topx >= w-50)
            {
                kenar = false;
            }
            if (topy <= 0)
            {
                tavan = true;
            }
            if (topy >= h-70)
            {
                tavan = false;
            }

            if (tavan == false)
            {
                g.FillEllipse(b2, topx, topy, 35, 35);
                topy--;
                g.FillEllipse(b, topx, topy, 35, 35);
            }
            if (tavan == true)
            {
                g.FillEllipse(b2, topx, topy, 35, 35);
                topy++;
                g.FillEllipse(b, topx, topy, 35, 35);
            }
            if (kenar == false)
            {
                g.FillEllipse(b2, topx, topy, 35, 35);
                topx--;
                g.FillEllipse(b, topx, topy, 35, 35);
            }
            if (kenar == true)
            {
                g.FillEllipse(b2, topx, topy, 35, 35);
                topx++;
                g.FillEllipse(b, topx, topy, 35, 35);
            }
        }
    }
}
