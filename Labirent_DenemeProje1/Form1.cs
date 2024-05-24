using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_DenemeProje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void gerigetir()
        {
            pictureBox1.Location = new Point(20, 20);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top += 2;
            }
            else if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top -= 2;
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 2;
            }
            else if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= 2;
            }

            Rectangle kutu = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            Rectangle r1 = new Rectangle(panel1.Location, panel1.Size);
            Rectangle r2 = new Rectangle(panel2.Location, panel2.Size);
            Rectangle r3 = new Rectangle(panel3.Location, panel3.Size);
            Rectangle r4 = new Rectangle(panel4.Location, panel4.Size);
            Rectangle r5 = new Rectangle(panel5.Location, panel5.Size);
            Rectangle r6 = new Rectangle(panel6.Location, panel6.Size);
            Rectangle r7 = new Rectangle(panel7.Location, panel7.Size);
            Rectangle r8 = new Rectangle(panel8.Location, panel8.Size);
            Rectangle r9 = new Rectangle(panel9.Location, panel9.Size);
            Rectangle r10 = new Rectangle(panel10.Location, panel10.Size);
            Rectangle r11 = new Rectangle(panel11.Location, panel11.Size);
            Rectangle r12 = new Rectangle(panel12.Location, panel12.Size);
            Rectangle r13 = new Rectangle(panel13.Location, panel13.Size);
            Rectangle r14 = new Rectangle(panel14.Location, panel14.Size);
            Rectangle r15 = new Rectangle(panel15.Location, panel15.Size);
            Rectangle r16 = new Rectangle(panel16.Location, panel16.Size);
            Rectangle r17 = new Rectangle(panel17.Location, panel17.Size);
            Rectangle r18 = new Rectangle(panel18.Location, panel18.Size);
            Rectangle r19 = new Rectangle(panel19.Location, panel19.Size);
            Rectangle r20 = new Rectangle(panel20.Location, panel20.Size);
            Rectangle r21 = new Rectangle(panel21.Location, panel21.Size);
            Rectangle r22 = new Rectangle(panel22.Location, panel22.Size);
            Rectangle r23 = new Rectangle(panel23.Location, panel23.Size);
            Rectangle r24 = new Rectangle(panel24.Location, panel24.Size);
            Rectangle r25 = new Rectangle(panel25.Location, panel25.Size);
            Rectangle r26 = new Rectangle(panel26.Location, panel26.Size);

            if (kutu.IntersectsWith(r1))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r2))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r3))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r4))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r5))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r6))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r7))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r8))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r9))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r10))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r11))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r12))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r13))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r14))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r15))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r16))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r17))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r18))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r19))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r20))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r21))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r22))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r23))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r24))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r25))
            {
                gerigetir();
            }
            else if (kutu.IntersectsWith(r26))
            {
                this.BackColor = Color.Yellow;
                timer1.Stop();
                MessageBox.Show("Bravo, Oyunu Kazandınız!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac1=0,sayac2=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac1++;
            label2.Text=sayac1.ToString();
            if (sayac1 == 59)
            {
                sayac1 = 0;
                sayac2++;
            }
            label4.Text = sayac2.ToString();
        }
    }
}
