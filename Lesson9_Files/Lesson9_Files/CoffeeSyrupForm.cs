/*
 * Name : Anju Chawla
 * Date : Nov.11, 2014
 * Purpose: To allow the user to select coffee and syrup flavours.
 * New coffee flavours can be added and remove/remove all coffee flavours
 * Prints all coffee flavours and selected ones too.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9_Files
{
    public partial class CoffeeSyrupForm : Form
    {
        public CoffeeSyrupForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show the information

            AboutBox1 information = new AboutBox1();
            information.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean itemFoundBoolean = false;
            int itemIndexInteger = 0;
            //add a new coffee flavour if it does not exist

            //if the user has provided a new flavour
            if (coffeeComboBox.Text.Trim() != String.Empty)
            {
                //check if the flavour already exists

                while (!itemFoundBoolean && itemIndexInteger < coffeeComboBox.Items.Count)
                {
                    if (coffeeComboBox.Text.ToUpper() == coffeeComboBox.Items[itemIndexInteger].ToString().ToUpper())
                    {
                        itemFoundBoolean = true;
                    }
                    else
                    {
                        itemIndexInteger++;
                    }

                }
                //if flavour found
                if (itemFoundBoolean)
                {
                    MessageBox.Show("Duplicate Flavour cannot be added", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    coffeeComboBox.Focus();
                }
                else
                {
                    //add the flavour
                    coffeeComboBox.Items.Add(coffeeComboBox.Text);
                    coffeeComboBox.Text = "";
                }


            }
            else
            {
                MessageBox.Show("Enter a coffee flavour to add", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                coffeeComboBox.Focus();
            }

        }

        private void removeCoffeeFlavourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //remove a flavour if it exists

            //no selection made
            if (coffeeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the coffee flavour to delete",
                    "No Selection Made", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                coffeeComboBox.Focus();

            }
            //remove coffee 
            else
            {
                //coffeeComboBox.Items.RemoveAt(coffeeComboBox.SelectedIndex);
                coffeeComboBox.Items.Remove(coffeeComboBox.Items[coffeeComboBox.SelectedIndex]);

            }

        }

        private void clearCoffeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear all coffee flavours

            DialogResult confirm = MessageBox.Show("Clear all coffee flavours",
                "Clear Coffee list", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (confirm == System.Windows.Forms.DialogResult.Yes)
            {
                coffeeComboBox.Items.Clear();
            }


        }

        private void countCoffeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display the number of flavours
            string messageString = "The number of available coffee flavours is "
                                   + coffeeComboBox.Items.Count;

            MessageBox.Show(messageString, "Coffee Flavours",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the application
            this.Close();
        }

        private void printAllDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Handle printing and print previews when printing all.

            Font printFont = new Font("Arial", 12);
            float lineHeightFloat = printFont.Height + 2;
            float horizontalPrintLocationFloat = e.MarginBounds.Left;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            string printLineString;

            //Print the heading
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString("Flavours", headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);

            // Loop through the entire list.
            //for (int ListIndexInteger = 0; ListIndexInteger < CoffeeComboBox.Items.Count - 1; ListIndexInteger++)
            foreach (Object flavor in coffeeComboBox.Items)
            {
                //increment the  Y position for the next line.
                verticalPrintLocationFloat += lineHeightFloat;

                //Set up a line
                //PrintLineString = CoffeeComboBox.Items[ListIndexInteger].ToString();
                printLineString = flavor.ToString();
                //Send the line to the graphics page object.
                e.Graphics.DrawString(printLineString, printFont,
                    Brushes.Black, horizontalPrintLocationFloat,
                    verticalPrintLocationFloat);
            } // end for
        }

        private void printAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print all flavours
            printAllDocument.Print();

        }

        private void previewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //preview the coffee flavours
            printPreviewDialog1.Document = printAllDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void printSelectedDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Handle printing and print previews when printing selected items.

            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float lineHeightFloat = printFont.Height + 2;
            float horizontalPrintLocationFloat = e.MarginBounds.Left;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            string printLineString;

            //Set up and display heading lines
            printLineString = "Print Selected Item";
            e.Graphics.DrawString(printLineString, headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);
            printLineString = "by Anju Chawla";
            verticalPrintLocationFloat += lineHeightFloat;
            e.Graphics.DrawString(printLineString, headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);

            // Leave a blank line between the heading and detail line.
            verticalPrintLocationFloat += lineHeightFloat * 2;
            // Set up the selected line.
            printLineString = "Coffee: " + coffeeComboBox.Text +
                "     Syrup: " + syrupListBox.Text;
            // Send the line to the graphics page object.
            e.Graphics.DrawString(printLineString, printFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);
        }

        private void printSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print selected flavours

            if (syrupListBox.SelectedIndex == -1)
            {
                syrupListBox.SelectedIndex = 0;
            }

            if (coffeeComboBox.SelectedIndex != -1)
            {
                printSelectedDocument.Print();
            }
            else
            {
                MessageBox.Show("Please select a coffee flavour", "Print Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                coffeeComboBox.Focus();
            }

        }

        private void previewSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (syrupListBox.SelectedIndex == -1)
            {
                syrupListBox.SelectedIndex = 0;
            }

            if (coffeeComboBox.SelectedIndex != -1)
            {
                printPreviewDialog1.Document = printSelectedDocument;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a coffee flavour", "Print Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                coffeeComboBox.Focus();
            }
        }
    }
}
