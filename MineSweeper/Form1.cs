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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int dif;
            int siz;
            if (false == string.IsNullOrEmpty(txBoxUserName.Text))
            {
                if (int.TryParse(txBoxSize.Text, out siz) && int.TryParse(txBoxDifficulty.Text, out dif))
                {
                    if (dif > 21)
                    {
                        MessageBox.Show("Difficuly has to be las than 21");
                    }
                    else
                    {
                        if (dif > siz)
                        {
                            MessageBox.Show("difficulty has to be less than size");
                        }
                        else
                        {
                            Form2 frm2 = new Form2();
                            frm2.comeFromForm1 = this;
                            frm2.userName = txBoxUserName.Text;
                            frm2.size = siz;
                            frm2.difficulty = dif;
                            frm2.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(" Enter a Number ");
                }
            }
            else
            {
                MessageBox.Show("You has to enter a Player Name");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(340, 400);
            this.MinimumSize = new Size(340, 400);
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.MaximumSize = new Size(700, 550);
            this.MinimumSize = new Size(700, 550);
            StreamReader sr = new StreamReader("scores.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + line;
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
