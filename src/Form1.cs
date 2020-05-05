using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_sharp
{
    public partial class GameForm : Form
    {
        const int gravitySeed = 8;
        const int defaultPipeSpeed = 5;
        int pipeSpeed = 5;
        int gravity = 6;
        int score = 0;
        Timer gameTimer = new Timer();


        int birdStartPosition;
        int topPipeStartPosition;
        int bottomPipeStartPosition;



        public GameForm()
        {
            InitializeComponent();

            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Interval = 20;
            gameTimer.Start();

            birdStartPosition = bird.Top;
            topPipeStartPosition = pipeTop.Left;
            bottomPipeStartPosition = pipeBottom.Left;
        }

        Random rd = new Random();
        int scoreAccumulator = 0;
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            CheckPipes();

            //CheckCollision();
        }

        private void IncrementScore()
        {
            score++;
            lblScore.Text = $"Score: {score}";
            scoreAccumulator = 0;

            var factor = score / defaultPipeSpeed;

            if (factor > 0)
                pipeSpeed = factor * 5;

            lblPipeSpeed.Text = $"Speed: {pipeSpeed}";
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -gravitySeed;
            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = gravitySeed;
            }
        }

        private void CheckCollision()
        {
            if (bird.Bounds.IntersectsWith(pipeBottom.Bounds)
               || bird.Bounds.IntersectsWith(pipeTop.Bounds)
               || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();
            }
        }

        private void CheckPipes()
        {
            CheckBottomPipe();
            CheckTopPipe();

        }

        private void CheckTopPipe()
        {
            if (pipeTop.Left < -80)
            {
                pipeTop.Left = rd.Next(537, 1100);
                scoreAccumulator++;
            }

            if (scoreAccumulator >= 2)
                IncrementScore();
        }
        private void CheckBottomPipe()
        {
            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 716;
                scoreAccumulator++;
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            lblGameOver.Visible = true;
            lblPlayAgain.Visible = true;
        }

        private void lblPlayAgain_Click(object sender, EventArgs e)
        {
            score = 0;
            bird.Top = birdStartPosition;
            pipeTop.Left = topPipeStartPosition;
            pipeBottom.Left = bottomPipeStartPosition;
            pipeSpeed = defaultPipeSpeed;

            pipeBottom.Size = new Size(123, 166);
            pipeTop.Size = new Size(123, 166);

            lblGameOver.Visible = false;
            lblPlayAgain.Visible = false;

            gameTimer.Start();
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameTimer.Enabled)
                gameTimer.Stop();
            else
                gameTimer.Start();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine($"TopPipe Left: {pipeTop.Left}");
        }
    }
}
