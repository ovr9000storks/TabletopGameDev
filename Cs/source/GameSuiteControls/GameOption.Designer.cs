namespace GameSuiteControls
{
    partial class GameOption
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameLabel = new System.Windows.Forms.Label();
            this.StatsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameLabel
            // 
            this.GameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.GameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GameLabel.Location = new System.Drawing.Point(0, 0);
            this.GameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(200, 75);
            this.GameLabel.TabIndex = 0;
            this.GameLabel.Text = "<game_name>";
            this.GameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatsLabel
            // 
            this.StatsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.StatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StatsLabel.Location = new System.Drawing.Point(0, 250);
            this.StatsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StatsLabel.Name = "StatsLabel";
            this.StatsLabel.Size = new System.Drawing.Size(200, 50);
            this.StatsLabel.TabIndex = 1;
            this.StatsLabel.Text = "Highscore: 0\r\nTime played: 0m";
            this.StatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.StatsLabel);
            this.Controls.Add(this.GameLabel);
            this.Name = "GameOption";
            this.Size = new System.Drawing.Size(200, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.Label StatsLabel;
    }
}
