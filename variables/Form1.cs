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
            outputLabel.Text = areaName + " = " + piName + " x " + radiusName + " x " + radiusName;
            double area = 2 * 2 * 3.14;

            outputLabel.Text += "\n";
            outputLabel.Text += "\n the area of a circle with the radius of 2 is " + area;
            


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number1 = 8.5;
            int number2 = 6;
            int number3 = 51;
            int number4 = 2;

            double money1 = 19.95;
            double money2 = 1017.45;

            outputLabel.Text = " The area of a room with the dimensions " + number1 + " x " + number2 + " is " + number3 + " ^ " + number4;
            outputLabel.Text += "\n";
            outputLabel.Text += "\n";
            outputLabel.Text += " The cost to carpet this area at " + money1 + " per square metre is " + money2.ToString("C");
                
                
                


        }
    }
}
