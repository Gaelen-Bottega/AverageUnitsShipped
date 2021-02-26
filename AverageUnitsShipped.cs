// Author: Gaelen Rhoads & Kyle Chapman
// StudentID: 100804776
// Development Date: 22 Jan 2021
// Updated with new functionality: 26 Feb 20201
// Title: Average Units Shipped Calculator Series X SE Plus Limited Edition 
// Description: This program calculates the average units shipped per day when a user enters data for all seven days. In this modification
// of the first program, three users can now enter data and the program will find the average for each of them as well as the overall average.
// A user can enter a whole number between 0 and 5000. The average output and overall average will be formatted to two decimal places.

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
        #region "Declarations"
        // Classy constants
        const int NumberOfEmployees = 3;
        const int NumberOfDays = 7;

        // Classy variables
        int currentEmployee = 0;
        int currentDay = 0;

        // Declare entryArray new functionality
        int[,] entryArray = new int[NumberOfEmployees, NumberOfDays];

        // Make arrays for output controls
        TextBox[] employeeTextBoxes;
        Label[] employeeAverages;

        #endregion

        #region "Populating the Form"
        public formAverageUnitsShipped()
        {
            InitializeComponent();

            // Populate the arrays of the controls
            employeeTextBoxes = new TextBox[] { textBoxEmployee1PastEntries, textBoxEmployee2PastEntries, textBoxEmployee3PastEntries };
            employeeAverages = new Label[] { labelAverageEmployee1, labelAverageEmployee2, labelAverageEmployee3 };
        }
        #endregion

        #region "Event Handlers"

        /// <summary>
        /// This event handler will activate whenever the enter button is clicked. It validates the current value in the entry textbox and adds it to 
        /// the array of values. It will display the value in the employees textbox if valid. It does this process until the program reaches 7 days of
        /// entries. At that point, it will calculate the average for the employee entering data, and move to the next employee. When it finishes all 3
        /// employees, it will calculate the overal average for the employees units. It will finally restrict the user from entering any more data and 
        /// put focus on the reset button. Additionally, if the values entered are not valid, it will throw an error and produce a message box out to the
        /// user telling them what the error is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare constants and variables
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;

            // Validate for a whole number 
            if (int.TryParse(textboxEntryNumbers.Text, out entryArray[currentEmployee, currentDay]))
            {
                // Validate that number is between 0 and 5000
                if (entryArray[currentEmployee, currentDay] >= MinimumUnits && entryArray[currentEmployee, currentDay] <= MaximumUnits)
                {
                    // Enter the current valid entry in the current employees textbox
                    employeeTextBoxes[currentEmployee].Text += entryArray[currentEmployee, currentDay] + "\r\n";

                    // Clear input textbox so user can input new number
                    textboxEntryNumbers.Text = String.Empty;

                    // Check if we are at day 7
                    // I had this line like:
                    // if (currentDay >= NumberOfDays)
                    // and it kept going out of bounds... so we have ended up with this code...
                    if (currentDay++ >= NumberOfDays - 1)
                    {
                        int employeeTotal = 0;

                        // Calculate and display employee's average.
                        for (int day = 0; day < NumberOfDays; day++)
                        {
                            employeeTotal += entryArray[currentEmployee, day];
                        }

                        // Calculate and display the employee's average in their output label.
                        employeeAverages[currentEmployee].Text = "Average: " + Math.Round((double)employeeTotal / NumberOfDays, 2);

                        // Day 7 reached, reset the day and go to the next employee
                        currentDay = 0;
                        currentEmployee++;
                    }

                    // Check if we have entered all employees. 
                    if (currentEmployee >= NumberOfEmployees)
                    {
                        // local variable for foreach loop
                        int sum = 0;

                        // For each loop to calculate sum of all employee's shipment numbers   
                        foreach (int item in entryArray)
                        {
                            sum += item;
                        }

                        // Output the result
                        // Divide the sum variable by array length to get the accurate result. Format to 2 decimal places.
                        labelAverageOutput.Text = "Average for all employee's is: " + Math.Round((double)sum / entryArray.Length, 2);

                        // Reset day and employee
                        currentDay = 0;
                        currentEmployee = 0;

                        // Everything is entered so this will disable the input controls and set focus on the reset button
                        textboxEntryNumbers.Enabled = false;
                        buttonEnter.Enabled = false;
                        buttonReset.Focus();
                    }

                    // Adjust the day and set day counter
                    // Increment day here for cleaner if I ever figure out the out of range exception
                    //currentDay++;
                    labelDay.Text = "Day: " + (currentDay + 1);
                }
                else
                {
                    // The value entered is less than 0 or greater than 5000
                    MessageBox.Show("Enter a value between " + MinimumUnits + " and " + MaximumUnits + ".", "Invalid Entry!");
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
            ResetForm();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region "Funtions"
        /// <summary>
        /// This function resets the form to its default state. It will clear the textboxes, reset the labels and reset the global variables. It finally
        /// sets focus to the entry textbox again for data entry.
        /// </summary>
        private void ResetForm()
        {
            // Clear the input and output fields.
            textboxEntryNumbers.Clear();
            textBoxEmployee1PastEntries.Clear();
            textBoxEmployee2PastEntries.Clear();
            textBoxEmployee3PastEntries.Clear();
            labelAverageOutput.Text = String.Empty;
            labelAverageEmployee1.Text = String.Empty;
            labelAverageEmployee2.Text = String.Empty;
            labelAverageEmployee3.Text = String.Empty;

            // Reset global variable.
            currentDay = 0;
            labelDay.Text = "Day: " + (currentDay + 1);

            // Re-enable any controls that may be disabled. 
            textboxEntryNumbers.Enabled = true;
            buttonEnter.Enabled = true;

            // Set focus for easy entry.
            textboxEntryNumbers.Focus();
        }

        #endregion
    }
}
