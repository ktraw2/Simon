namespace Simon
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.timerAssign = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(93, 17);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(47, 13);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "Score: 0";
            // 
            // timerAssign
            // 
            this.timerAssign.Interval = 750;
            this.timerAssign.Tick += new System.EventHandler(this.timerAssign_Tick);
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.Image = global::Simon.Properties.Resources.Simon;
            this.pictureBoxGame.Location = new System.Drawing.Point(15, 41);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxGame.TabIndex = 6;
            this.pictureBoxGame.TabStop = false;
            this.pictureBoxGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGame_MouseDown);
            this.pictureBoxGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGame_MouseUp);
            // 
            // timerRead
            // 
            this.timerRead.Interval = 1000;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 207);
            this.Controls.Add(this.pictureBoxGame);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerAssign;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.Timer timerRead;
    }
}

