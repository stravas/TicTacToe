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
            this.SuspendLayout();
            // 
            // Spieler1Label
            // 
            this.Spieler1Label.AutoSize = true;
            this.Spieler1Label.Location = new System.Drawing.Point(3, 19);
            this.Spieler1Label.Name = "Spieler1Label";
            this.Spieler1Label.Size = new System.Drawing.Size(45, 13);
            this.Spieler1Label.TabIndex = 0;
            this.Spieler1Label.Text = "Spieler1";
            // 
            // Spieler2Label
            // 
            this.Spieler2Label.AutoSize = true;
            this.Spieler2Label.Location = new System.Drawing.Point(99, 19);
            this.Spieler2Label.Name = "Spieler2Label";
            this.Spieler2Label.Size = new System.Drawing.Size(45, 13);
            this.Spieler2Label.TabIndex = 1;
            this.Spieler2Label.Text = "Spieler2";
            // 
            // PunkteLabelSpieler1
            // 
            this.PunkteLabelSpieler1.AutoSize = true;
            this.PunkteLabelSpieler1.Location = new System.Drawing.Point(3, 93);
            this.PunkteLabelSpieler1.Name = "PunkteLabelSpieler1";
            this.PunkteLabelSpieler1.Size = new System.Drawing.Size(79, 13);
            this.PunkteLabelSpieler1.TabIndex = 2;
            this.PunkteLabelSpieler1.Text = "PunkteSpieler1";
            // 
            // PunkteLabelSpieler2
            // 
            this.PunkteLabelSpieler2.AutoSize = true;
            this.PunkteLabelSpieler2.Location = new System.Drawing.Point(99, 93);
            this.PunkteLabelSpieler2.Name = "PunkteLabelSpieler2";
            this.PunkteLabelSpieler2.Size = new System.Drawing.Size(79, 13);
            this.PunkteLabelSpieler2.TabIndex = 3;
            this.PunkteLabelSpieler2.Text = "PunkteSpieler2";
            // 
            // RundenLabel
            // 
            this.RundenLabel.AutoSize = true;
            this.RundenLabel.Location = new System.Drawing.Point(54, 151);
            this.RundenLabel.Name = "RundenLabel";
            this.RundenLabel.Size = new System.Drawing.Size(77, 13);
            this.RundenLabel.TabIndex = 4;
            this.RundenLabel.Text = "RundenAnzahl";
            // 
            // SpielStatistikBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
    }
}
