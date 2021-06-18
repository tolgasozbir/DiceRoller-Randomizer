namespace DiceRoller_Randomizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDnDDicesSubMenu = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelCreateSubMenu = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerateNumber = new System.Windows.Forms.Button();
            this.BtnRandomizer = new System.Windows.Forms.Button();
            this.btnRollBasicDice = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRolld100 = new System.Windows.Forms.Button();
            this.btnRolld20 = new System.Windows.Forms.Button();
            this.btnRolld12 = new System.Windows.Forms.Button();
            this.btnRolld10 = new System.Windows.Forms.Button();
            this.btnRolld8 = new System.Windows.Forms.Button();
            this.btnRolld6 = new System.Windows.Forms.Button();
            this.btnRolld4 = new System.Windows.Forms.Button();
            this.btnDndDices = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.panelDnDDicesSubMenu.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelCreateSubMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "     Roll Dice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDnDDicesSubMenu
            // 
            this.panelDnDDicesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelDnDDicesSubMenu.Controls.Add(this.btnRolld100);
            this.panelDnDDicesSubMenu.Controls.Add(this.btnRolld20);
            this.panelDnDDicesSubMenu.Controls.Add(this.btnRolld12);
            this.panelDnDDicesSubMenu.Controls.Add(this.btnRolld10);
            this.panelDnDDicesSubMenu.Controls.Add(this.btnRolld8);
            this.panelDnDDicesSubMenu.Controls.Add(this.btnRolld6);
            this.panelDnDDicesSubMenu.Controls.Add(this.btnRolld4);
            this.panelDnDDicesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDnDDicesSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelDnDDicesSubMenu.Name = "panelDnDDicesSubMenu";
            this.panelDnDDicesSubMenu.Size = new System.Drawing.Size(229, 280);
            this.panelDnDDicesSubMenu.TabIndex = 2;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.panelCreateSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCreate);
            this.panelSideMenu.Controls.Add(this.panelDnDDicesSubMenu);
            this.panelSideMenu.Controls.Add(this.btnDndDices);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 553);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelCreateSubMenu
            // 
            this.panelCreateSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCreateSubMenu.Controls.Add(this.btnGenerateNumber);
            this.panelCreateSubMenu.Controls.Add(this.BtnRandomizer);
            this.panelCreateSubMenu.Controls.Add(this.btnRollBasicDice);
            this.panelCreateSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreateSubMenu.Location = new System.Drawing.Point(0, 470);
            this.panelCreateSubMenu.Name = "panelCreateSubMenu";
            this.panelCreateSubMenu.Size = new System.Drawing.Size(229, 130);
            this.panelCreateSubMenu.TabIndex = 4;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelContent.Controls.Add(this.btnInfo);
            this.panelContent.Controls.Add(this.pictureBox1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(682, 553);
            this.panelContent.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DiceRoller_Randomizer.Properties.Resources.gifLogo;
            this.pictureBox1.Location = new System.Drawing.Point(170, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(229, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerateNumber
            // 
            this.btnGenerateNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateNumber.FlatAppearance.BorderSize = 0;
            this.btnGenerateNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateNumber.ForeColor = System.Drawing.Color.LightGray;
            this.btnGenerateNumber.Image = global::DiceRoller_Randomizer.Properties.Resources.rng;
            this.btnGenerateNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateNumber.Location = new System.Drawing.Point(0, 80);
            this.btnGenerateNumber.Name = "btnGenerateNumber";
            this.btnGenerateNumber.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGenerateNumber.Size = new System.Drawing.Size(229, 42);
            this.btnGenerateNumber.TabIndex = 2;
            this.btnGenerateNumber.Text = "        Random Numbers";
            this.btnGenerateNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerateNumber.UseVisualStyleBackColor = true;
            this.btnGenerateNumber.Click += new System.EventHandler(this.btnGenerateNumber_Click);
            // 
            // BtnRandomizer
            // 
            this.BtnRandomizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRandomizer.FlatAppearance.BorderSize = 0;
            this.BtnRandomizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRandomizer.ForeColor = System.Drawing.Color.LightGray;
            this.BtnRandomizer.Image = global::DiceRoller_Randomizer.Properties.Resources.card_random__1_;
            this.BtnRandomizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRandomizer.Location = new System.Drawing.Point(0, 40);
            this.BtnRandomizer.Name = "BtnRandomizer";
            this.BtnRandomizer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRandomizer.Size = new System.Drawing.Size(229, 40);
            this.BtnRandomizer.TabIndex = 1;
            this.BtnRandomizer.Text = "        Randomizer";
            this.BtnRandomizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRandomizer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRandomizer.UseVisualStyleBackColor = true;
            this.BtnRandomizer.Click += new System.EventHandler(this.BtnRandomizer_Click);
            // 
            // btnRollBasicDice
            // 
            this.btnRollBasicDice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRollBasicDice.FlatAppearance.BorderSize = 0;
            this.btnRollBasicDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollBasicDice.ForeColor = System.Drawing.Color.LightGray;
            this.btnRollBasicDice.Image = global::DiceRoller_Randomizer.Properties.Resources.RollDiceCup;
            this.btnRollBasicDice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRollBasicDice.Location = new System.Drawing.Point(0, 0);
            this.btnRollBasicDice.Name = "btnRollBasicDice";
            this.btnRollBasicDice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRollBasicDice.Size = new System.Drawing.Size(229, 40);
            this.btnRollBasicDice.TabIndex = 0;
            this.btnRollBasicDice.Text = "       Roll Basic Dice";
            this.btnRollBasicDice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRollBasicDice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRollBasicDice.UseVisualStyleBackColor = true;
            this.btnRollBasicDice.Click += new System.EventHandler(this.btnRollBasicDice_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.Image = global::DiceRoller_Randomizer.Properties.Resources.createDices;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 425);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCreate.Size = new System.Drawing.Size(229, 45);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "   Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRolld100
            // 
            this.btnRolld100.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRolld100.FlatAppearance.BorderSize = 0;
            this.btnRolld100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRolld100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolld100.ForeColor = System.Drawing.Color.LightGray;
            this.btnRolld100.Image = global::DiceRoller_Randomizer.Properties.Resources._100d;
            this.btnRolld100.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld100.Location = new System.Drawing.Point(0, 240);
            this.btnRolld100.Name = "btnRolld100";
            this.btnRolld100.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRolld100.Size = new System.Drawing.Size(229, 40);
            this.btnRolld100.TabIndex = 6;
            this.btnRolld100.Text = "        Roll d100 dice";
            this.btnRolld100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld100.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolld100.UseVisualStyleBackColor = true;
            this.btnRolld100.Click += new System.EventHandler(this.btnRolld100_Click);
            // 
            // btnRolld20
            // 
            this.btnRolld20.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRolld20.FlatAppearance.BorderSize = 0;
            this.btnRolld20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRolld20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolld20.ForeColor = System.Drawing.Color.LightGray;
            this.btnRolld20.Image = global::DiceRoller_Randomizer.Properties.Resources.d20;
            this.btnRolld20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld20.Location = new System.Drawing.Point(0, 200);
            this.btnRolld20.Name = "btnRolld20";
            this.btnRolld20.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRolld20.Size = new System.Drawing.Size(229, 40);
            this.btnRolld20.TabIndex = 5;
            this.btnRolld20.Text = "        Roll d20 dice";
            this.btnRolld20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolld20.UseVisualStyleBackColor = true;
            this.btnRolld20.Click += new System.EventHandler(this.btnRolld20_Click);
            // 
            // btnRolld12
            // 
            this.btnRolld12.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRolld12.FlatAppearance.BorderSize = 0;
            this.btnRolld12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRolld12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolld12.ForeColor = System.Drawing.Color.LightGray;
            this.btnRolld12.Image = global::DiceRoller_Randomizer.Properties.Resources.d12;
            this.btnRolld12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld12.Location = new System.Drawing.Point(0, 160);
            this.btnRolld12.Name = "btnRolld12";
            this.btnRolld12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRolld12.Size = new System.Drawing.Size(229, 40);
            this.btnRolld12.TabIndex = 4;
            this.btnRolld12.Text = "        Roll d12 dice";
            this.btnRolld12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolld12.UseVisualStyleBackColor = true;
            this.btnRolld12.Click += new System.EventHandler(this.btnRolld12_Click);
            // 
            // btnRolld10
            // 
            this.btnRolld10.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRolld10.FlatAppearance.BorderSize = 0;
            this.btnRolld10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRolld10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolld10.ForeColor = System.Drawing.Color.LightGray;
            this.btnRolld10.Image = global::DiceRoller_Randomizer.Properties.Resources.d10;
            this.btnRolld10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld10.Location = new System.Drawing.Point(0, 120);
            this.btnRolld10.Name = "btnRolld10";
            this.btnRolld10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRolld10.Size = new System.Drawing.Size(229, 40);
            this.btnRolld10.TabIndex = 3;
            this.btnRolld10.Text = "        Roll d10 dice";
            this.btnRolld10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolld10.UseVisualStyleBackColor = true;
            this.btnRolld10.Click += new System.EventHandler(this.btnRolld10_Click);
            // 
            // btnRolld8
            // 
            this.btnRolld8.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRolld8.FlatAppearance.BorderSize = 0;
            this.btnRolld8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRolld8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolld8.ForeColor = System.Drawing.Color.LightGray;
            this.btnRolld8.Image = global::DiceRoller_Randomizer.Properties.Resources.d8;
            this.btnRolld8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld8.Location = new System.Drawing.Point(0, 80);
            this.btnRolld8.Name = "btnRolld8";
            this.btnRolld8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRolld8.Size = new System.Drawing.Size(229, 40);
            this.btnRolld8.TabIndex = 2;
            this.btnRolld8.Text = "         Roll d8 dice";
            this.btnRolld8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolld8.UseVisualStyleBackColor = true;
            this.btnRolld8.Click += new System.EventHandler(this.btnRolld8_Click);
            // 
            // btnRolld6
            // 
            this.btnRolld6.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRolld6.FlatAppearance.BorderSize = 0;
            this.btnRolld6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRolld6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolld6.ForeColor = System.Drawing.Color.LightGray;
            this.btnRolld6.Image = global::DiceRoller_Randomizer.Properties.Resources.d6;
            this.btnRolld6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld6.Location = new System.Drawing.Point(0, 40);
            this.btnRolld6.Name = "btnRolld6";
            this.btnRolld6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRolld6.Size = new System.Drawing.Size(229, 40);
            this.btnRolld6.TabIndex = 1;
            this.btnRolld6.Text = "        Roll d6 dice";
            this.btnRolld6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolld6.UseVisualStyleBackColor = true;
            this.btnRolld6.Click += new System.EventHandler(this.btnRolld6_Click);
            // 
            // btnRolld4
            // 
            this.btnRolld4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRolld4.FlatAppearance.BorderSize = 0;
            this.btnRolld4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRolld4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolld4.ForeColor = System.Drawing.Color.LightGray;
            this.btnRolld4.Image = global::DiceRoller_Randomizer.Properties.Resources.d4;
            this.btnRolld4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld4.Location = new System.Drawing.Point(0, 0);
            this.btnRolld4.Name = "btnRolld4";
            this.btnRolld4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRolld4.Size = new System.Drawing.Size(229, 40);
            this.btnRolld4.TabIndex = 0;
            this.btnRolld4.Text = "        Roll d4 dice";
            this.btnRolld4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolld4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolld4.UseVisualStyleBackColor = true;
            this.btnRolld4.Click += new System.EventHandler(this.btnRolld4_Click);
            // 
            // btnDndDices
            // 
            this.btnDndDices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDndDices.FlatAppearance.BorderSize = 0;
            this.btnDndDices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDndDices.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDndDices.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDndDices.Image = global::DiceRoller_Randomizer.Properties.Resources.DnD;
            this.btnDndDices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDndDices.Location = new System.Drawing.Point(0, 100);
            this.btnDndDices.Name = "btnDndDices";
            this.btnDndDices.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDndDices.Size = new System.Drawing.Size(229, 45);
            this.btnDndDices.TabIndex = 2;
            this.btnDndDices.Text = "   DnD Dices";
            this.btnDndDices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDndDices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDndDices.UseVisualStyleBackColor = true;
            this.btnDndDices.Click += new System.EventHandler(this.btnDndDices_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::DiceRoller_Randomizer.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(638, 508);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(32, 32);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Roller - Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelDnDDicesSubMenu.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelCreateSubMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDndDices;
        private System.Windows.Forms.Panel panelDnDDicesSubMenu;
        private System.Windows.Forms.Button btnRolld100;
        private System.Windows.Forms.Button btnRolld20;
        private System.Windows.Forms.Button btnRolld12;
        private System.Windows.Forms.Button btnRolld10;
        private System.Windows.Forms.Button btnRolld8;
        private System.Windows.Forms.Button btnRolld6;
        private System.Windows.Forms.Button btnRolld4;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelCreateSubMenu;
        private System.Windows.Forms.Button btnGenerateNumber;
        private System.Windows.Forms.Button BtnRandomizer;
        private System.Windows.Forms.Button btnRollBasicDice;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInfo;
    }
}

