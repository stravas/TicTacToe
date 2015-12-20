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
            this.Spieler1TextBox = new System.Windows.Forms.TextBox();
            this.Spieler2TextBox = new System.Windows.Forms.TextBox();
            this.SpielStartenButton = new System.Windows.Forms.Button();
            this.startPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultatPanel = new System.Windows.Forms.Panel();
            this.neueRunde = new System.Windows.Forms.Button();
            this.resultatLabel = new System.Windows.Forms.Label();
            this.menueLeiste = new System.Windows.Forms.MenuStrip();
            this.dateiMenueLeiste = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielerZugAnzeige = new System.Windows.Forms.Label();
            this.hintergrundPanel = new System.Windows.Forms.Panel();
            this.startPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.resultatPanel.SuspendLayout();
            this.menueLeiste.SuspendLayout();
            this.hintergrundPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // Spieler1TextBox
            //
            this.Spieler1TextBox.Location = new System.Drawing.Point(139, 286);
            this.Spieler1TextBox.Name = "Spieler1TextBox";
            this.Spieler1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Spieler1TextBox.TabIndex = 0;
            //
            // Spieler2TextBox
            //
            this.Spieler2TextBox.Location = new System.Drawing.Point(314, 286);
            this.Spieler2TextBox.Name = "Spieler2TextBox";
            this.Spieler2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Spieler2TextBox.TabIndex = 1;
            this.Spieler2TextBox.TextChanged += new System.EventHandler(this.verhinderSelbenNamen);
            //
            // SpielStartenButton
            //
            this.SpielStartenButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.SpielStartenButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SpielStartenButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpielStartenButton.Location = new System.Drawing.Point(190, 337);
            this.SpielStartenButton.Name = "SpielStartenButton";
            this.SpielStartenButton.Size = new System.Drawing.Size(180, 60);
            this.SpielStartenButton.TabIndex = 2;
            this.SpielStartenButton.Text = "Spiel Starten";
            this.SpielStartenButton.UseVisualStyleBackColor = false;
            this.SpielStartenButton.Click += new System.EventHandler(this.SpielStartButtonClick);
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
            this.startPanel.Controls.Add(this.SpielStartenButton);
            this.startPanel.Controls.Add(this.Spieler2TextBox);
            this.startPanel.Controls.Add(this.Spieler1TextBox);
            this.startPanel.Location = new System.Drawing.Point(0, 24);
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
            // resultatPanel
            //
            this.resultatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.resultatPanel.Controls.Add(this.neueRunde);
            this.resultatPanel.Controls.Add(this.resultatLabel);
            this.resultatPanel.Location = new System.Drawing.Point(54, 51);
            this.resultatPanel.Name = "resultatPanel";
            this.resultatPanel.Size = new System.Drawing.Size(534, 488);
            this.resultatPanel.TabIndex = 8;
            this.resultatPanel.Visible = false;
            //
            // neueRunde
            //
            this.neueRunde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.neueRunde.Location = new System.Drawing.Point(218, 205);
            this.neueRunde.Name = "neueRunde";
            this.neueRunde.Size = new System.Drawing.Size(150, 60);
            this.neueRunde.TabIndex = 1;
            this.neueRunde.Text = "Neue Runde";
            this.neueRunde.UseVisualStyleBackColor = true;
            this.neueRunde.Click += new System.EventHandler(this.NeueRundeButtonKlick);
            //
            // resultatLabel
            //
            this.resultatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resultatLabel.AutoSize = true;
            this.resultatLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatLabel.Location = new System.Drawing.Point(20, 11);
            this.resultatLabel.Name = "resultatLabel";
            this.resultatLabel.Size = new System.Drawing.Size(123, 25);
            this.resultatLabel.TabIndex = 0;
            this.resultatLabel.Text = "Spielergebnis";
            //
            // menueLeiste
            //
            this.menueLeiste.BackColor = System.Drawing.Color.Silver;
            this.menueLeiste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiMenueLeiste,
            this.aboutMenuItem});
            this.menueLeiste.Location = new System.Drawing.Point(0, 0);
            this.menueLeiste.Name = "menueLeiste";
            this.menueLeiste.Size = new System.Drawing.Size(534, 24);
            this.menueLeiste.TabIndex = 1;
            this.menueLeiste.Text = "menuStrip1";
            //
            // dateiMenueLeiste
            //
            this.dateiMenueLeiste.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielMenuItem,
            this.beendenMenuItem});
            this.dateiMenueLeiste.Name = "dateiMenueLeiste";
            this.dateiMenueLeiste.Size = new System.Drawing.Size(46, 20);
            this.dateiMenueLeiste.Text = "Datei";
            //
            // neuesSpielMenuItem
            //
            this.neuesSpielMenuItem.Name = "neuesSpielMenuItem";
            this.neuesSpielMenuItem.Size = new System.Drawing.Size(135, 22);
            this.neuesSpielMenuItem.Text = "Neues Spiel";
            this.neuesSpielMenuItem.Click += new System.EventHandler(this.neuesSpielMenueLeisteKlick);
            //
            // beendenMenuItem
            //
            this.beendenMenuItem.Name = "beendenMenuItem";
            this.beendenMenuItem.Size = new System.Drawing.Size(135, 22);
            this.beendenMenuItem.Text = "Beenden";
            this.beendenMenuItem.Click += new System.EventHandler(this.beenden_MenueLeiste_Klick);
            //
            // aboutMenuItem
            //
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutMenuItem.Text = "About";
            //
            // spielerZugAnzeige
            //
            this.spielerZugAnzeige.AutoSize = true;
            this.spielerZugAnzeige.Dock = System.Windows.Forms.DockStyle.Right;
            this.spielerZugAnzeige.Font = new System.Drawing.Font("Impact", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spielerZugAnzeige.Location = new System.Drawing.Point(484, 24);
            this.spielerZugAnzeige.Name = "spielerZugAnzeige";
            this.spielerZugAnzeige.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.spielerZugAnzeige.Size = new System.Drawing.Size(50, 25);
            this.spielerZugAnzeige.TabIndex = 2;
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
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(534, 512);
            this.Controls.Add(this.resultatPanel);
            this.Controls.Add(this.spielerZugAnzeige);
            this.Controls.Add(this.menueLeiste);
            this.Controls.Add(this.hintergrundPanel);
            this.MainMenuStrip = this.menueLeiste;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.FormLoad);
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.resultatPanel.ResumeLayout(false);
            this.resultatPanel.PerformLayout();
            this.menueLeiste.ResumeLayout(false);
            this.menueLeiste.PerformLayout();
            this.hintergrundPanel.ResumeLayout(false);
            this.hintergrundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button SpielStartenButton;
        private System.Windows.Forms.TextBox Spieler2TextBox;
        private System.Windows.Forms.TextBox Spieler1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menueLeiste;
        private System.Windows.Forms.ToolStripMenuItem dateiMenueLeiste;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Label spielerZugAnzeige;
        private System.Windows.Forms.Panel hintergrundPanel;
        private System.Windows.Forms.Panel resultatPanel;
        private System.Windows.Forms.Label resultatLabel;
        private System.Windows.Forms.Button neueRunde;
    }
}

