using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LebronButton_Click(object sender, EventArgs e)
        {
            string firstName = "Lebron James";
            int number = 23;
            outputLabel.Text = firstName + " is the number " + number;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //the area of a circle is pi x radius x radius
            string piName = "Pi";
            string radiusName = "Radius";
            string areaName = "Area";
            outputLabel.Text = 
            
        }
    }
}
