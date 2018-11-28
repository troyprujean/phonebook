using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerDatabase_Logic
{
    public class Main
    {
        public static List<Customer> CustomerDB = new List<Customer>(); // List to store instantiaions of the Customer object
        int listIndex; // Variable to store the list index (used for multiple events)

        /*-----------------------------------METHODS-----------------------------------*/
        public static void LoadDB()
        {
            // Initialize the customerDB list with pre-set instantiaions of the customer object 
            CustomerDB.Add(new Customer("Jaarna", "Kereopa", "123-2514"));
            CustomerDB.Add(new Customer("Sue", "Stook", "123-1263"));
            CustomerDB.Add(new Customer("Jamie", "Allom", "123-3658"));
            CustomerDB.Add(new Customer("Brian", "Janes", "123-9898"));
        }

        public static void ClearBoxes()
        {
            // Clear the first name, last name and phone number text boxes
            txtFirstName.Text = null;
            txtLastName.Text = null;
            txtPhone.Text = null;
        }

        public static void ClearDisplay(listBox)
        {
            // Clear the list box
            listBox.Items.Clear();
        }

        public void DisplayCustomers()
        {
            // Check if the list is empty, if so, output an error message
            if (!CustomerDB.Any())
            {
                MessageBox.Show("There are no customers in the database", "Error", MessageBoxButtons.OK);
            }
            // Iterate through the list and output each entry to the list box
            foreach (var customer in CustomerDB)
            {
                lbxCustomers.Items.Add(customer.GetCustomer());
            }
        }
        /*-----------------------------------END OF APPLICATION-----------------------------------*/
    }
}
