using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAMCorruptor
{
    public partial class AboutBox : Form
    {
        private Random rng;
        private StringBuilder title, body;

        public AboutBox()
        {
            InitializeComponent();
            rng = new Random();
            title = new StringBuilder(lblTitle.Text);
            body = new StringBuilder(Properties.Resources.AboutText);
        }

        private void banner_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                timer.Enabled = true;
            }
        }

        private void banner_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                timer.Enabled = false;
            }
        }

        private void UpdateText()
        {
            lblTitle.Text = title.ToString();
            textBox.Text = body.ToString();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            UpdateText();
        }

        private Color RandomColor()
        {
            byte[] b = new byte[3];
            rng.NextBytes(b);
            return Color.FromArgb(b[0], b[1], b[2]);
        }

        private void ChangeOneCharacter(StringBuilder sb)
        {
            int n = rng.Next(0, sb.Length);
            byte[] b = new byte[1];
            rng.NextBytes(b);
            sb[n] = Encoding.Default.GetChars(b)[0];
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 50% chance to do nothing
            // 35% chance to change a body character
            // 10% chance to change a title character
            // 5% chance to change a color
            double r = rng.NextDouble();

            if (r < 0.05) {
                switch (rng.Next(0, 4)) {
                    case 0: BackColor = RandomColor(); break;
                    case 1: ForeColor = RandomColor(); break;
                    case 2: textBox.BackColor = RandomColor(); break;
                    case 3: textBox.ForeColor = RandomColor(); break;
                }
            } else if (r < 0.15) {
                ChangeOneCharacter(title);
            } else if (r < 0.5) {
                ChangeOneCharacter(body);
            }

            UpdateText();
        }
    }
}
