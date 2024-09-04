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
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }
        Color color=Color.White;
        private void Form5_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = new Pen(color);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 1000, 200, 1000, 800);
            e.Graphics.DrawLine(pen, 750, 200, 750, 800);
            e.Graphics.DrawLine(pen, 500, 400, 1250, 400);
            e.Graphics.DrawLine(pen, 500, 590, 1250, 590);
        }

      

        private void Form5_Load(object sender, EventArgs e)
        {
            reset();
            if (this.Tag.ToString() == "1")
            {
                label9.Text = "One Player";
            }
            else
            {
                label9.Text = "Tow Players";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackgroundImage = Resources.cross_mark_1024x1024;
        }

        short z=0 ;
        private short updatebuttons(Button sender)
        {

            if ((sender).Tag.ToString() == "10"|| (sender).Tag.ToString() == "15")
            {
                MessageBox.Show("Choose another Place", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return 0;
            }

            if (z % 2 == 0)
            {
                button9.BackColor = Color.Lime;
                label4.ForeColor = Color.Lime;

                ((Button)sender).BackgroundImage = Resources.cross_mark_1024x1024;

                z++;
                label4.Text = (this.Tag.ToString() == "1") ? ("Computer") : ("Player 2");
                ((Button)sender).Tag = "10";
                return 1;
            }
            else
            {
                button9.BackColor = Color.Red;
                label4.ForeColor = Color.Red;

                ((Button)sender).BackgroundImage =Resources._2b55;

                z++;
                label4.Text = (this.Tag.ToString() == "1") ? ("   You") : ("Player 1");
                ((Button)sender).Tag = "15";
                return 2;
            }


        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void button_Click(object sender, EventArgs e)
            
        {
            timer1.Enabled = false;
            if (updatebuttons((Button)sender) != 0)
            {
                winner();
            }
            a = TimeSpan.FromSeconds(16);
            timer1.Enabled=true;
            
        }

        private bool whoiswinner(Button btn1,Button btn2,Button btn3)
        {

            if (((btn1.Tag.ToString() != "1") && (btn1.Tag == btn2.Tag) && (btn2.Tag == btn3.Tag)))
            {
                if (btn1.Tag.ToString() == "15")
                {
                    label5.Text = (this.Tag.ToString() == "1") ? ("Computer") : (" Player 2");
                    button9.BackColor = Color.Lime;



                }
                else 
                {
                    label5.Text = (this.Tag.ToString() == "1") ? ("     You") : (" Player 1");
                    button9.BackColor = Color.Red;
                }
                
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                showmessege(" Is Winner");
                reset();
                btn1.BackColor = Color.Transparent;
                btn2.BackColor = Color.Transparent;
                btn3.BackColor = Color.Transparent;
                return true;
            }
            return false;

        }

        private void winner()
        {
            if (whoiswinner(button1, button2, button3))
                return;
            if (whoiswinner(button1, button4, button6))           
                return;          
            if (whoiswinner(button3, button10, button7))           
                return;           
            if (whoiswinner(button2, button5, button8))
                return;
            if (whoiswinner(button4, button10, button5))
                return;
            if (whoiswinner(button6, button7, button8))
                return;
            if (whoiswinner(button1, button10, button8))
                return;
            if (whoiswinner(button6, button10, button2))
                return;
            if (z == 9)
            {
                button9.BackColor = Color.Yellow;
                label5.Text = "No Winner";
                showmessege("","Game Over");
                reset();
            }

        }
        private void showmessege(string x="",string gameover="")
        {
            MessageBox.Show(label5.Text+x ,gameover,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
           

        private void resetbutton(Button btn)
        {
            btn.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            btn.Tag = "1";
        }
       

        private void reset()
        {
            z = 0;
            a = TimeSpan.FromSeconds(16);
            button9.BackColor = Color.Red;
            label4.ForeColor= Color.Red;
            label4.Text = (this.Tag.ToString() == "1") ? ("   You") : ("Player 1");
            label5.Text = "in Progress";
           // radioButton2.Checked =;
            resetbutton(button1);
            resetbutton(button10);
            resetbutton(button2);
            resetbutton(button3);
            resetbutton(button4);
            resetbutton(button5);
            resetbutton(button6);
            resetbutton(button7);
            resetbutton(button8);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Form5_Load(sender, e);

        }

        void changemode(RadioButton rd)
        {
            if (rd.Tag.ToString() == "l")
            {
                button9.BackgroundImage = Resources.finallllwhight;
                this.BackColor = Color.White;
                color = Color.Black;
                button11.BackColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label5.ForeColor = Color.OrangeRed;
                groupBox2.ForeColor = Color.Black;
                label6.ForeColor= Color.Black;
                label7.ForeColor= Color.Black;
                label8.ForeColor= Color.Black;
                label9.ForeColor= Color.Black;
            }
            else
            {
                this.BackColor = Color.Black;
                button9.BackgroundImage = Resources.finallll;
                 color = Color.White;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label5 .ForeColor = Color.Yellow;
                groupBox2.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changemode(radioButton1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changemode(radioButton2);
        }
        
        Random rand = new Random();
        
        Button chooserandombutton()
        {
            int x = 0;
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button10 };
            Button y = new Button();
            x = rand.Next(0, 9);
            y = buttons[x];
            return y;
        }
        TimeSpan a = new TimeSpan(0, 0, 16);
        TimeSpan b = new TimeSpan(0, 0, 1);

        private void TowPlayerMode(object sender, EventArgs e)
        {
            a = a - b;
            label6.Text = a.ToString();
            if (a.Seconds == 0)
            {
                label6.ForeColor = Color.Red;
                timer1.Enabled = false;
                Button xo = new Button();

                do
                {
                   
                    xo= chooserandombutton();
                } while (xo.Tag.ToString() == "10" || xo.Tag.ToString() == "15");

                button_Click((object)xo, e);
                label6.ForeColor = (radioButton1.Checked)? Color.Black:Color.White;
            }
        }
        private void OnePlayerMode(object sender,EventArgs e)
        {
            Button xo = new Button();

            if (label4.Text == "Computer")
            {
                do
                {
                    xo = chooserandombutton();
                } while (xo.Tag.ToString() == "10" || xo.Tag.ToString() == "15");
                button_Click((object)xo, e);
            }
            else
            {
                TowPlayerMode(sender, e);

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.Tag.ToString() == "1")
            {
                OnePlayerMode(sender, e);
            }
            else
            {
                TowPlayerMode(sender,e);
            }
        }

    }
}
