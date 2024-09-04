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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ahmed_Click(object sender, EventArgs e)
        {
            Form form5= new Form5();
            form5.Tag = "1";
            form5.ShowDialog();
             
        }

        private void ahmed_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.Lime;
        }

        private void ahmed_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.Tag = "2";
            form5.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            button4.BackgroundImage = Resources.finallllwhight;
            label1.ForeColor = Color.Red;
            radioButton2.ForeColor = Color.Black;
            radioButton1.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            label2.ForeColor = Color.DarkOrange;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            button4.BackgroundImage = Resources.finallll;
            label2.ForeColor = Color.Yellow;
            radioButton1.ForeColor = Color.White;
            radioButton2.ForeColor = Color.White;
            groupBox1.ForeColor = Color.White;
            label2.ForeColor = Color.Lime;
        }
    }
}
