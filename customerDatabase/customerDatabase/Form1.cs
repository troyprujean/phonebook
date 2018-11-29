// Name  : Troy Prujean
// ID    : 9930285
// Date  : 19/10/2018
// Title : Customer Database - COMP.5212 assignment 1B

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customerDatabase_Logic;

namespace customerDatabase
{
    public partial class Form1 : Form
    {   
        public Form1() // Constructor for the Form1 class
        {
            InitializeComponent(); 
        }

        /*-----------------------------------EVENTS-----------------------------------*/

        private void Form1_Load(object sender, EventArgs e) // On load event for the form
        {
            Main.LoadDB(); // Initialize the customerDB list with pre-set instantiations of the customer object
        }

        private void btnSearch_Click(object sender, EventArgs e) // Click event for search button
        {
            // Check to see if the search text box is empty or contains blank spaces
            if(string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                // Output an error message box then set the input focus to the search text box
                MessageBox.Show("You must enter a customer name", "Error", MessageBoxButtons.OK);
                txtSearch.Focus();
            }
            else
            {
                string searchEntry = txtSearch.Text;
                Main.ClearDisplay(lbxCustomers); 
                // Perform a case insensitive search of the list to see if the first name of any of the entries matches the searchEntry variable
                if (CustomerDB.Any(customer => customer.FName.Equals(searchEntry, StringComparison.OrdinalIgnoreCase))) //Thanks to: https://stackoverflow.com/questions/3947126/case-insensitive-list-search
                {
                    // If a match is found, store the index of the matched list object in a variable
                    int searchIndex = CustomerDB.FindIndex(customer => customer.FName.Equals(searchEntry, StringComparison.OrdinalIgnoreCase));
                    ClearDisplay();
                    // Using the index, display the matched item in the list box
                    lbxCustomers.Items.Add(CustomerDB.ElementAt(searchIndex).GetCustomer());
                }
                else
                {
                    // Output an error message box then set the input focus to the search text box
                    MessageBox.Show("Customer not found, please try again", "Error", MessageBoxButtons.OK);
                    txtSearch.Focus();
                }
            }
        }

        private void btnListCustomers_Click(object sender, EventArgs e) // Click event for list customers button
        {
            // Clear the display, then display the customers on the list box
            Main.ClearDisplay(lbxCustomers.Items);
            Main.DisplayCustomers();
        }

        private void btnClearList_Click(object sender, EventArgs e) // Click event for the clear list button
        {
            // Clear the display, boxes, then set the input focus to the search text box and enable the add button
            Main.ClearDisplay(lbxCustomers.Items);
            Main.ClearDisplay(txtFirstName.Text);
            Main.ClearDisplay(txtLastName.Text);
            Main.ClearDisplay(txtPhone.Text); // Added the clearboxes method to prevent selected item on list from being retained when list is cleared
            txtSearch.Focus();
            btnAdd.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) // Click event for the update button
        {
            if (lbxCustomers.SelectedIndex == -1) // Confirm that an item in the list box is actually selected
            {
                // If no item is selected, output an error message box, clear the display and reload the customerdb to the list 
                MessageBox.Show("Please select a customer to update", "Error", MessageBoxButtons.OK); // Thanks to: https://stackoverflow.com/questions/4544254/how-do-we-check-whether-any-item-in-the-listbox-is-selected-in-asp-net-net-2-0
                ClearDisplay();
                DisplayCustomers();
            }
            else
            {
                // If an item is selected, confirm that all of the relevant text boxes are not empty or contain blank spaces
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    // If any of the text boxes are empty, output an error message box
                    MessageBox.Show("All textboxes must be filled to continue", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    // If validation passes, modify the element of the list at the index found on the list select value method so that its properties are changed to the values
                    // of the three text boxes, clear the boxes, clear the display, reload the customerdb to the list, output success message and enable the add button
                    CustomerDB.ElementAt(listIndex).FName = txtFirstName.Text;
                    CustomerDB.ElementAt(listIndex).LName = txtLastName.Text;
                    CustomerDB.ElementAt(listIndex).Phone = txtPhone.Text;
                    ClearBoxes();
                    ClearDisplay();
                    DisplayCustomers();
                    MessageBox.Show("Customer details updated", "Success", MessageBoxButtons.OK);
                    btnAdd.Enabled = true;
                }
            }
        }

        private void lbxCustomers_SelectedValueChanged(object sender, EventArgs e) // Event for selecting an item on the list
        {
            if (lbxCustomers.SelectedIndex >= 0) // Confirmation that one of the items is actually selected
            {
                // Disable add button, store the selected item in an array seperated by the tabs to create 3 indices, then update the associated indices with the text box values
                btnAdd.Enabled = false;
                string[] listArray = lbxCustomers.SelectedItem.ToString().Split('\t'); // Thanks to: https://stackoverflow.com/questions/2797647/separate-string-by-tab-characters
                txtFirstName.Text = listArray[0];
                txtLastName.Text = listArray[1];
                txtPhone.Text = listArray[2];
                // Store the index of the item in the customerdb list by confirming that the objects first name matches that of the first name stored in indices "0" of the array
                listIndex = CustomerDB.FindIndex(customer => customer.FName.Equals(listArray[0], StringComparison.OrdinalIgnoreCase));
            }
            else 
            {
                // If no items are selected do nothing...
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) // Click event for add button
        {
            // Confirm that all of the relevant text boxes are not empty or contain blank spaces
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                // If any of the text boxes are empty, output an error message box
                MessageBox.Show("All textboxes must be filled to continue", "Error", MessageBoxButtons.OK);
            }
            else
            {   
                // If validation passes, instantiate a new object in the customerdb list passing the text box values in as parameters for the class constructor
                CustomerDB.Add(new Customer(txtFirstName.Text, txtLastName.Text, txtPhone.Text));
                // Clear the text boxes, display, reload the customerdb to the list and output success message
                ClearBoxes();
                ClearDisplay();
                DisplayCustomers();
                MessageBox.Show("New customer has been added", "Success", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) // Click event for delete button
        {
            if (lbxCustomers.SelectedIndex == -1) // Confirm that an item in the list box is actually selected
            {
                // If no item is selected, output an error message box, clear the display and reload the customerdb to the list 
                MessageBox.Show("Please select a customer to delete", "Error", MessageBoxButtons.OK);
                ClearDisplay();
                DisplayCustomers();
            }
            else
            {   
                // Output a confirmation message box to confirm that the user really wants to delete the selected item
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // Thanks to: https://stackoverflow.com/questions/5414270/messagebox-buttons
                {
                    // If the dialogue result is yes, delete the customer from the list at the index discovered from the list select value event
                    CustomerDB.RemoveAt(listIndex);
                    // Clear the boxes, display, reload the customerdb to the list, output success message and enable the add button
                    ClearBoxes();
                    ClearDisplay();
                    DisplayCustomers();
                    MessageBox.Show("The customer has been deleted", "Success", MessageBoxButtons.OK);
                    btnAdd.Enabled = true;
                }
                else
                {
                    // If the dialogue result is no, output success message
                    MessageBox.Show("Operation cancelled", "Success", MessageBoxButtons.OK);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) // Click event for the clear button
        {
            // Clear the boxes, set the input focus to the first name text box and enable the add button
            ClearBoxes();
            txtFirstName.Focus();
            btnAdd.Enabled = true;
        }

    
    }
}
