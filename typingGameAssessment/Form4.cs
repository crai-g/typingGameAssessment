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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e) //returns the user back to the menu form
        {
            Form1 menuTab = new Form1();
            Hide();
            menuTab.ShowDialog();
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e) 
        {
            
            if (textPassword == textConfirmPassword)
            {
                string newUser = textUsername.Text;
                string newPassword = textPassword.Text;
                Form2 gameTab = new Form2(); //sends user to game form.
                Hide();
                gameTab.ShowDialog();
                Close();
            }
            if (textPassword != textConfirmPassword)
            {                
                MessageBox.Show("Your passwords do not match, please try again", "Non-matching passwords");
                //textUsername.Clear();
                textPassword.Clear();
                textConfirmPassword.Clear();
            }           
        }
    }
}
