using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeSpeed
{
    public partial class Form1 : Form
    {
        private const int BEGIN_GAME_TIMER = 1000, END_GAME_TIMER = 100, STEP_GAME = 20;
        private int Total = 0;
        private int Missed = 0;
        private int Correct = 0;
        private int Accuracy = 0;
        private int difLevel = 0;
        private int TimerNumber = BEGIN_GAME_TIMER;
        private Boolean GameStatus = false;

        public Form1()
        {
            InitializeComponent();
            TimerSpeed.Enabled = false;
            updateScreen();
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void TimerSpeed_Tick(object sender, EventArgs e)
        {
            char rletter = generateCharacter();
            ChatacterTextbox.AppendText(Convert.ToString(rletter));
        }
        private char generateCharacter()
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');
            return randomChar;
        }
        private Boolean deleteCharacter(ref string sample, Char dchar)
        {
            Boolean ret = false;
            if (sample.IndexOf(dchar) != -1)
            {
                sample = sample.Remove(sample.IndexOf(dchar), 1);
                ret = true;
            }
            return ret;
        }
        private void updateScreen()
        {
            TotalValueLabel.Text = Convert.ToString(Total);
            CorrectValueLabel.Text = Convert.ToString(Correct);
            MissValueLabel.Text = Convert.ToString(Missed);
            AccuracyValueLabel.Text = Convert.ToString(Accuracy) + "%";
            DifficutyValueLabel.Value = difLevel;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char dchar = e.KeyChar;
            string textGame = ChatacterTextbox.Text;
            Boolean ret = deleteCharacter(ref textGame, dchar);
            if (ret)
            {
                Correct += 1;
                ChatacterTextbox.Text = textGame;
                if (TimerNumber > END_GAME_TIMER)
                {
                    TimerNumber -= STEP_GAME;
                    TimerSpeed.Interval = TimerNumber;
                    difLevel = ((BEGIN_GAME_TIMER - TimerNumber) * 100 / (BEGIN_GAME_TIMER - END_GAME_TIMER));
                }
            }
            else
            {
                Missed += 1;
            }
            try 
            {
                Accuracy = (Correct * 100 / (Missed + Correct));
            }
            catch (DivideByZeroException)
            {
                Accuracy = 100;
            }

            updateScreen();
        }

        private void ChatacterTextbox_TextChanged(object sender, EventArgs e)
        {
            Total = ChatacterTextbox.Text.Length;
            if (Total > 20)
            {
                GameStatus = false;
                startButton.Enabled = true;
                gameOverLabel.Visible = true;
                TimerSpeed.Enabled = false;
            }
            updateScreen();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!GameStatus)
            {
                GameStatus = true;
                ChatacterTextbox.Clear();
                TimerSpeed.Interval = BEGIN_GAME_TIMER;
                TimerSpeed.Enabled = true;
                gameOverLabel.Visible = false;
                //startButton.Enabled = false;
                Total = 0;
                Missed = 0;
                Correct = 0;
                Accuracy = 0;
                difLevel = 0;
    }
        }
    }
}
