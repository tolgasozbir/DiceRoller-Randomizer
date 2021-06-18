using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiceRoller_Randomizer.Forms
{
    public partial class FormBasicDiceRoll : Form
    {
        public FormBasicDiceRoll()
        {
            InitializeComponent();
        }

        private void FormBasicDiceRoll_Load(object sender, EventArgs e)
        {

        }

        public int total = 0;
        public List<int> throws = new List<int>();
        private void ResetCounter()
        {
            total = 0;
            lblThrows.Text = "";
            lblTotal.Text = total.ToString();
        }

        private void Calculate(List<int> valueList)
        {
            foreach (var item in valueList)
            {
                total += item;
                lblThrows.Text += "-->" + item.ToString();
            }
            lblTotal.Text = total.ToString();
           
        }
        Random rnd = new Random();
        int dice;
        private void btnRoll_Click(object sender, EventArgs e)
        {
            ResetCounter();
            throws.Clear();
            timer1.Start();
            btnRoll.Enabled = false;
            numBox.Enabled = false;
        }

        PictureBox[] pictureBoxes = new PictureBox[9];
        FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

        int numberOfDice;
        private void numBox_ValueChanged(object sender, EventArgs e)
        {
            if (numBox.Value==0)
            {
                btnRoll.Enabled = false;
                btnRoll.Text = "Choose Number of Dice";
            }
            else
            {
                btnRoll.Enabled = true;
                btnRoll.Text = "Roll";
            }

            flowLayoutPanel.Controls.Clear();
            numberOfDice = (int)numBox.Value;

            
            flowLayoutPanel.Location = new Point(100, 35);
            flowLayoutPanel.Size = new Size(360, 220);
            this.Controls.Add(flowLayoutPanel);


            for (int i = 0; i < numberOfDice; i++)
            {
                pictureBoxes[i] = new PictureBox();
                pictureBoxes[i].Image = Image.FromFile(@"Resources\dice-" + "1" + ".png");
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
                flowLayoutPanel.Controls.Add(pictureBoxes[i]);

                #region LocationOfDices

                switch (numberOfDice)
                {
                    case 1:
                        {
                            flowLayoutPanel.Location = new Point(185, 55);
                            pictureBoxes[i].Width = 128;
                            pictureBoxes[i].Height = 128;
                            break;
                        }
                    case 2:
                        flowLayoutPanel.Location = new Point(121, 55);
                        pictureBoxes[i].Width = 128;
                        pictureBoxes[i].Height = 128;
                        break;
                    case 3:
                        flowLayoutPanel.Location = new Point(102, 75);
                        pictureBoxes[i].Width = 92;
                        pictureBoxes[i].Height = 92;
                        break;
                    case 4:
                        flowLayoutPanel.Location = new Point(183, 55);
                        flowLayoutPanel.Size = new Size(150, 220);
                        pictureBoxes[i].Width = 64;
                        pictureBoxes[i].Height = 64;
                        break;
                }

                #endregion

            }
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfDice; i++)
            {
                dice = rnd.Next(1, 7);
                pictureBoxes[i].Image = Image.FromFile(@"Resources\dice-" + dice.ToString() + ".png");
                pictureBoxes[i].Tag = dice.ToString();
            }  
            counter++;
            if (counter == 12)
            {
                timer1.Interval = 50;
                counter = 0;
                timer1.Stop();
                dices();
                btnRoll.Enabled = true;
                numBox.Enabled = true;
            }
            timer1.Interval += 10;
        }

        void dices()
        {
            for (int i = 0; i < numberOfDice; i++)
            {
                dice = rnd.Next(1, 7);
                pictureBoxes[i].Image = Image.FromFile(@"Resources\dice-" + dice.ToString() + ".png");
                pictureBoxes[i].Tag = dice.ToString();
                throws.Add(Convert.ToInt32(dice));
            }
            Calculate(throws);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
