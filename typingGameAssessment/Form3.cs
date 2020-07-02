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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e) //returns the user back to the menu form.
        {
            Form1 menuTab = new Form1();
            Hide();
            menuTab.ShowDialog();
            Close();
        }
    }
}
