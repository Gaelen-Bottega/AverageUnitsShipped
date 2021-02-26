
namespace AverageUnitsShipped
{
    partial class formAverageUnitsShipped
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
            this.components = new System.ComponentModel.Container();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.textboxEntryNumbers = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxEmployee1PastEntries = new System.Windows.Forms.TextBox();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxEmployee2PastEntries = new System.Windows.Forms.TextBox();
            this.textBoxEmployee3PastEntries = new System.Windows.Forms.TextBox();
            this.labelAverageEmployee1 = new System.Windows.Forms.Label();
            this.labelEmployee1Title = new System.Windows.Forms.Label();
            this.labelEmployee2Title = new System.Windows.Forms.Label();
            this.labelAverageEmployee2 = new System.Windows.Forms.Label();
            this.labelEmployee3Title = new System.Windows.Forms.Label();
            this.labelAverageEmployee3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(12, 38);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(38, 27);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            // 
            // textboxEntryNumbers
            // 
            this.textboxEntryNumbers.Location = new System.Drawing.Point(56, 35);
            this.textboxEntryNumbers.Name = "textboxEntryNumbers";
            this.textboxEntryNumbers.Size = new System.Drawing.Size(75, 20);
            this.textboxEntryNumbers.TabIndex = 1;
            this.toolTip.SetToolTip(this.textboxEntryNumbers, "Enter the units shipped for the specified day.");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(12, 9);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(50, 23);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            // 
            // textboxEmployee1PastEntries
            // 
            this.textBoxEmployee1PastEntries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmployee1PastEntries.Location = new System.Drawing.Point(12, 86);
            this.textBoxEmployee1PastEntries.Multiline = true;
            this.textBoxEmployee1PastEntries.Name = "textboxEmployee1PastEntries";
            this.textBoxEmployee1PastEntries.ReadOnly = true;
            this.textBoxEmployee1PastEntries.Size = new System.Drawing.Size(141, 176);
            this.textBoxEmployee1PastEntries.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxEmployee1PastEntries, "Displays the units shipped for all days entered for Employee 1.");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(12, 304);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(456, 23);
            this.labelAverageOutput.TabIndex = 4;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput, "Displays the calculated average of units shipped for the week.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(17, 346);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(138, 23);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to process the current units shipped.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.Location = new System.Drawing.Point(171, 346);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(138, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset this form to allow for a new weeks of entries. ");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(328, 346);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(138, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to end the application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // textboxEmployee2PastEntries
            // 
            this.textBoxEmployee2PastEntries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmployee2PastEntries.Location = new System.Drawing.Point(171, 86);
            this.textBoxEmployee2PastEntries.Multiline = true;
            this.textBoxEmployee2PastEntries.Name = "textboxEmployee2PastEntries";
            this.textBoxEmployee2PastEntries.ReadOnly = true;
            this.textBoxEmployee2PastEntries.Size = new System.Drawing.Size(141, 176);
            this.textBoxEmployee2PastEntries.TabIndex = 10;
            this.toolTip.SetToolTip(this.textBoxEmployee2PastEntries, "Displays the units shipped for all days entered for Employee 2.");
            // 
            // textboxEmployee3PastEntries
            // 
            this.textBoxEmployee3PastEntries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxEmployee3PastEntries.Location = new System.Drawing.Point(327, 86);
            this.textBoxEmployee3PastEntries.Multiline = true;
            this.textBoxEmployee3PastEntries.Name = "textboxEmployee3PastEntries";
            this.textBoxEmployee3PastEntries.ReadOnly = true;
            this.textBoxEmployee3PastEntries.Size = new System.Drawing.Size(141, 176);
            this.textBoxEmployee3PastEntries.TabIndex = 13;
            this.toolTip.SetToolTip(this.textBoxEmployee3PastEntries, "Displays the units shipped for all days entered for Employee 3.");
            // 
            // labelAverageEmployee1
            // 
            this.labelAverageEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageEmployee1.Location = new System.Drawing.Point(12, 269);
            this.labelAverageEmployee1.Name = "labelAverageEmployee1";
            this.labelAverageEmployee1.Size = new System.Drawing.Size(141, 23);
            this.labelAverageEmployee1.TabIndex = 8;
            this.labelAverageEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee1Title
            // 
            this.labelEmployee1Title.Location = new System.Drawing.Point(12, 58);
            this.labelEmployee1Title.Name = "labelEmployee1Title";
            this.labelEmployee1Title.Size = new System.Drawing.Size(141, 23);
            this.labelEmployee1Title.TabIndex = 9;
            this.labelEmployee1Title.Text = "Employee &1";
            this.labelEmployee1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee2Title
            // 
            this.labelEmployee2Title.Location = new System.Drawing.Point(171, 58);
            this.labelEmployee2Title.Name = "labelEmployee2Title";
            this.labelEmployee2Title.Size = new System.Drawing.Size(141, 23);
            this.labelEmployee2Title.TabIndex = 12;
            this.labelEmployee2Title.Text = "Employee &2";
            this.labelEmployee2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAverageEmployee2
            // 
            this.labelAverageEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageEmployee2.Location = new System.Drawing.Point(171, 269);
            this.labelAverageEmployee2.Name = "labelAverageEmployee2";
            this.labelAverageEmployee2.Size = new System.Drawing.Size(141, 23);
            this.labelAverageEmployee2.TabIndex = 11;
            this.labelAverageEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee3Title
            // 
            this.labelEmployee3Title.Location = new System.Drawing.Point(327, 58);
            this.labelEmployee3Title.Name = "labelEmployee3Title";
            this.labelEmployee3Title.Size = new System.Drawing.Size(141, 23);
            this.labelEmployee3Title.TabIndex = 15;
            this.labelEmployee3Title.Text = "Employee &3";
            this.labelEmployee3Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAverageEmployee3
            // 
            this.labelAverageEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageEmployee3.Location = new System.Drawing.Point(327, 269);
            this.labelAverageEmployee3.Name = "labelAverageEmployee3";
            this.labelAverageEmployee3.Size = new System.Drawing.Size(141, 23);
            this.labelAverageEmployee3.TabIndex = 14;
            this.labelAverageEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(480, 386);
            this.Controls.Add(this.labelEmployee3Title);
            this.Controls.Add(this.labelAverageEmployee3);
            this.Controls.Add(this.textBoxEmployee3PastEntries);
            this.Controls.Add(this.labelEmployee2Title);
            this.Controls.Add(this.labelAverageEmployee2);
            this.Controls.Add(this.textBoxEmployee2PastEntries);
            this.Controls.Add(this.labelEmployee1Title);
            this.Controls.Add(this.labelAverageEmployee1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textBoxEmployee1PastEntries);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textboxEntryNumbers);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textboxEntryNumbers;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxEmployee1PastEntries;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelAverageEmployee1;
        private System.Windows.Forms.Label labelEmployee1Title;
        private System.Windows.Forms.Label labelEmployee2Title;
        private System.Windows.Forms.Label labelAverageEmployee2;
        private System.Windows.Forms.TextBox textBoxEmployee2PastEntries;
        private System.Windows.Forms.Label labelEmployee3Title;
        private System.Windows.Forms.Label labelAverageEmployee3;
        private System.Windows.Forms.TextBox textBoxEmployee3PastEntries;
    }
}

