using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typingGameAssessment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBoxTypedWord.KeyDown += textBoxTypedWord_KeyDown; // idk how this thing works lmao 

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = ""; 
        }

        Random random = new Random();
        double wordsTyped = 0; // variable for recording the number of words type
        
        int keyStrokeCounter = 0; // variable for counting the amount of keystrokes the user performs while typing
        string[] inputWord = { "red", "blue", "black", "white", "grey", "pink", "purple", "yellow", "orange", "green", "indigo", "violet", "brown"};

        private void textBoxTypedWord_KeyDown(object sender, KeyEventArgs e)
        {
            keyStrokeCounter += 1;
            labelKeyStrokes.Text = Convert.ToString(keyStrokeCounter);
            if (e.KeyCode == Keys.Space)
            {                
                if (textBoxTypedWord.Text == label2.Text) // these two if statements check whether the user has typed the correct word or not
                {
                    labelChecker.Text = "Correct"; 
                    labelChecker.BackColor = Color.Green;                    
                }
                
                if (textBoxTypedWord.Text != label2.Text) //see above
                {
                    labelChecker.Text = "Incorrect";
                    labelChecker.BackColor = Color.Red;
                }
                string typedWord = (textBoxTypedWord.Text); //stores the word typed as a variable and clears the text
                textBoxTypedWord.Clear();
                labelOutput.Text += typedWord;
                int randNum = random.Next(inputWord.Length);
                label2.Text = inputWord[randNum];
                wordsTyped = wordsTyped + 1; //adds one to the number of words typed

                //executeNewWord += 1;
            }            
            if (e.KeyCode == Keys.Enter)
            {
                timerGame.Enabled = false;
                MessageBox.Show("You are done, returning to menu", "Announcement");               
                Form1 menuTab = new Form1();
                Hide();
                menuTab.ShowDialog();
                Close();
            }
            if (textBoxTypedWord.Text == " ")
            {
                textBoxTypedWord.Text = "";
            }
        }        

        double recordTime = 0; //Variable used for recording the time
        double recordSeconds;
        double recordMinutes;
        double recordLabelTime = 1;
        private void timerGame_Tick(object sender, EventArgs e) //After each tick (1 second), the program calculates the WPM by dividing the time by words typed
        {          
            recordTime = recordTime + 1;
            if (recordSeconds < 60)
            {
                recordSeconds += 1;
            }            
            if (recordSeconds > 59)
            {
                recordSeconds = 0;
                recordMinutes += 1;                
            }
            if (recordTime == (2 * recordLabelTime))
            {
                /*
                Label word1 = new Label();
                word1.Location = new Point(400,200);
                word1.Text = "EEEE";
                Controls.Add(word1);
                */

                string wordName = "word" + Convert.ToString(2 * recordLabelTime);
                int randPoint1 = random.Next(530) + 166;
                int randPoint2 = random.Next(370) + 40;
                Label word1 = new Label();
                word1.Location = new Point(randPoint1, randPoint2);
                word1.Text = "EEEE";
                word1.BackColor = Color.Crimson;
                word1.AutoSize = true;
                Controls.Add(word1);
                recordLabelTime += 1;
                Controls.SetChildIndex(word1, 0);

                /*
                if (recordTime == 11)
                {
                    word1.Text = "HHHH";
                }
                */
                //Words wordProperties = new Words("GGGG", 50, 60, 20);
                
            }
            labelSeconds.Text = Convert.ToString(recordSeconds) + " Seconds";
            labelMinutes.Text = Convert.ToString(recordMinutes) + " Minutes";
            double WPM = 60*(wordsTyped / recordTime);
            labelWPM.Text = Convert.ToString(Math.Round(WPM,1)); //Displays the WPM on a form with rounded numbers
        }
        private void timerFallSpeed_Tick(object sender, EventArgs e)
        {
            

        }

        private void buttonTest_Click(object sender, EventArgs e) //temporary button method for enabling the timer
        {
            timerGame.Enabled = true;
        }

        private void CreateWordLabel(Label wordLabelName, string labelName, int x, int y)
        {
            wordLabelName = new Label();
            wordLabelName.Text = labelName;
            wordLabelName.Location = new Point(x, y);
                  
        }
    }
}
