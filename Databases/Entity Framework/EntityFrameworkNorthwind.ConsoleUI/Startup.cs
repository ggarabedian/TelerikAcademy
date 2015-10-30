namespace EntityFrameworkNorthwind.ConsoleUI
{
    using System;
    using Data;

    public class Startup
    {
        /// <summary>
        /// Startup of the entire homework. Static classes are used so creating instances isn't necessary and the 
        /// code looks cleaner.
        /// </summary>
        public static void Main()
        {
            //// Task 2
            NorthwindUtilities.AddNewCustomer("MAXPC", "Max Pc", "Sofia", "Bulgaria", "0888123456");

            NorthwindUtilities.ModifyNewlyAddedCustomerById("MAXPC", "John Doe", "1000");

            NorthwindUtilities.RemoveNewlyAddedCustomerById("MAXPC");

            //// Task 3
            ////NorthwindUtilities.FindCustomersWithSpecialOrder();

            //// Task 4
            ////NorthwindUtilities.FindCustomerWithSpecialOrderUsingNativeSQL();

            //// Task 5
            ////NorthwindUtilities.GetAllSalesByRegionAndDate("RJ", new DateTime(1997, 01, 01), DateTime.Now);

            //// Task 6
            ////NewDatabaseCreator.CreateNorthwindTwin();

            //// Task 7
            ////ConcurencySolver.TestTwoConcurentContexts();

            //// Task 8
            ////NorthwindUtilities.GetEmployeeTerritories();
        }
    }
}
