namespace Subset_Sum
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Values = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.TextBox();
            this.DesiredResult = new System.Windows.Forms.TextBox();
            this.DesiredResultLabel = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Values
            // 
            this.Values.AcceptsReturn = true;
            this.Values.AllowDrop = true;
            this.Values.Location = new System.Drawing.Point(12, 46);
            this.Values.Multiline = true;
            this.Values.Name = "Values";
            this.Values.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Values.Size = new System.Drawing.Size(155, 320);
            this.Values.TabIndex = 0;
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(183, 46);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Results.Size = new System.Drawing.Size(551, 320);
            this.Results.TabIndex = 1;
            // 
            // DesiredResult
            // 
            this.DesiredResult.Location = new System.Drawing.Point(95, 12);
            this.DesiredResult.Name = "DesiredResult";
            this.DesiredResult.Size = new System.Drawing.Size(72, 20);
            this.DesiredResult.TabIndex = 2;
            // 
            // DesiredResultLabel
            // 
            this.DesiredResultLabel.AutoSize = true;
            this.DesiredResultLabel.Location = new System.Drawing.Point(13, 15);
            this.DesiredResultLabel.Name = "DesiredResultLabel";
            this.DesiredResultLabel.Size = new System.Drawing.Size(76, 13);
            this.DesiredResultLabel.TabIndex = 3;
            this.DesiredResultLabel.Text = "Desired Result";
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(430, 10);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(75, 23);
            this.Process.TabIndex = 4;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // SubsetSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 378);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.DesiredResultLabel);
            this.Controls.Add(this.DesiredResult);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Values);
            this.Name = "SubsetSum";
            this.Text = "Subset Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Values;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.TextBox DesiredResult;
        private System.Windows.Forms.Label DesiredResultLabel;
        private System.Windows.Forms.Button Process;
    }
}

