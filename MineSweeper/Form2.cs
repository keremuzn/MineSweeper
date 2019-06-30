using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int score = 0;
        public string userName;
        public Form1 comeFromForm1;
        public int difficulty;
        public int size;
        int minesLocationLenght = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            // Table For MineSweeper
            int variable1 = size;
            string[,] mines = new string[variable1, variable1];
            this.MaximumSize = new Size(variable1 * 30 + 20, (variable1 + 1) * 30 + 50);
            this.MinimumSize = new Size(variable1 * 30 + 20, (variable1 + 1) * 30 + 50);
            int count = 1;
            int btnLeft = 5;
            int btnTop = 5;
            txtBoxScore.Text = userName + " Your Score : " + score.ToString();
            Random rnd = new Random();
            int[] minesNumber = new int[variable1 * difficulty];
            for (int i = 0; i < minesNumber.Length;)
            {
                int randomNumber = rnd.Next(0, variable1 * variable1);
                if (Array.IndexOf(minesNumber, randomNumber) != -1)
                {
                    continue;
                }
                minesNumber[i] = randomNumber;
                i++;
            }
            minesLocationLenght = minesNumber.Length;
            for (int i = 0; i < mines.GetLength(0); i++)
            {
                int random = rnd.Next(0, variable1);
                for (int x = 0; x < mines.GetLength(1); x++)
                {
                    Button btn = new Button();
                    if (Array.IndexOf(minesNumber, count) != -1)
                    {
                        btn.Text = " ";
                    }
                    else
                    {
                        //  This   gives number to squares without mines (depend degree of threat)
                        int riskCount = 0;
                        for (int z = 0; z < minesNumber.Length; z++)
                        {
                            int y = minesNumber[z];
                            if (count % variable1 == 1)
                            {
                                if (y == count + 1 || y == count - variable1 || y == count - variable1 + 1 || y == count + variable1 || y == count + variable1 + 1)
                                {
                                    riskCount++;
                                }
                                else { continue; }
                            }
                            else if (count % variable1 == 0)
                            {
                                if (y == count - 1 || y == count - variable1 || y == count - variable1 - 1 || y == count + variable1 || y == count + variable1 - 1)
                                {
                                    riskCount++;
                                }
                                else { continue; }
                            }
                            else if (y == count + 1 || y == count - 1 || y == count - variable1 || y == count - variable1 - 1 || y == count - variable1 + 1 || y == count + variable1 || y == count + variable1 + 1 || y == count + variable1 - 1)
                            {
                                riskCount++;
                            }
                        }
                        btn.Name = riskCount.ToString();
                    }
                    btn.BackColor = Color.Gray;
                    btn.Size = new Size(25, 25);
                    btn.Left = 0 + btnLeft;
                    btn.Top = 30 + btnTop;
                    btn.Click += new EventHandler(ButtonsInformations);
                    this.Controls.Add(btn);
                    btnLeft += 30;
                    if (count % variable1 == 0)
                    {
                        btnTop += 30;
                        btnLeft = 5;
                    }
                    count++;
                }
            }
        }
        void ButtonsInformations(object sender, EventArgs e)
        {
            Button x = sender as Button;
            if (x.Text == " ")
            {
                x.BackColor = Color.Red;
                MessageBox.Show("Mine!!! " + userName + "GAME OVER    Your Score : " + score.ToString());
                StreamWriter writer = File.AppendText("scores.txt");
                writer.WriteLine("Lose => " + userName + " Score : " + score + "  Date : " + DateTime.Now.ToLocalTime());
                writer.Close();
                this.Close();
            }
            else
            {
                score += difficulty;
                x.BackColor = Color.Green;
                txtBoxScore.Text = userName + " Your Score : " + score.ToString();
                if (x.Name == "1") { x.Text = "1"; }
                else if (x.Name == "2") { x.Text = "2"; }
                else if (x.Name == "3") { x.Text = "3"; }
                else if (x.Name == "4") { x.Text = "4"; }
                else if (x.Name == "5") { x.Text = "5"; }
                else if (x.Name == "6") { x.Text = "6"; }
                else if (x.Name == "7") { x.Text = "7"; }
                else if (x.Name == "8") { x.Text = "8"; }
                else if (x.Name == "0") { x.Text = "0"; }
            }
            if (score == (size * size) - (size * difficulty))
            {
                MessageBox.Show(" You Won !!! Your Score : " + (score + difficulty * size).ToString());
                StreamWriter writer = File.AppendText("scores.txt");
                writer.WriteLine("Win => " + userName + " Score : " + score + "  Date : " + DateTime.Now.ToLocalTime());
                writer.Close();
                // trying  for   make  mines' color  red when the game finish
                //for (int i = 0; i <minesLocationLenght ; i++)
                //{
                //    if (x.Name==" ")
                //    {
                //        x.BackColor = Color.Red;
                //    }
                //}
                //MessageBox.Show("Test");
                this.Close();
            }
        }
    }
}
