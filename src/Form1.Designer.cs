namespace flappy_sharp
{
    partial class GameForm
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.lblPipeSpeed = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(13, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(69, 21);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("MV Boli", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(246, 204);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(393, 77);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.AutoSize = true;
            this.lblPlayAgain.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.Location = new System.Drawing.Point(381, 291);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(132, 32);
            this.lblPlayAgain.TabIndex = 6;
            this.lblPlayAgain.Text = "Play Again";
            this.lblPlayAgain.Visible = false;
            this.lblPlayAgain.Click += new System.EventHandler(this.lblPlayAgain_Click);
            // 
            // lblPipeSpeed
            // 
            this.lblPipeSpeed.AutoSize = true;
            this.lblPipeSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPipeSpeed.Location = new System.Drawing.Point(12, 38);
            this.lblPipeSpeed.Name = "lblPipeSpeed";
            this.lblPipeSpeed.Size = new System.Drawing.Size(74, 21);
            this.lblPipeSpeed.TabIndex = 7;
            this.lblPipeSpeed.Text = "Speed:";
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::flappy_sharp.Properties.Resources.blue_bird1;
            this.bird.Location = new System.Drawing.Point(107, 228);
            this.bird.Margin = new System.Windows.Forms.Padding(4);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(60, 53);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Image = global::flappy_sharp.Properties.Resources.ground1;
            this.ground.Location = new System.Drawing.Point(0, 676);
            this.ground.Margin = new System.Windows.Forms.Padding(4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(848, 62);
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::flappy_sharp.Properties.Resources.pipe_top;
            this.pipeTop.Location = new System.Drawing.Point(716, 0);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(4);
            this.pipeTop.MaximumSize = new System.Drawing.Size(123, 281);
            this.pipeTop.MinimumSize = new System.Drawing.Size(123, 126);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(123, 248);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::flappy_sharp.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(716, 398);
            this.pipeBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pipeBottom.MaximumSize = new System.Drawing.Size(123, 289);
            this.pipeBottom.MinimumSize = new System.Drawing.Size(123, 130);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(123, 289);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 738);
            this.Controls.Add(this.lblPipeSpeed);
            this.Controls.Add(this.lblPlayAgain);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Flappy Sharp";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblPlayAgain;
        private System.Windows.Forms.Label lblPipeSpeed;
    }
}

