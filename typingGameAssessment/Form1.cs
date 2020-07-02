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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //opens up game form by going the guest route
        private void buttonGuest_Click(object sender, EventArgs e)
        {           
            Form2 gameTab = new Form2();
            Hide();
            gameTab.ShowDialog();
            Close();
        }
        // opens up create Account form 
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            Form4 createAccountTab = new Form4();
            Hide();
            createAccountTab.ShowDialog();
            Close();
        }
        //opens up login form
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form3 loginTab = new Form3();
            Hide();
            loginTab.ShowDialog();
            Close();
        }
    }
}
