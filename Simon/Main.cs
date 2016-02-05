using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simon
{
    public partial class Main : Form
    {
        int GameState = 1;
        List<int> SimonSays = new List<int>();
        int LastClickIndex = 0;
        int Score = 0;
        int CurrentIndex = 0;
        Random myrandomgen = new Random();

        public Main()
        {
            InitializeComponent();
        }

        void ResetGame()
        {
            GameState = 4;
            timerAssign.Enabled = false;
            buttonStart.Enabled = false;
            LastClickIndex = 0;
            CurrentIndex = 0;
            buttonStart.Text = "Start Game";
            UpdateScore(0);
            Console.WriteLine("Loss!");
            SimonSays.Clear();
            SetColor("All", "0");
            timerRead.Enabled = true;
        }

        void SetColor(string Color, string Sound)
        {
            Console.WriteLine(Color);
            pictureBoxGame.Image = (Image)Simon.Properties.Resources.ResourceManager.GetObject(Color + "_Simon");
        }

        int RandomGenerator()
        {
            return myrandomgen.Next(0, 4);
        }

        void AssignRead()
        {
            CurrentIndex = 0;
            SimonSays.Add(RandomGenerator());
            Console.WriteLine("Colors:");
            timerAssign.Enabled = true;
        }

        void UpdateScore(int NewScore)
        {
            Score = NewScore;
            labelScore.Text = "Score: " + Score.ToString();
        }

        void CheckResponse(int id)
        {
            if (SimonSays.Count > 0)
            {
                if (SimonSays.ElementAt(LastClickIndex) == id)
                {
                    LastClickIndex++;
                    if (LastClickIndex == SimonSays.Count)
                    {
                        LastClickIndex = 0;
                        UpdateScore(Score + 1);
                        Console.WriteLine("Win!");
                        GameState = 2;
                        AssignRead();
                    }
                }
                else
                {
                    ResetGame();
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (GameState == 1)
            {
                GameState = 2;
                buttonStart.Text = "Stop Game";
                AssignRead();
            }
            else if (GameState == 4)
            {
            }
            else
            {
                ResetGame();
            }
        }

        private void timerAssign_Tick(object sender, EventArgs e)
        {
            pictureBoxGame.Image = Simon.Properties.Resources.Simon;
            if (CurrentIndex == SimonSays.Count)
            {
                pictureBoxGame.Image = Simon.Properties.Resources.Simon;
                CurrentIndex = 0;
                timerAssign.Enabled = false;
                GameState = 3;
            }
            else
            {
                switch (SimonSays.ElementAt(CurrentIndex))
                {
                    case 0:
                        SetColor("Green", "0");
                        break;
                    case 1:
                        SetColor("Red", "0");
                        break;
                    case 2:
                        SetColor("Yellow", "0");
                        break;
                    case 3:
                        SetColor("Blue", "0");
                        break;
                }
                CurrentIndex++;
            }
        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            pictureBoxGame.Image = Simon.Properties.Resources.Simon;
            GameState = 1;
            buttonStart.Enabled = true;
            timerRead.Enabled = false;
        }

        private void pictureBoxGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameState == 3)
            {
                timerRead.Enabled = false;
                pictureBoxGame.Image = Simon.Properties.Resources.Simon;
                Point relativePoint = this.PointToClient(Cursor.Position);
                Console.WriteLine(relativePoint.ToString());
                if (relativePoint.X >= 15 && relativePoint.X < 90) //either green or blue
                {
                    Console.WriteLine("either green or blue");
                    if (relativePoint.Y >= 41 && relativePoint.Y < 116) //green
                    {
                        SetColor("Green", "0");
                        CheckResponse(0);
                    }
                    else if (relativePoint.Y >= 116 && relativePoint.Y <= 191) //blue
                    {
                        SetColor("Blue", "0");
                        CheckResponse(3);
                    }
                }
                else if (relativePoint.X >= 90 && relativePoint.X <= 165) //either red or yellow
                {
                    Console.WriteLine("either red or yellow");
                    if (relativePoint.Y >= 41 && relativePoint.Y < 116) //red
                    {
                        SetColor("Red", "0");
                        CheckResponse(1);
                    }
                    else if (relativePoint.Y >= 116 && relativePoint.Y <= 191) //yellow
                    {
                        SetColor("Yellow", "0");
                        CheckResponse(2);
                    }
                }
            }
        }

        private void pictureBoxGame_MouseUp(object sender, MouseEventArgs e)
        {
            if (!(GameState == 4))
            {
                pictureBoxGame.Image = Simon.Properties.Resources.Simon;
            }
        }
    }
}
