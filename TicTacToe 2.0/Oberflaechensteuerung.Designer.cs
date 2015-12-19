namespace TicTacToe_2._0
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.startPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.momentanerSpieler = new System.Windows.Forms.Label();
            this.hintergrundPanel = new System.Windows.Forms.Panel();
            this.resultatPanel = new System.Windows.Forms.Panel();
            this.neueRunde = new System.Windows.Forms.Button();
            this.resultatLabel = new System.Windows.Forms.Label();
            this.startPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.hintergrundPanel.SuspendLayout();
            this.resultatPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(139, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            //
            // textBox2
            //
            this.textBox2.Location = new System.Drawing.Point(314, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            //
            // button1
            //
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spiel Starten";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.spielStart_button1_Click);
            //
            // startPanel
            //
            this.startPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.startPanel.AutoSize = true;
            this.startPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.startPanel.Controls.Add(this.pictureBox3);
            this.startPanel.Controls.Add(this.pictureBox2);
            this.startPanel.Controls.Add(this.pictureBox1);
            this.startPanel.Controls.Add(this.label2);
            this.startPanel.Controls.Add(this.label1);
            this.startPanel.Controls.Add(this.button1);
            this.startPanel.Controls.Add(this.textBox2);
            this.startPanel.Controls.Add(this.textBox1);
            this.startPanel.Location = new System.Drawing.Point(3, 27);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1023, 791);
            this.startPanel.TabIndex = 0;
            //
            // pictureBox3
            //
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::TicTacToe_2._0.Properties.Resources.Spieler2;
            this.pictureBox3.Location = new System.Drawing.Point(314, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 90);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            //
            // pictureBox2
            //
            this.pictureBox2.Image = global::TicTacToe_2._0.Properties.Resources.Spieler1;
            this.pictureBox2.Location = new System.Drawing.Point(139, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 90);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            //
            // pictureBox1
            //
            this.pictureBox1.Image = global::TicTacToe_2._0.Properties.Resources.titlenbild21;
            this.pictureBox1.Location = new System.Drawing.Point(80, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Spieler2";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spieler 1";
            //
            // menuStrip1
            //
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            //
            // dateiToolStripMenuItem
            //
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            //
            // neuesSpielToolStripMenuItem
            //
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.neuesSpielToolStripMenuItem.Text = "Neues Spiel";
            this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.neuesSpiel_ToolStripMenuItem_Click);
            //
            // beendenToolStripMenuItem
            //
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beenden_ToolStripMenuItem_Click);
            //
            // aboutToolStripMenuItem
            //
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            //
            // momentanerSpieler
            //
            this.momentanerSpieler.AutoSize = true;
            this.momentanerSpieler.Dock = System.Windows.Forms.DockStyle.Right;
            this.momentanerSpieler.Font = new System.Drawing.Font("Impact", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.momentanerSpieler.Location = new System.Drawing.Point(484, 24);
            this.momentanerSpieler.Name = "momentanerSpieler";
            this.momentanerSpieler.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.momentanerSpieler.Size = new System.Drawing.Size(50, 25);
            this.momentanerSpieler.TabIndex = 2;
            //
            // hintergrundPanel
            //
            this.hintergrundPanel.Controls.Add(this.startPanel);
            this.hintergrundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hintergrundPanel.Location = new System.Drawing.Point(0, 0);
            this.hintergrundPanel.Name = "hintergrundPanel";
            this.hintergrundPanel.Size = new System.Drawing.Size(534, 512);
            this.hintergrundPanel.TabIndex = 8;
            //
            // resultatPanel
            //
            this.resultatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.resultatPanel.Controls.Add(this.neueRunde);
            this.resultatPanel.Controls.Add(this.resultatLabel);
            this.resultatPanel.Location = new System.Drawing.Point(0, 24);
            this.resultatPanel.Name = "resultatPanel";
            this.resultatPanel.Size = new System.Drawing.Size(484, 488);
            this.resultatPanel.TabIndex = 8;
            this.resultatPanel.Visible = false;
            //
            // neueRunde
            //
            this.neueRunde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.neueRunde.Location = new System.Drawing.Point(193, 205);
            this.neueRunde.Name = "neueRunde";
            this.neueRunde.Size = new System.Drawing.Size(150, 60);
            this.neueRunde.TabIndex = 1;
            this.neueRunde.Text = "Neue Runde";
            this.neueRunde.UseVisualStyleBackColor = true;
            this.neueRunde.Click += new System.EventHandler(this.neueRunde_Click);
            //
            // resultatLabel
            //
            this.resultatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resultatLabel.AutoSize = true;
            this.resultatLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatLabel.Location = new System.Drawing.Point(-5, 11);
            this.resultatLabel.Name = "resultatLabel";
            this.resultatLabel.Size = new System.Drawing.Size(63, 25);
            this.resultatLabel.TabIndex = 0;
            this.resultatLabel.Text = "label3";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(534, 512);
            this.Controls.Add(this.resultatPanel);
            this.Controls.Add(this.momentanerSpieler);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.hintergrundPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.FormLoad);
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.hintergrundPanel.ResumeLayout(false);
            this.hintergrundPanel.PerformLayout();
            this.resultatPanel.ResumeLayout(false);
            this.resultatPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label momentanerSpieler;
        private System.Windows.Forms.Panel hintergrundPanel;
        private System.Windows.Forms.Panel resultatPanel;
        private System.Windows.Forms.Label resultatLabel;
        private System.Windows.Forms.Button neueRunde;
    }
}

