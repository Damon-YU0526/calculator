using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathmatics
{
    public partial class Mathmatics : Form
    {
        private int firstNumber;
        private int secondNumber;
        private int thirdNumber;
        private int answer;
        private int correctTime;
        private int totalTime;
        public Mathmatics()
        {
            InitializeComponent();

            // init totalTime and correctTime
           TotalTime = 0;
            CorrectTime = 0;

            // reset quesetion
            ResetQuestion();
        }

        // all setter methods rewrite for sync Label/Pic control

        public int FirstNumber
        {
            get { return firstNumber; }
            set
            {
                firstNumber = value;
                firstLabel.Text = firstNumber.ToString();
                firstPictureBox.Image = ImageWithNumber(firstNumber);
            }
        }
        public int SecondNumber
        {
            get { return secondNumber; }
            set
            {
                secondNumber = value;
                secondLabel.Text = secondNumber.ToString();
                secondPictureBox.Image = ImageWithNumber(secondNumber);
            }
        }

        public int ThirdNumber
        {
            get { return thirdNumber; }
            set
            {
                thirdNumber = value;
                thirdLabel.Text = thirdNumber.ToString();
                thirdPictureBox.Image = ImageWithNumber(thirdNumber);
            }
        }

        // get correct answer
        public int Answer
        {
            get
            {
                return firstNumber + secondNumber * thirdNumber;
            }
            set
            {
                answer = value;
                answerLabel.Text = answer.ToString();
            }
        }

        public int CorrectTime
        {
            get { return correctTime; }
            set
            {
                correctTime = value;
                correctTimeLabel.Text = correctTime.ToString();
            }
        }
        public int TotalTime
        {
            get { return totalTime; }
            set
            {
                totalTime = value;
                totalTimeLabel.Text = totalTime.ToString();
            }
        }

        // get image
        public Image ImageWithNumber(int number)
        {
            return (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(number.ToString(), Properties.Resources.Culture);
        }

        // reset question
        public void ResetQuestion()
        {
            Random random = new Random();
            FirstNumber = random.Next(1, 10);
            SecondNumber = random.Next(1, 10);
            ThirdNumber = random.Next(1, 10);

            textBox.Text = "";
            answerLabel.Text = "?";
        }

        private void makeQuestionBtn_Click(object sender, EventArgs e)
        {
            ResetQuestion();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            // empty not allow
            if (text == null || text == "")
            {
                MessageBox.Show("input your answer");
                return;
            }

            int inputAnswer = 0;
            bool isCorrectParse = int.TryParse(text, out inputAnswer);
            if(isCorrectParse)
            {
                // check answer
                if (inputAnswer == Answer)
                {
                    CorrectTime += 1;
                    Answer = inputAnswer;
                } else
                {
                    
                }
            }
            TotalTime += 1;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only number can input
            if(!Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
