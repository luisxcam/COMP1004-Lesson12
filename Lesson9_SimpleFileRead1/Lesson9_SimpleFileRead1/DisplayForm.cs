/* Program:		Lesson 9 SimpleFileRead
   Programmer:	Anju Chawla
   Date:	    November 2014
   Description:	Retrieve the information stored in a data file 
				and display it on the screen.
				Uses the simplified C# file access methods.
				By default, the data file is expected to be in the
				project's bin\Debug folder.                        */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lesson9_SimpleFileRead1
{
    public partial class DisplayForm : Form
    {
        // Declare Class-level variable
        private int FieldCountInteger = 0;
        private string[] FieldString;

        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            // Declare method-level variables
            string FileName = "TextFile.txt";

            try
            {
                // Read entire file into a single string.
                string fileString = File.ReadAllText(FileName);
                // Split the string into individual fields of a string array.
                FieldString = fileString.Split('\n');
                // Display the array in a list box.
                NameTextBox.Text = FieldString[FieldCountInteger];
                PhoneTextBox.Text = FieldString[FieldCountInteger + 1];
            } // end try
            catch
            {
                MessageBox.Show("Unable to access the file: " +
                    FileName, "File Error");
            } // end catch
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Read the Next set of data in the string



            if (FieldCountInteger < FieldString.Length)
            {
                try
                {
                    // Move the index forward and Display the Records
                    FieldCountInteger += 2;
                    DisplayData();
                } // end try
                catch
                {
                    MessageBox.Show("No more records to display.", "End of Data");
                    FieldCountInteger -= 2;
                }
            } // end if

        }

        private void DisplayData()
        {
            // Custom method to display records in a set of TextBoxes
            string FirstFieldString, SecondFieldString;

            FirstFieldString = FieldString[FieldCountInteger];
            SecondFieldString = FieldString[FieldCountInteger + 1];
            NameTextBox.Text = FirstFieldString;
            PhoneTextBox.Text = SecondFieldString;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the Form
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Read the previous set of data in the string

            try
            {
                // Move the Index Back and Display the Records
                FieldCountInteger -= 2;
                DisplayData();
            }
            catch
            {
                MessageBox.Show("You are at the first record", "Beginning of Data");
                FieldCountInteger += 2;
            }
        }
    }
}
