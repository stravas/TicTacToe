namespace TicTacToe_2._0
{
    partial class SpielStatistikBS
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Spieler1Label = new System.Windows.Forms.Label();
            this.Spieler2Label = new System.Windows.Forms.Label();
            this.PunkteLabelSpieler1 = new System.Windows.Forms.Label();
            this.PunkteLabelSpieler2 = new System.Windows.Forms.Label();
            this.RundenLabel = new System.Windows.Forms.Label();
            this.Runde = new System.Windows.Forms.Label();
            this.PunkteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Spieler1Label
            // 
            this.Spieler1Label.AutoSize = true;
            this.Spieler1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spieler1Label.Location = new System.Drawing.Point(15, 45);
            this.Spieler1Label.Name = "Spieler1Label";
            this.Spieler1Label.Size = new System.Drawing.Size(67, 20);
            this.Spieler1Label.TabIndex = 0;
            this.Spieler1Label.Text = "Spieler1";
            // 
            // Spieler2Label
            // 
            this.Spieler2Label.AutoSize = true;
            this.Spieler2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spieler2Label.Location = new System.Drawing.Point(15, 86);
            this.Spieler2Label.Name = "Spieler2Label";
            this.Spieler2Label.Size = new System.Drawing.Size(67, 20);
            this.Spieler2Label.TabIndex = 1;
            this.Spieler2Label.Text = "Spieler2";
            // 
            // PunkteLabelSpieler1
            // 
            this.PunkteLabelSpieler1.AutoSize = true;
            this.PunkteLabelSpieler1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunkteLabelSpieler1.Location = new System.Drawing.Point(128, 38);
            this.PunkteLabelSpieler1.Name = "PunkteLabelSpieler1";
            this.PunkteLabelSpieler1.Size = new System.Drawing.Size(58, 29);
            this.PunkteLabelSpieler1.TabIndex = 2;
            this.PunkteLabelSpieler1.Text = "PS1";
            // 
            // PunkteLabelSpieler2
            // 
            this.PunkteLabelSpieler2.AutoSize = true;
            this.PunkteLabelSpieler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunkteLabelSpieler2.Location = new System.Drawing.Point(128, 79);
            this.PunkteLabelSpieler2.Name = "PunkteLabelSpieler2";
            this.PunkteLabelSpieler2.Size = new System.Drawing.Size(58, 29);
            this.PunkteLabelSpieler2.TabIndex = 3;
            this.PunkteLabelSpieler2.Text = "PS2";
            // 
            // RundenLabel
            // 
            this.RundenLabel.AutoSize = true;
            this.RundenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RundenLabel.Location = new System.Drawing.Point(128, 143);
            this.RundenLabel.Name = "RundenLabel";
            this.RundenLabel.Size = new System.Drawing.Size(45, 29);
            this.RundenLabel.TabIndex = 4;
            this.RundenLabel.Text = "RA";
            // 
            // Runde
            // 
            this.Runde.AutoSize = true;
            this.Runde.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Runde.Location = new System.Drawing.Point(15, 151);
            this.Runde.Name = "Runde";
            this.Runde.Size = new System.Drawing.Size(59, 19);
            this.Runde.TabIndex = 5;
            this.Runde.Text = "Runde:";
            // 
            // PunkteLabel
            // 
            this.PunkteLabel.AutoSize = true;
            this.PunkteLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunkteLabel.Location = new System.Drawing.Point(119, 9);
            this.PunkteLabel.Name = "PunkteLabel";
            this.PunkteLabel.Size = new System.Drawing.Size(42, 13);
            this.PunkteLabel.TabIndex = 6;
            this.PunkteLabel.Text = "Punkte";
            // 
            // SpielStatistikBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PunkteLabel);
            this.Controls.Add(this.Runde);
            this.Controls.Add(this.RundenLabel);
            this.Controls.Add(this.PunkteLabelSpieler2);
            this.Controls.Add(this.PunkteLabelSpieler1);
            this.Controls.Add(this.Spieler2Label);
            this.Controls.Add(this.Spieler1Label);
            this.Name = "SpielStatistikBS";
            this.Size = new System.Drawing.Size(189, 205);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Spieler1Label;
        private System.Windows.Forms.Label Spieler2Label;
        private System.Windows.Forms.Label PunkteLabelSpieler1;
        private System.Windows.Forms.Label PunkteLabelSpieler2;
        private System.Windows.Forms.Label RundenLabel;
        private System.Windows.Forms.Label Runde;
        private System.Windows.Forms.Label PunkteLabel;
    }
}
