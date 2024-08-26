using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        int total = 0;

        string[] topping = new string[6];

        enum ensize
        {
            small=20,
            midiuem=30,
            large=40
        };

        enum enCrusttype
        {
            thin=10,
            think=15
        };

        enum enwhereEating
        {
            eatIn=10,
            eatOut=5
        }
        enCrusttype crust;
        enwhereEating eat;
        ensize pizzaSize;
        public Form3()
        {
            InitializeComponent();
        }

        public void sizechanged()
        {
            if (rdsizelarge.Checked)
            {
                txtsize.Text = "Large";
                total -= (int)pizzaSize;
                total += 40;
                pizzaSize = ensize.large;


            }

            else if (rdSizesmall.Checked)
            {
                txtsize.Text = "Small";
                total -= (int)pizzaSize;
                total += 20;
                pizzaSize = ensize.small;

                
            }

            else if (srSizeMediem.Checked)
            {
                txtsize.Text = "Small";
                total -= (int)pizzaSize;
                total += 20;
                pizzaSize = ensize.small;

                
            }

            label1.Text = "$" + total.ToString();
        }

        public void crustTypechanged()
        {
            if (rdThincrust.Checked)
            {
                txtcrusttype.Text = "Thin Crust";
                total -= (int)crust;
                total += 10;
                crust = enCrusttype.thin;

               
            }
            else if (rdThinkcrust.Checked)
            {
                txtcrusttype.Text = "Think Crust";
                total -= (int)crust;
                total += 15;
                crust = enCrusttype.think;

               
            }

            label1.Text = "$" + total.ToString();
        }

        private void wheretoeat()
        {
            if(rdeatin.Checked)
            {
                txtwheretoeat.Text = "Eat in";
                total -= (int)eat;
                total += 10;
                eat = enwhereEating.eatIn;

            }
            else if (rdtakeout.Checked)
            {
                txtwheretoeat.Text = "Take Out";
                total -= (int)eat;
                total += 5;
                eat = enwhereEating.eatOut;

                
            }
            label1.Text = "$" + total.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private string arrtostring(string[] arr)
        {
            
            string word="";
            for(int i=0;i<arr.Length; i++)
            {
                
                if (arr[i] != null)
                {
                   
                    
                    word += arr[i] + ',';
                   
                }

                if (i == arr.Length - 1)
                {
                    if (word == "")
                    {
                        word = "no topping";

                    }
                    else
                    {
                        word = word.Substring(0, word.Length - 1);
                    }


                }
            }

            return word;
            
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            crustTypechanged();
        }

        private void rdThinkcrust_CheckedChanged(object sender, EventArgs e)
        {
            crustTypechanged();
        }

        private void rdeatin_CheckedChanged(object sender, EventArgs e)
        {
            wheretoeat();
        }

        private void rdtakeout_CheckedChanged(object sender, EventArgs e)
        {
            wheretoeat();
        }

        private void chktoppingcheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoppingcheese.Checked)
            {
                total += 5;

                topping[0] = "ExtraCheese";

            }
            else
            {
                total -= 5;
                topping[0] = null;
            }
            label1.Text = "$"+total.ToString();

            txttopping.Text = arrtostring(topping);
        }

        private void chktoppingmushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoppingmushroom.Checked)
            {
                total += 3;
                topping[1] = "Mushrom";
            }
            else
            {
                topping[1] = null;
                total -= 3;
            }
            label1.Text = "$"+total.ToString();

            txttopping.Text = arrtostring(topping);
        }

        private void chktoppingtomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoppingtomatoes.Checked)
            {
                total += 3;
                topping[2] = "Tomatoes";
            }
            else
            {
                total -= 3;
                topping[2] = null;
            }
            label1.Text = "$"+total.ToString();

            txttopping.Text = arrtostring(topping);
        }

        private void chktoppingonion_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoppingonion.Checked)
            {
                total += 2;
                topping[3] = "Onion";
            }
            else
            {
                total -= 2;
                topping[3] = null;
            }
            label1.Text = "$"+total.ToString();

            txttopping.Text = arrtostring(topping);
        }

        private void chktppingolves_CheckedChanged(object sender, EventArgs e)
        {
            if (chktppingolves.Checked)
            {
                total += 2;
                topping[4] = "Olves";
            }
            else
            {
                total -= 2;
                topping[4] = null;
            }
            label1.Text = "$"+total.ToString();

            txttopping.Text = arrtostring(topping);
        }

        private void chktoppingpeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoppingpeppers.Checked)
            {
                total += 1;
                topping[5] = "GreenPepers";
            }
            else
            {
                total -= 1;
                topping[5]= null;
            }
            label1.Text = "$"+total.ToString();

            txttopping.Text = arrtostring(topping);
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

            sizechanged();
        }

        private void srSizeMediem_CheckedChanged(object sender, EventArgs e)
        {
            sizechanged();
        }

        private void rdSizesmall_CheckedChanged(object sender, EventArgs e)
        {
            sizechanged();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtsize_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? ", "Order Pizza", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                button1.Enabled = false;

                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? ", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;

                rdtakeout.Checked = false;
                rdeatin.Checked = false;
                rdSizesmall.Checked = false;
                rdsizelarge.Checked = false;
                rdThincrust.Checked = false;
                rdThinkcrust.Checked = false;
                srSizeMediem.Checked = false;
                chktoppingcheese.Checked = false;
                chktoppingmushroom.Checked = false;
                chktoppingonion.Checked = false;
                chktoppingpeppers.Checked = false;
                chktppingolves.Checked = false;
                chktoppingtomatoes.Checked = false;

                txtcrusttype.Text = string.Empty;
                txtsize.Text = string.Empty;
                txttopping.Text = string.Empty;
                txtwheretoeat.Text = string.Empty;
                label1.Text = "$0";
            }
        }
    }
}
