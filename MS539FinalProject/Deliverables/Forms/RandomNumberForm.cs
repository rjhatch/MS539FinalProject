using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539FinalProject.Deliverables.Forms
{
    public partial class RandomNumberForm : Form
    {
        int count;

        public RandomNumberForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            //Attempt to convert the entered value to an int. If not, display an error.
            if(!int.TryParse(tbRandomNumberCount.Text, out count))
            {
                MessageBox.Show("Please enter a number!");
            }


            //If the user enters a number greater than 1000, display error.
            if (count > 1000)
            {
                MessageBox.Show("Please enter a number less than or equal to 1000!");
                return;
            }

            //Create new RandomNumbers class with the count.
            RandomNumbers randomNumbers = new RandomNumbers(count);

            rtbNumbers.Text = randomNumbers.NumberList;

            //If the user has checked the box to save the data to a file, save it to a file.
            if (cbSaveRandomNumbers.Checked)
            {
                //Try to write to the file. If not, display an error.
                try
                {
                    File.WriteAllText("Numbers.txt", randomNumbers.NumberList);
                    MessageBox.Show("File saved!");
                }
                catch
                {
                    MessageBox.Show("There was a problem saving the file!");
                }
            }
        }
    }
}
