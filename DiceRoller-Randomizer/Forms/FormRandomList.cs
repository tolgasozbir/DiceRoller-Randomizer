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
    public partial class FormRandomList : Form
    {
        public FormRandomList()
        {
            InitializeComponent();
        }

        private void FormRandomList_Load(object sender, EventArgs e)
        {

        }
        Regex regex = new Regex("^[A-Z]|[0-9]|[a-z]");
        Match match;

        List<string> sides = new List<string>();
        private void btnAddSide_Click(object sender, EventArgs e)
        {
            match = regex.Match(tbInputSide.Text);
            if (match.Success)
            {
                sides.Add(tbInputSide.Text);
                lblSides.Text += "\"" + tbInputSide.Text + "\" ";
                tbInputSide.Text = "";
                tbInputSide.Focus();
            }
            else
            {
                tbInputSide.Text = "";
            }

        }

        Random rnd = new Random();
        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (sides.Count > 0)
            {
                int rndSideIndex = rnd.Next(0, sides.Count);
                label1.Text = sides[rndSideIndex].ToString();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblSides.Text = "";
            sides.Clear();
            label1.Text = "Add Words";
        }
    }
}
