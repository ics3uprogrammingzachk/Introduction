using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldIntZachK
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

   

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello, World!";
        }

        private void radGerman_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hallo Welt!";
        }

        private void grbLanguages_Enter(object sender, EventArgs e)
        {

        }

        private void radPortuguese_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radLatin_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
