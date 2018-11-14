using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Program_muzyczny
{
    public partial class Form1 : Form
    {
        private SoundPlayer b1 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b2 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b3 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b4 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b5 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b6 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b7 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b8 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b9 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b10 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b11 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b12 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b13 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b14 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b15 = new System.Media.SoundPlayer("sound1.wav");
        private SoundPlayer b16 = new System.Media.SoundPlayer("sound1.wav");
        bool a = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b1.Play();
            }
            else
            {
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    b1 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (a)
            { 
                button1.Image = (Properties.Resources._5933_200);
                button2.Image = (Properties.Resources._5933_200);
                button3.Image = (Properties.Resources._5933_200);
                button4.Image = (Properties.Resources._5933_200);
                button5.Image = (Properties.Resources._5933_200);
                button6.Image = (Properties.Resources._5933_200);
                button7.Image = (Properties.Resources._5933_200);
                button8.Image = (Properties.Resources._5933_200);
                button9.Image = (Properties.Resources._5933_200);
                button10.Image = (Properties.Resources._5933_200);
                button11.Image = (Properties.Resources._5933_200);
                button12.Image = (Properties.Resources._5933_200);
                button13.Image = (Properties.Resources._5933_200);
                button14.Image = (Properties.Resources._5933_200);
                button15.Image = (Properties.Resources._5933_200);
                button16.Image = (Properties.Resources._5933_200);
                a = false;
            }
            else
            {
                button1.Image = null;
                button2.Image = null;
                button3.Image = null;
                button4.Image = null;
                button5.Image = null;
                button6.Image = null;
                button7.Image = null;
                button8.Image = null;
                button9.Image = null;
                button10.Image = null;
                button11.Image = null;
                button12.Image = null;
                button13.Image = null;
                button14.Image = null;
                button15.Image = null;
                button16.Image = null;
                a = true;
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b2.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b2 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (a)
            {
                b3.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b3 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (a)
            {
                b4.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b4 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (a)
            {
                b5.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b5 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b6.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b6 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b7.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b7 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b8.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b8 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b9.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b9 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b10.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b10 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b11.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b11 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b12.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b12 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b13.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b13 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b14.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b14 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b15.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b15 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (a)
            {
                b16.Play();
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    b16 = new System.Media.SoundPlayer(openFileDialog1.FileName);
                }
            }
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            this.Size = new Size(322, 295);
        }

        private void x3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button7.Visible = true;
            button4.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            this.Size = new Size(322, 386);

        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button7.Visible = true;
            button4.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            this.Size = new Size(322, 295);

        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button7.Visible = true;
            button4.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            this.Size = new Size(322, 482);

        }

        private void x4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button7.Visible = true;
            button4.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            this.Size = new Size(415, 482);

        }
    }
}
