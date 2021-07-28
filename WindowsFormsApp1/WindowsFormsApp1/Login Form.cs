using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Movies";
        }

     

        private void SignupButton_Click(object sender, EventArgs e)
        {
             gunaTransition1.Hide(LoginPnl);
           

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           

            gunaTransition1.Show(LoginPnl);
            

        }

        
    }
}
