using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        double scorePoints = 0;
        int highPoints = 0;
        bool jump;
        bool jumpPressed;
        bool crawling;
        int gravity = 15;
        int acceleration;
        int jumpTime;
        Random r = new Random();
        int obstacleSpeed = 8;
        bool isGone;
        PictureBox[] obstacles = new PictureBox[3];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            SpawnCactus();
            SpawnCactus();
            SpawnCactus();
            obstacles[1].Left += r.Next(400, 700);
            obstacles[2].Left += r.Next(400, 700);
            current = obstacles[0];
            next = obstacles[1];
            next2 = obstacles[2];
            MaximizeBox = false;
            MinimizeBox = false;

        }

        private void onGameTimer_Tick(object sender, EventArgs e)
        {
            if(IsColliding(dino, current))
            {
                onGameTimer.Stop();
                offGameTimer.Start();

                gmover1.Visible = true;
                gmover2.Visible = true;
            }








            ChangeCurrent();

            current.Left -= obstacleSpeed;

            if (screen.Right - current.Right > 500)
            {
                next.Left -= obstacleSpeed;
            }
            if (screen.Right - next.Right > 500)
            {
                next2.Left -= obstacleSpeed;
            }
            scorePoints += 1;
            if(scorePoints % 300 == 0)
            {
                obstacleSpeed++;
            }
            points.Text = Convert.ToInt32(scorePoints).ToString();

            if(crawling)
            {
                dino.Top = screen.Bottom + 25;
            }


            if (jump)
            {
                if(jumpPressed)
                {
                    if(jumpTime < 9)
                    {
                        dino.Top -= acceleration;
                        jumpTime++;
                    }
                    else
                    {
                        jumpPressed = false;
                    }
                }
                else
                {
                    dino.Top -= acceleration;
                    acceleration--;
                }
                
            }
            
            if(dino.Top + dino.Height >= screen.Height && !crawling)
            {
                dino.Top = screen.Height - dino.Height;
                jump = false;
            }
            else
            {
                if (crawling)
                {
                    dino.Top = screen.Height - dino.Height + 25;
                }
                else
                {
                    dino.Top += 6;
                }
            }

            if (IsColliding(dino, current))
            {
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (onGameTimer.Enabled == true)
            {
                if (e.KeyCode == Keys.Space && jump != true)
                {
                    jump = true;
                    jumpPressed = true;
                    acceleration = gravity;
                    jumpTime = 0;
                }
            }
            else
            {
                if(e.KeyCode == Keys.Space)
                {
                    onGameTimer.Enabled = true;
                    offGameTimer.Enabled = false;
                    ResetGame();
                }
            }
            if(e.KeyCode == Keys.Down && !jump && onGameTimer.Enabled && !crawling)
            {
                crawling = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                jumpPressed = false;
            }
            if(e.KeyCode == Keys.Down)
            {
                crawling = false;
            }
        }

        private void offGameTimer_Tick(object sender, EventArgs e)
        {
        }


        private bool IsColliding(PictureBox dino, PictureBox cactus)
        {
            if (((dino.Left >= cactus.Left && dino.Left <= cactus.Right)||(dino.Right >= cactus.Left && dino.Right <= cactus.Right)) && ((dino.Top >= cactus.Top && dino.Top <= cactus.Bottom)||(dino.Bottom >= cactus.Top && dino.Bottom <= cactus.Bottom)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ChangeCurrent()
        {
            isGone = current.Right <= screen.Left ? true : false;
            if (isGone)
            {
                if (current == obstacles[0])
                {
                    current = obstacles[1];
                    next = obstacles[2];
                    next2 = obstacles[0];
                    RemoveObstacle(obstacles[0]);
                    Spawn();
                }
                else
                {
                    if (current == obstacles[1])
                    {
                        current = obstacles[2];
                        next = obstacles[0];
                        next2 = obstacles[1];
                        RemoveObstacle(obstacles[1]);
                        Spawn();
                    }
                    else
                    {
                        current = obstacles[0];
                        next = obstacles[1];
                        next2 = obstacles[2];
                        RemoveObstacle(obstacles[2]);
                        Spawn();
                    }
                }
            }
        }
        private void SpawnCactus()
        {
            obstacles[i] = new PictureBox { Size = new Size(35, 60), Location = new Point(screen.Right + r.Next(0, 300), 201), Image = global::WindowsFormsApp1.Properties.Resources.cactus, BackColor = Color.Transparent };
            obstacles[i].Parent = screen;
            if(i == 2)
            {
                i = 0;
            }
            else
            {
                i++;
            }
        }
        private void SpawnBirdMiddle()
        {
            obstacles[i] = new PictureBox { Size = new Size(65,40), Location = new Point(screen.Right + r.Next(0, 300), 180), Image = global::WindowsFormsApp1.Properties.Resources.ptero };
            obstacles[i].Parent = screen;
            if (i == 2)
            {
                i = 0;
            }
            else
            {
                i++;
            }
        }
        private void SpawnBirdTop()
        {
            obstacles[i] = new PictureBox { Size = new Size(65, 40), Location = new Point(screen.Right + r.Next(0, 300), 145), Image = global::WindowsFormsApp1.Properties.Resources.ptero };
            obstacles[i].Parent = screen;
            if (i == 2)
            {
                i = 0;
            }
            else
            {
                i++;
            }
        }
        
        private void RemoveObstacle(PictureBox p)
        {
            Controls.Remove(p);
            p.Dispose();
        }

        private void Spawn()
        {
            if(r.Next(1, 4) % 3 == 0)
            {
                if(r.Next(1, 4) % 3 == 0)
                {
                    SpawnBirdTop();
                }
                else
                {
                    SpawnBirdMiddle();
                }
            }
            else
            {
                SpawnCactus();
            }
        }

        private void ResetGame()
        {
            RemoveObstacle(obstacles[0]);
            RemoveObstacle(obstacles[1]);
            RemoveObstacle(obstacles[2]);
            i = 0;
            SpawnCactus();
            SpawnCactus();
            SpawnCactus();
            obstacles[1].Left += r.Next(400, 700);
            obstacles[2].Left += r.Next(1100, 1300);
            current = obstacles[0];
            next = obstacles[1];
            next2 = obstacles[2];
            if(scorePoints > highPoints)
            {
                highPoints = (int)scorePoints;
                highpoints.Text = Convert.ToString((int)scorePoints);
            }
            scorePoints = 0;
            if(highPoints > 0)
            {
                highpoints.Visible = true;
                highscore.Visible = true;
            }
            gmover1.Visible = false;
            gmover2.Visible = false;
            obstacleSpeed = 8;
        }


    }
}
