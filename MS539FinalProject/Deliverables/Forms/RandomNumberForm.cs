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
            int.TryParse(tbRandomNumberCount.Text, out count);

            if (count > 1000)
            {
                tbRandomNumberCount.Text = "1000";
                count = 1000;
            }

            RandomNumbers randomNumbers = new RandomNumbers(count);

            rtbNumbers.Text = randomNumbers.NumberList;

            if (cbSaveRandomNumbers.Checked)
            {
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
