using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment5
{
    public partial class inClassAssignment5 : Form
    {
        public inClassAssignment5()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to calculate pi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //==================================
            //        Declare variable
            //==================================

            int numLoops;
            double valueOfPi = 0;
            double demCount = 1;
            bool odd = false;
            bool even = false;

            //==================================
            //  Get # of Loops from text box
            //==================================
            numLoops = Convert.ToInt32(txtEnterTerm.Text);
            //Insert try/catch

            //==================================
            //        Create for Loop
            //==================================
            for (int x = 1; x <= numLoops; x++)
            {
                //==================================
                //  Test if loop is odd or even 
                //==================================
                if (x % 2 == 0)
                {
                    even = true;
                    odd = false;
                }else
                {
                    odd = true;
                    even = false; 
                }

                //Is counter odd or even
                if (odd)
                {
                    valueOfPi += 4 / demCount; 
                }else
                {
                    valueOfPi -= 4 / demCount; 
                }

                demCount += 2; 
            }
            lblValueAfterPi.Text = ("Approximate value of Pi after " + txtEnterTerm.Text + " terms");
            lblCalculation.Text = ("=" + valueOfPi); 
        }

        private void lblEnterTerm_Click(object sender, EventArgs e)
        {

        }
    }
}
