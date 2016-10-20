using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloUser
{
    public partial class frmHelloUser2 : Form
    {
        public frmHelloUser2()
        {
            InitializeComponent();
        }

        /**

 *

 * Name: Jack Fendley

 * Teacher: Mr. Hardman

 * Assignment #2, Program #1

 * Date Last Modified: October 20th, 2016

 *
 */

        private void btnDisplay_Click_Click(object sender, EventArgs e)
        {
            int myNumber = 55;

            bool myBoolean = true;

            char mycharacter = '?';

            lblDisplay.Text = myNumber.ToString() +
                "\n" + "Bill Murray" +
                "\n" + "Movies" +
                "\n" + myBoolean.ToString() + mycharacter.ToString();
        }

        private void btnDisplay_Click2_Click(object sender, EventArgs e)
        {
            const double PST_RATE = 0.08;
            const double GST_RATE = 0.05;

            double coffeePrice = 1.80;
            int numCoffees;
            double subtotal;
            double taxes;
            double finalTotal;

            numCoffees = Convert.ToInt32(txtCoffeeInput.Text);
            subtotal = numCoffees * coffeePrice;
            taxes = subtotal * (PST_RATE + GST_RATE);
            finalTotal = subtotal + taxes;

            lblDisplay3.Text += "\n\n" + "PST is " + PST_RATE;
            lblDisplay3.Text += "\n" + "GST is " + GST_RATE;
            lblDisplay3.Text += "\n" + "Coffee costs $" + coffeePrice;
            lblDisplay3.Text += "\n" + "Your total is $" + finalTotal;
        }

        private void btnDisplay_Click3_Click(object sender, EventArgs e)
        {
            string myString = "Bill Murray";

            lblDisplay.Text += "\n" + myString.Substring(0, 4);
            lblDisplay.Text += "\n" + myString.Substring(4);

            lblDisplay.Text += "\n" + "Age: ";
            lblDisplay.Text += +myString.IndexOf('u');
            lblDisplay.Text += +myString.IndexOf('u');
            lblDisplay.Text += "\n" + "Movies: ";
            lblDisplay.Text += +myString.IndexOf('M');
            lblDisplay.Text += +myString.IndexOf('M');
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Yo what's up my homeslice?";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double FirstNum = Convert.ToDouble(txtFirstNum.Text);
            double SecondNum = Convert.ToDouble(txtSecondNum.Text);

            double sum = FirstNum + SecondNum;
            double difference = FirstNum - SecondNum;
            double product = FirstNum * SecondNum;
            double quotient = FirstNum / SecondNum;
            double mod = FirstNum % SecondNum;

            double absOfFirst = Math.Abs(FirstNum);
            double absOfSecond = Math.Abs(SecondNum);
            double power = Math.Pow(FirstNum, SecondNum);
            double root = Math.Pow(SecondNum, 1 / FirstNum);

            lblDisplay2.Text = "Your sum is: " + sum;
            lblDisplay2.Text += "\nYour difference is: " + difference;
            lblDisplay2.Text += "\nYour product is: " + product;
            lblDisplay2.Text += "\nYour quotient is: " + quotient;
            lblDisplay2.Text += "\nYour modulus is: " + mod;
            lblDisplay2.Text += "\nYour power is: " + power;
            lblDisplay2.Text += "\nYour root is: " + root;
            lblDisplay2.Text += "\nThe absolute value of the first number is: " + absOfFirst;
            lblDisplay2.Text += "\nThe absolute value of the second number is: " + absOfSecond;
        }

        private void lblCoffeeQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
