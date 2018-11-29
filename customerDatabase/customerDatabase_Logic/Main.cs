using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerDatabase_Logic
{
    public class Main
    {
        
        int listIndex; // Variable to store the list index (used for multiple events)

        /*-----------------------------------METHODS-----------------------------------*/
        public static void LoadDB()
        {
            // Initialize the customerDB list with pre-set instantiaions of the customer object 
            Data.CustomerDB.Add(new Customer("Jaarna", "Kereopa", "123-2514"));
            Data.CustomerDB.Add(new Customer("Sue", "Stook", "123-1263"));
            Data.CustomerDB.Add(new Customer("Jamie", "Allom", "123-3658"));
            Data.CustomerDB.Add(new Customer("Brian", "Janes", "123-9898"));
        }

        public static void ClearDisplay(object _item)
        {
            _item = null;
        }

        public static void DisplayCustomers()
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
