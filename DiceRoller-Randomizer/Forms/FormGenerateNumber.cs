using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller_Randomizer.Forms
{
    public partial class FormGenerateNumber : Form
    {
        public FormGenerateNumber()
        {
            InitializeComponent();
        }

        private void FormGenerateNumber_Load(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Regex regex = new Regex("^[0-9]*$");
        Match matchMin;
        Match matchMax;
        Random rnd = new Random();
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            timer1.Interval += 10;

            matchMin = regex.Match(tbInputValueMin.Text);
            matchMax = regex.Match(tbInputValueMax.Text);
            if (matchMin.Success && matchMax.Success)
            {
                int min = Convert.ToInt32(tbInputValueMin.Text);
                int max = Convert.ToInt32(tbInputValueMax.Text);
                if (max >= min)
                {
                    int value = rnd.Next(min, max + 1);
                    label1.Text = value.ToString();
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("invalid value");
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("invalid value");
            }
                
            if (counter==10)
            {
                counter = 0;
                timer1.Interval = 50;
                timer1.Stop();
            }
        }
    }
}
