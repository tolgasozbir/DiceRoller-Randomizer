using DiceRoller_Randomizer.Forms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            customizeDesign();
        }

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

        #region DndDices
        private void btnDndDices_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDnDDicesSubMenu);
        }

        FormDnD formDnD;
        private void btnRolld4_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 4);
            formDnD.pictureBox1.Image = Image.FromFile("dndDices\\d4_roll.png");
            formDnD.lblDiceNumber.Location = new Point(235, 95);
            openForm(formDnD);
            hideSubMenu();
        }

        private void btnRolld6_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 6);
            formDnD.pictureBox1.Image = Image.FromFile("dndDices\\d6_roll.png");
            formDnD.lblDiceNumber.Location = new Point(226, 55);
            formDnD.lblDiceNumber.Height = 52;
            openForm(formDnD);
            hideSubMenu();
        }

        private void btnRolld8_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 8);
            formDnD.pictureBox1.Image = Image.FromFile("dndDices\\d8_roll.png");
            formDnD.lblDiceNumber.Location = new Point(235, 75);
            openForm(formDnD);
            hideSubMenu();
        }

        private void btnRolld10_Click(object sender, EventArgs e)
        {
            formDnD = new FormDnD(1, 10);
            formDnD.pictureBox1.Image = Image.FromFile("dndDices\\d10_roll.png");
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
            formDnD.pictureBox1.Image = Image.FromFile("dndDices\\d12_roll.png");
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
            formDnD.pictureBox1.Image = Image.FromFile("dndDices\\d20_roll.png");
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
            formDnD.pictureBox1.Image = Image.FromFile("dndDices\\d100_roll.gif");
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
            MessageBox.Show("Thx For Using This App\n\nTolga Sözbir.","They See Me Rollin");
        }
    }
}
