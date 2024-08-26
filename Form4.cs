using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        
        private void updateimage(object sender)
        {
            if (rdboy.Checked)
            {
                pictureBox1.Image = Resources.Boy;

                imagename.Text =((RadioButton)sender).Tag.ToString();
            }
            else if(rdgirl.Checked)
            {
                pictureBox1.Image = Resources.Girl;
                imagename.Text = ((RadioButton)sender).Tag.ToString();
            }
            else if(rdbook.Checked)
            {
                pictureBox1.Image = Resources.Book;
                imagename.Text = ((RadioButton)sender).Tag.ToString();
            }
            else if (rdpen.Checked)
            {
                pictureBox1.Image = Resources.Pen;
                imagename.Text = ((RadioButton)sender).Tag.ToString();
            }
        }
        private void rdboy_CheckedChanged(object sender, EventArgs e)
        {
            updateimage(sender);
        }

        private void rdgirl_CheckedChanged(object sender, EventArgs e)
        {
            updateimage(sender);
        }

        private void rdbook_CheckedChanged(object sender, EventArgs e)
        {
            updateimage(sender);
        }

        private void rdpen_CheckedChanged(object sender, EventArgs e)
        {
            updateimage(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
        }
    }
}
