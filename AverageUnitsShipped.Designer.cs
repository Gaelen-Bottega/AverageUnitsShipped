
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
            this.textboxPastEntries = new System.Windows.Forms.TextBox();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(68, 21);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(38, 27);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            // 
            // textboxEntryNumbers
            // 
            this.textboxEntryNumbers.Location = new System.Drawing.Point(131, 20);
            this.textboxEntryNumbers.Name = "textboxEntryNumbers";
            this.textboxEntryNumbers.Size = new System.Drawing.Size(75, 20);
            this.textboxEntryNumbers.TabIndex = 1;
            this.toolTip.SetToolTip(this.textboxEntryNumbers, "Enter the units shipped for the specified day.");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(231, 21);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(50, 23);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            // 
            // textboxPastEntries
            // 
            this.textboxPastEntries.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textboxPastEntries.Location = new System.Drawing.Point(76, 55);
            this.textboxPastEntries.Multiline = true;
            this.textboxPastEntries.Name = "textboxPastEntries";
            this.textboxPastEntries.ReadOnly = true;
            this.textboxPastEntries.Size = new System.Drawing.Size(196, 176);
            this.textboxPastEntries.TabIndex = 3;
            this.toolTip.SetToolTip(this.textboxPastEntries, "Displays the units shipped for all days entered so far.");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(54, 240);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(240, 23);
            this.labelAverageOutput.TabIndex = 4;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput, "Displays the calculated average of units shipped for the week.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(41, 272);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to process the current units shipped.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.Location = new System.Drawing.Point(137, 272);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset this form to allow for a new weeks of entries. ");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(233, 272);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to end the application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // formAverageUnitsShipped
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(348, 309);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textboxPastEntries);
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
        private System.Windows.Forms.TextBox textboxPastEntries;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

