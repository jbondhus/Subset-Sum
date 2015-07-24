using System;
using System.Collections.Generic;
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
            List<int> values = new List<int>();

            int tmp;

            foreach (string line in this.Values.Lines)
            {
                if (!Int32.TryParse(line, out tmp))
                {
                    MessageBox.Show("Value '" + line + "' is not a valid number!");
                    return;
                }
                else if (line.Length != 0)
                {
                    values.Add(Int32.Parse(line));
                }

            }

            int desiredResult;
            if (!Int32.TryParse(this.DesiredResult.Text, out desiredResult))
            {
                MessageBox.Show("Desired result of '" + this.DesiredResult.Text + "' is not a valid number!");
            }

            List<List<int>> results = SubsetSum.findSubsets(desiredResult, values.ToArray());

            foreach (List<int> result in results)
            {
                this.Results.AppendText("[");
                int i = 1;
                foreach (int item in result)
                {
                    this.Results.AppendText(item.ToString());
                    if (i < result.Count)
                    {
                        this.Results.AppendText(", ");
                    }
                    i++;
                }
                this.Results.AppendText("] = " + desiredResult.ToString() + System.Environment.NewLine);
                this.Refresh();
            }
        }
    }
}
