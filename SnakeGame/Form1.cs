using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        #region Definitions
        private List<Point> Snake = new List<Point>();
        private Random RDPoint = new Random();
        private int Score = 0, MoveX, MoveY;
        private Point Food = new Point();
        private bool Pause = true;
        private int highScore = 0;
        #endregion

        #region Init
        public Form1()
        {
            InitializeComponent();
            InitializeConf();
            LoadHighScore();
            InitGame();
        }

        private void InitializeConf()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            TMRGame.Tick += (sender, e) => Update(sender, e);
            PBGame.Paint += (sender, e) => PBGame_Paint(sender, e);

            string[] Difficulty = { "Fácil", "Médio", "Difícil" };
            foreach (string s in Difficulty)
            {
                CBDiff.Items.Add(s);
            }
            CBDiff.SelectedIndex = 0;

            string[] Mode = { "Clássico", "Novo" };
            foreach (string s in Mode)
            {
                CBModo.Items.Add(s);
            }
            CBModo.SelectedIndex = 0;
        }
        #endregion

        #region Game
        private void InitGame()
        {
            Snake.Clear();
            Snake.Add(new Point(10, 10));
            MoveX = 1;
            MoveY = 0;
            Score = 0;
            LBLPontuação.Text = "Score: " + Score.ToString();

            GenerateFood();
            ChangeDiff();
        }

        private void Update(object sender, EventArgs e)
        {
            ChangeDiff();

            for (int i = 1; i < Snake.Count; i++)
                if (Snake[i].Equals(Snake[0])) FinishGame();

            if (Snake[0].Equals(Food))
            {
                Score++;
                LBLPontuação.Text = "Score: " + Score.ToString();
                Snake.Add(new Point());
                GenerateFood();
            }

            if (CBModo.SelectedItem.ToString() == "Clássico")
            {
                if (Snake[0].X < 0 || Snake[0].Y < 0 || Snake[0].X >= PBGame.Width / 10 || Snake[0].Y >= PBGame.Height / 10)
                    FinishGame();
            }
            else
            {
                if (Snake[0].X < 0) Snake[0] = new Point(PBGame.Width / 10 - 1, Snake[0].Y);
                else if (Snake[0].X >= PBGame.Width / 10) Snake[0] = new Point(0, Snake[0].Y);
                else if (Snake[0].Y < 0) Snake[0] = new Point(Snake[0].X, PBGame.Height / 10 - 1);
                else if (Snake[0].Y >= PBGame.Height / 10) Snake[0] = new Point(Snake[0].X, 0);
            }

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                    Snake[i] = new Point(Snake[i].X + MoveX, Snake[i].Y + MoveY);
                else
                    Snake[i] = Snake[i - 1];
            }
            PBGame.Invalidate();
        }

        private void ChangeDiff()
        {
            switch (CBDiff.SelectedItem.ToString())
            {
                case "Fácil":
                    TMRGame.Interval = 200;
                    break;
                case "Médio":
                    TMRGame.Interval = 100;
                    break;
                case "Difícil":
                    TMRGame.Interval = 50;
                    break;
            }
        }

        private void GenerateFood()
        {
            Food = new Point(RDPoint.Next(PBGame.Width / 10), RDPoint.Next(PBGame.Height / 10));
        }

        private void FinishGame()
        {
            if (Score > highScore)
            {
                highScore = Score;
                SaveHighScore(); // Salva o novo recorde
            }
            TMRGame.Stop();
            Pause = true;
            CBDiff.Enabled = true;
            CBModo.Enabled = true;
            BTStartPause.Text = "Start";
            MessageBox.Show("Game Over");
            InitGame();
        }
        #endregion

        #region Event
        private void BTStartPause_Click(object sender, EventArgs e)
        {
            if (Pause)
            {
                Pause = false;
                BTStartPause.Text = "Pause";
                TMRGame.Start();
            }
            else
            {
                Pause = true;
                BTStartPause.Text = "Start";
                TMRGame.Stop();
            }

            CBDiff.Enabled = Pause;
            CBModo.Enabled = Pause;
        }

        private void PBGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            for (int i = 0; i < Snake.Count; i++)
                canvas.FillRectangle(Brushes.Green, new Rectangle(Snake[i].X * 10, Snake[i].Y * 10, 10, 10));

            canvas.FillRectangle(Brushes.Orange, new Rectangle(Food.X * 10, Food.Y * 10, 10, 10));
        }
        #endregion

        #region Move
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!Pause)
            {
                switch (keyData)
                {
                    case Keys.Up:
                    case Keys.W:
                        if (MoveY != 1)
                        {
                            MoveX = 0; 
                            MoveY = -1;
                        }
                        break;
                    case Keys.Down:
                    case Keys.S:
                        if (MoveY != -1)
                        {
                            MoveX = 0; 
                            MoveY = 1;
                        }
                        break;
                    case Keys.Left:
                    case Keys.A:
                        if (MoveX != 1)
                        {
                            MoveX = -1; 
                            MoveY = 0;
                        }
                        break;
                    case Keys.Right:
                    case Keys.D:
                        if (MoveX != -1)
                        {
                            MoveX = 1; 
                            MoveY = 0;
                        }
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region HighScore
        private void LoadHighScore()
        {
            try
            {
                if (File.Exists("highscore.txt"))
                {
                    string scoreText = File.ReadAllText("highscore.txt");
                    if (int.TryParse(scoreText, out int savedHighScore))
                    {
                        highScore = savedHighScore;
                        UpdateHighScoreLabel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o recorde: " + ex.Message);
            }
        }

        private void SaveHighScore()
        {
            try
            {
                File.WriteAllText("highscore.txt", highScore.ToString());
                UpdateHighScoreLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o recorde: " + ex.Message);
            }
        }

        private void UpdateHighScoreLabel()
        {
            LBLHighScore.Text = "High Score: " + highScore.ToString();
        }
        #endregion
    }
}
