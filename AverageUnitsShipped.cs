// Name: Gaelen Rhoads
// StudentID: 100804776
// Date: 22 Jan 2021
// Title: Average Units Shipped Calculator
// Description: This program calculates the average units shipped per day when a user enters data for all seven days. 
// A user can enter a whole number between 0 and 5000. The output will be formatted to two decimal places.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitsShipped
{
    public partial class formAverageUnitsShipped : Form
    {
        // Class-level declarations.
        int currentDay = 1;
        int runningTotal = 0;

        public formAverageUnitsShipped()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When activated this handler will validate the number in our entry box to check if it is numeric and within the given range.
        /// If so, it will add the value to the text box and increment to the next day for another entry. When Day 7 is entered, it will calculate
        /// the average of the running total and output it in the label on our form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Constants.
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;
            const int MaximumDays = 7;

            // Variables.
            int lastEntry;

            // Validate that the number entered is a whole number.
            if (int.TryParse(textboxEntryNumbers.Text, out lastEntry))
            {
                // Validate that the number entered is between 0 and 5000.
                if (lastEntry >= MinimumUnits && lastEntry <= MaximumUnits)
                {
                    // The entry is valid.
                    // Add the newest entry to the list of past entries.
                    textboxPastEntries.Text += lastEntry + "\r\n";
                    // Increment runningTotal by the entry.
                    runningTotal += lastEntry;
                    
                    // Increment the day by 1.
                    currentDay++;
                    // Clear entry field.
                    textboxEntryNumbers.Clear();

                    // If the day is > 7.
                    if (currentDay > MaximumDays)
                    {
                        // Determine the average.
                        double averageUnits;
                        averageUnits = (double)runningTotal / (double)MaximumDays;
                        // Output the result.
                        labelAverageOutput.Text = "Average per day: " + Math.Round(averageUnits, 2);
                        // Disable controls.
                        textboxEntryNumbers.Enabled = false;
                        buttonEnter.Enabled = false;
                        // Set focus to reset button.
                        buttonReset.Focus();
                    }
                    // If the day is <= 7.
                    else
                    {
                        // Display current day.
                        labelDay.Text = "Day " + currentDay;
                        // Focus on Entry box.
                        textboxEntryNumbers.Focus();
                    }
                }
                else
                {
                    // The value entered is less than 0 or greater than 5000.
                    MessageBox.Show("Enter a value between " + MinimumUnits + 
                        " and " + MaximumUnits + ".", "Invalid Entry!");
                    textboxEntryNumbers.SelectAll();
                    textboxEntryNumbers.Focus();
                }
            }
            else
            {
                // The value entered is not an integer.
                MessageBox.Show("Entry must be a numeric value.", "Invalid Entry!");
                textboxEntryNumbers.SelectAll();
                textboxEntryNumbers.Focus();
            }
        }       

        /// <summary>
        /// Resets the form for new week to be entered. Resets global variables, re-enables controls that were disabled, clears the fields
        /// and sets focus for easy user entry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Clear the input and output fields.
            textboxEntryNumbers.Clear();
            textboxPastEntries.Clear();
            labelAverageOutput.Text = String.Empty;

            // Reset global variable.
            currentDay = 1;
            runningTotal = 0;
            labelDay.Text = "Day " + currentDay;

            // Re-enable any controls that may be disabled. 
            textboxEntryNumbers.Enabled = true;
            buttonEnter.Enabled = true;

            // Set focus for easy entry.
            textboxEntryNumbers.Focus();
        }

        /// <summary>
        /// Closing the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
