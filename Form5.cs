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
        enum enfirstorsecound
        {
            first = 1,
            secouned = 2
        };
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;

            Pen pen = new Pen(white);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 1000, 200, 1000, 800);
            e.Graphics.DrawLine(pen, 750, 200, 750, 800);
            e.Graphics.DrawLine(pen, 500, 400, 1250, 400);
            e.Graphics.DrawLine(pen, 500, 590, 1250, 590);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackgroundImage = Resources.cross_mark_1024x1024;
        }

        int z = 0;
        private int updatebuttons(object sender)
        {

            if (((Button)sender).Tag.ToString() == "10"|| ((Button)sender).Tag.ToString() == "15")
            {
                MessageBox.Show("Choose another Place","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return 0;
            }

            if (z % 2 == 0)
            {
                button9.BackColor = Color.Lime;
                label4.Text = "Player 1";
                label4.ForeColor = Color.Lime;
                ((Button)sender).BackgroundImage = Resources.cross_mark_1024x1024;
                z++;
                label4.Text = "Player 2";
                ((Button)sender).Tag = "10";
                return 1;
            }
            else
            {
                button9.BackColor = Color.Red;
                label4.Text = "player 2";
                label4.ForeColor = Color.Red;
                ((Button)sender).BackgroundImage =Resources._2b55;
                z++;
                label4.Text = "Player 1";
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
            if (updatebuttons(sender) != 0)
            {
                whoiswinner();
            }
        }

        private void whoiswinner()
        {

            if (((button1.Tag == button2.Tag) && (button2.Tag == button3.Tag)) || ((button1.Tag == button4.Tag) && (button4.Tag == button6.Tag)))
            {
                if (button1.Tag.ToString() == "15")
                {
                    label5.Text = "  Player 2";
                    button9.BackColor = Color.Lime;



                }
                else
                {
                    label5.Text = "  Player 1";
                    button9.BackColor = Color.Red;
                }
                showmessege();
                reset();
                return;
            }
            else if (((button10.Tag == button7.Tag) && (button7.Tag == button3.Tag)) || ((button10.Tag == button5.Tag) && (button5.Tag == button4.Tag)))
            {
                if (button10.Tag.ToString() == "15")
                {
                    label5.Text = "  Player 2";
                    button9.BackColor = Color.Lime;

                }
                else
                {
                    label5.Text = "  Player 1";
                    button9.BackColor = Color.Red;
                }
                showmessege();
                reset();
                return;
            }
            else if (((button8.Tag == button5.Tag) && (button5.Tag == button2.Tag)) || ((button8.Tag == button7.Tag) && (button7.Tag == button6.Tag)))
            {
                if (button8.Tag.ToString() == "15")
                {
                    label5.Text = "  Player 2";
                    button9.BackColor = Color.Lime;
                }
                else
                {
                    label5.Text = "  Player 1";
                    button9.BackColor = Color.Red;
                }
                showmessege();
                reset();
                return;
            }
            else if (((button10.Tag == button8.Tag) && (button8.Tag == button1.Tag)) || ((button10.Tag == button2.Tag) && (button2.Tag == button6.Tag)))
            {
                if (button10.Tag.ToString() == "15")
                {
                    label5.Text = "  Player 2";
                    button9.BackColor = Color.Lime;


                }
                else
                {
                    label5.Text = "  Player 1";
                    button9.BackColor = Color.Red;
                }
                showmessege();
                reset();
                return;
            }

            if (z == 9)
            {
                button9.BackColor = Color.Yellow;
                label5.Text = "  No One";
                showmessege("Game Over");
                reset();
            }
            
        }

        private void showmessege(string gameover="")
        {
            MessageBox.Show(label5.Text + " is Winner",gameover,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
           

       

        private void reset()
        {
            z = 0;
            label4.Text = "Player 1";
            label5.Text = "in Progress";
            button1.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            button1.Tag = "2";
            button2.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            button2.Tag = "3";
            button3.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            button3.Tag = "4";
            button4.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            button4.Tag = "5";
            button5.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            button5.Tag = "6";
            button6.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            button6.Tag = "7";
            button7.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            button7.Tag = "8";
            button8.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            button8.Tag = "9";
            button10.BackgroundImage = Resources._5bbefabf4b86b_4e47674b2f1837660ba80fc2dc33e3f9;
            button10.Tag = "1";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            reset();

        }
    }
}
