using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subset_Sum
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Process_Click(object sender, EventArgs e)
        {
            List<double> values = new List<double>();

            double tmp;

            int i = 0;
            foreach (string line in this.Values.Lines)
            {
                if (!Double.TryParse(line, out tmp))
                {
                    MessageBox.Show("Value '" + line + "' is not a valid number!");
                    return;
                }
                else if (line.Length != 0)
                {
                    values.Add(Double.Parse(line));
                }

            }

            SubsetSum sum = new SubsetSum(values);

            double desiredResult;
            if (!Double.TryParse(this.DesiredResult.Text, out desiredResult))
            {
                MessageBox.Show("Desired result of '" + this.DesiredResult.Text + "' is not a valid number!");
            }

            sum.getPossibilities(desiredResult);
        }
    }
}
