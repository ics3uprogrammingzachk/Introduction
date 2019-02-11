/*
 * Created by: Zachary Kranabetter
 * Created on: 11-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Perimeter, Area, Volume
 * This is a program that has 3 buttons and when I click on each button it calculates the perimeter of a rectangle the area of a circle and the volume of a sphere.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolZachK
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }
        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = Convert.ToString(6 + 6 + 2 + 2);
        }
        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            lblAnswer2.Text = Convert.ToString(Math.Pow(4,2)*Math.PI);
        }

        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            lblAnswer3.Text = Convert.ToString(((double)4/(double)3) * Math.PI * (Math.Pow(6,3)));
        }

        private void frmPerAreaVol_Load(object sender, EventArgs e)
        {

        }
    }
}
