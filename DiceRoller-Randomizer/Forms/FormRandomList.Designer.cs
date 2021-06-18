namespace DiceRoller_Randomizer.Forms
{
    partial class FormRandomList
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
            this.lblSides = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tbInputSide = new System.Windows.Forms.TextBox();
            this.btnAddSide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSides
            // 
            this.lblSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSides.ForeColor = System.Drawing.Color.White;
            this.lblSides.Location = new System.Drawing.Point(12, 50);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(640, 91);
            this.lblSides.TabIndex = 0;
            this.lblSides.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sides";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelBottom.Controls.Add(this.lblSides);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 356);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(664, 150);
            this.panelBottom.TabIndex = 17;
            // 
            // tbInputSide
            // 
            this.tbInputSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbInputSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbInputSide.Location = new System.Drawing.Point(17, 262);
            this.tbInputSide.Name = "tbInputSide";
            this.tbInputSide.Size = new System.Drawing.Size(140, 30);
            this.tbInputSide.TabIndex = 19;
            // 
            // btnAddSide
            // 
            this.btnAddSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSide.Location = new System.Drawing.Point(17, 305);
            this.btnAddSide.Name = "btnAddSide";
            this.btnAddSide.Size = new System.Drawing.Size(140, 33);
            this.btnAddSide.TabIndex = 18;
            this.btnAddSide.Text = "Add Side";
            this.btnAddSide.UseVisualStyleBackColor = true;
            this.btnAddSide.Click += new System.EventHandler(this.btnAddSide_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 47);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add Words";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.Image = global::DiceRoller_Randomizer.Properties.Resources.multiply_28px;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReset.Location = new System.Drawing.Point(236, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(192, 50);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoll.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRoll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoll.ForeColor = System.Drawing.Color.White;
            this.btnRoll.Image = global::DiceRoller_Randomizer.Properties.Resources.reset_28px;
            this.btnRoll.Location = new System.Drawing.Point(236, 244);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(192, 50);
            this.btnRoll.TabIndex = 15;
            this.btnRoll.Text = "Roll again";
            this.btnRoll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DiceRoller_Randomizer.Properties.Resources.multiply_28px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormRandomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.btnAddSide);
            this.Controls.Add(this.tbInputSide);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBottom);
            this.Name = "FormRandomList";
            this.Text = "FormRandomList";
            this.Load += new System.EventHandler(this.FormRandomList_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox tbInputSide;
        private System.Windows.Forms.Button btnAddSide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}