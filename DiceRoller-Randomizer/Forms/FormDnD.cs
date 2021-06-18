using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller_Randomizer
{
    public partial class FormDnD : Form
    {
        public FormDnD(int min,int max)
        {
            InitializeComponent();
            _max = max;
            _min = min;
        }

        int count = 0;
        Random rnd = new Random();
        int dice;
        private int _max;
        private int _min;


        public int lastThrow;
        public int total = 0;
        private void ResetCounter()
        {
            total = 0;
            lblThrows.Text = "";
            lblTotal.Text = total.ToString();
        }

        private void Calculate(int value)
        {
            total += value;
            lblTotal.Text = total.ToString();
            lastThrow = value;
            if (clickCounter == 8)
            {
                lblThrows.Text = "";
            }
            lblThrows.Text += "-->" + value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dice = rnd.Next(_min, _max+1);
            if (count == 10)
            {
                timer1.Stop();
                count = 0;
                timer1.Interval = 50;
                btnRoll.Enabled = true;
                btnReset.Enabled = true;
                Calculate(dice);
            }
            count++;
            timer1.Interval += 10;
            lblDiceNumber.Text = dice.ToString();
        }

        int clickCounter = -1;
        private void btnRoll_Click(object sender, EventArgs e)
        {
            clickCounter++;
            timer1.Start();
            btnRoll.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetCounter();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
