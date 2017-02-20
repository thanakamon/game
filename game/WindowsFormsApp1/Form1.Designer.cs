namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.onGameTimer = new System.Windows.Forms.Timer(this.components);
            this.offGameTimer = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.gmover2 = new System.Windows.Forms.Label();
            this.gmover1 = new System.Windows.Forms.Label();
            this.highpoints = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.cactus2 = new System.Windows.Forms.PictureBox();
            this.dino = new System.Windows.Forms.PictureBox();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cactus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            this.SuspendLayout();
            // 
            // onGameTimer
            // 
            this.onGameTimer.Interval = 3;
            this.onGameTimer.Tick += new System.EventHandler(this.onGameTimer_Tick);
            // 
            // offGameTimer
            // 
            this.offGameTimer.Enabled = true;
            this.offGameTimer.Interval = 1;
            this.offGameTimer.Tick += new System.EventHandler(this.offGameTimer_Tick);
            // 
            // screen
            // 
            this.screen.AccessibleName = " ";
            this.screen.BackColor = System.Drawing.Color.White;
            this.screen.Controls.Add(this.gmover2);
            this.screen.Controls.Add(this.gmover1);
            this.screen.Controls.Add(this.highpoints);
            this.screen.Controls.Add(this.highscore);
            this.screen.Controls.Add(this.points);
            this.screen.Controls.Add(this.score);
            this.screen.Controls.Add(this.cactus2);
            this.screen.Controls.Add(this.dino);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1064, 261);
            this.screen.TabIndex = 1;
            // 
            // gmover2
            // 
            this.gmover2.AutoSize = true;
            this.gmover2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gmover2.Location = new System.Drawing.Point(439, 113);
            this.gmover2.Name = "gmover2";
            this.gmover2.Size = new System.Drawing.Size(163, 20);
            this.gmover2.TabIndex = 8;
            this.gmover2.Text = "press space to restart";
            this.gmover2.Visible = false;
            // 
            // gmover1
            // 
            this.gmover1.AutoSize = true;
            this.gmover1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gmover1.Location = new System.Drawing.Point(415, 71);
            this.gmover1.Name = "gmover1";
            this.gmover1.Size = new System.Drawing.Size(210, 42);
            this.gmover1.TabIndex = 7;
            this.gmover1.Text = "Game Over";
            this.gmover1.Visible = false;
            // 
            // highpoints
            // 
            this.highpoints.AutoSize = true;
            this.highpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highpoints.Location = new System.Drawing.Point(307, 9);
            this.highpoints.Name = "highpoints";
            this.highpoints.Size = new System.Drawing.Size(26, 29);
            this.highpoints.TabIndex = 6;
            this.highpoints.Text = "0";
            this.highpoints.Visible = false;
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highscore.Location = new System.Drawing.Point(166, 9);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(135, 29);
            this.highscore.TabIndex = 5;
            this.highscore.Text = "High score:";
            this.highscore.Visible = false;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.points.Location = new System.Drawing.Point(101, 9);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(26, 29);
            this.points.TabIndex = 4;
            this.points.Text = "0";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(83, 29);
            this.score.TabIndex = 3;
            this.score.Text = "Score:";
            // 
            // cactus2
            // 
            this.cactus2.BackColor = System.Drawing.Color.Green;
            this.cactus2.Location = new System.Drawing.Point(1664, 401);
            this.cactus2.Name = "cactus2";
            this.cactus2.Size = new System.Drawing.Size(35, 60);
            this.cactus2.TabIndex = 2;
            this.cactus2.TabStop = false;
            // 
            // dino
            // 
            this.dino.Image = global::WindowsFormsApp1.Properties.Resources.dino;
            this.dino.Location = new System.Drawing.Point(50, 151);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(45, 60);
            this.dino.TabIndex = 0;
            this.dino.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 261);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-Rex Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cactus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer onGameTimer;
        private System.Windows.Forms.Timer offGameTimer;
        private System.Windows.Forms.PictureBox current;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.PictureBox next2;
        private System.Windows.Forms.PictureBox dino;
        private System.Windows.Forms.PictureBox cactus2;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label highpoints;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Label gmover2;
        private System.Windows.Forms.Label gmover1;
    }
}

