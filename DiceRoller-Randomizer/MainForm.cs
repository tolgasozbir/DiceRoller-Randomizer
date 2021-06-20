using DiceRoller_Randomizer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller_Randomizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            customizeDesign();
            
            //for effectives titles
            for (int i = 0; i < title.Length; i++)
            {
                chars.Add(title[i]);
            }
        }


        #region EffectivesLabelName
        
        
        string title = "Dice Roller - Randomizer";
        List<char> chars = new List<char>();

        Random rnd = new Random();

        string effecttedTitle;
        int counter = 0;
        int increment = 1;
        bool wait = false;
        int waitSecond = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!wait)
            {
                effecttedTitle = "";
                for (int i = 0; i < increment; i++)
                {
                    effecttedTitle += chars[i] = title[i];
                }

                for (int i = 0 + increment; i < chars.Count; i++)
                {
                    chars[i] = (char)rnd.Next('A', 'Z');
                    effecttedTitle += chars[i];
                }
                lblTitle.Text = effecttedTitle;
                counter++;
                if (counter == 10)
                {
                    if (increment == title.Length)
                    {
                        increment = 0;
                        wait = true;
                    }
                    counter = 0;
                    effecttedTitle = chars[increment].ToString() + title[increment].ToString();
                    increment++;
                    timer1.Interval -= 2;
                }
            }
            else
            {
                timer1.Interval = 1000;
                waitSecond++;
                if (waitSecond==10)
                {
                    waitSecond = 0;
                    wait = false;
                    timer1.Interval = 50;
                    increment = 1;
                }
            }

        }

        #endregion

        #region Design

        private void customizeDesign()
        {
            panelDnDDicesSubMenu.Visible = false;
            panelCreateSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            panelDnDDicesSubMenu.Visible = false;
            panelCreateSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openForm(Form frm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
                activeForm = frm;
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panelContent.Controls.Add(frm);
                panelContent.Tag = frm;
                frm.BringToFront();
                frm.Show();
        }

        #endregion

        #region DndDices
        private void btnDndDices_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDnDDicesSubMenu);
        }

        FormDnD formDnD;
        private void btnRolld4_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 4);
            formDnD.pictureBox1.Image = Image.FromFile(@"Resources\d4_roll.png");
            formDnD.lblDiceNumber.Location = new Point(235, 95);
            openForm(formDnD);
            hideSubMenu();
        }

        private void btnRolld6_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 6);
            formDnD.pictureBox1.Image = Image.FromFile(@"Resources\d6_roll.png");
            formDnD.lblDiceNumber.Location = new Point(226, 55);
            formDnD.lblDiceNumber.Height = 52;
            openForm(formDnD);
            hideSubMenu();
        }

        private void btnRolld8_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 8);
            formDnD.pictureBox1.Image = Image.FromFile(@"Resources\d8_roll.png");
            formDnD.lblDiceNumber.Location = new Point(235, 75);
            openForm(formDnD);
            hideSubMenu();
        }

        private void btnRolld10_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 10);
            formDnD.pictureBox1.Image = Image.FromFile(@"Resources\d10_roll.png");
            formDnD.lblDiceNumber.Location = new Point(226, 78);
            formDnD.lblDiceNumber.Width = 54;
            formDnD.lblDiceNumber.Height = 30;
            formDnD.lblDiceNumber.Font = new Font("Arial", 24);
            openForm(formDnD);
            hideSubMenu();
        }

        private void btnRolld12_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 12);
            formDnD.pictureBox1.Image = Image.FromFile(@"Resources\d12_roll.png");
            formDnD.lblDiceNumber.Location = new Point(205, 84);
            formDnD.lblDiceNumber.Width = 55;
            formDnD.lblDiceNumber.Height = 48;
            formDnD.lblDiceNumber.Font = new Font("Arial", 26);
            openForm(formDnD);
            hideSubMenu();
        }

        private void btnRolld20_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 20);
            formDnD.pictureBox1.Image = Image.FromFile(@"Resources\d20_roll.png");
            formDnD.lblDiceNumber.Location = new Point(222, 88);
            formDnD.lblDiceNumber.Width = 55;
            formDnD.lblDiceNumber.Height = 34;
            formDnD.lblDiceNumber.Font = new Font("Arial", 26);
            openForm(formDnD);
            hideSubMenu();
        }

        private void btnRolld100_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 100);
            formDnD.pictureBox1.Image = Image.FromFile(@"Resources\d100_roll.gif");
            formDnD.lblDiceNumber.Location = new Point(213, 89);
            formDnD.lblDiceNumber.Width = 75;
            formDnD.lblDiceNumber.Height = 34;
            formDnD.lblDiceNumber.Font = new Font("Arial", 26);
            openForm(formDnD);
            hideSubMenu();
            hideSubMenu();
        }
        #endregion

        #region Create
        private void btnCreate_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCreateSubMenu);
        }

        FormBasicDiceRoll formBasicDiceRoll;
        private void btnRollBasicDice_Click(object sender, EventArgs e)
        {
            formBasicDiceRoll = new FormBasicDiceRoll();
            openForm(formBasicDiceRoll);
            hideSubMenu();
        }
        FormRandomList formRandomList;
        private void BtnRandomizer_Click(object sender, EventArgs e)
        {
            formRandomList = new FormRandomList();
            openForm(formRandomList);
            hideSubMenu();
        }
        FormGenerateNumber formGenerateNumber;
        private void btnGenerateNumber_Click(object sender, EventArgs e)
        {
            formGenerateNumber = new FormGenerateNumber();
            openForm(formGenerateNumber);
            hideSubMenu();
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thx For Using This App\n\nTolga Sözbir.","They See Me Rollin..");
        }



    }
}
