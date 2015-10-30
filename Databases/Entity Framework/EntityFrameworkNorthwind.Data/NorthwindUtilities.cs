namespace EntityFrameworkNorthwind.Data
{
    using System;
    using System.Data.Linq;
    using System.Linq;

    /// <summary>
    /// Class with static methods which provide functionality for inserting, modifying and deleting customers.
    /// </summary>
    public static class NorthwindUtilities
    {
        //// Task 2.Create a DAO class with STATIC methods which provide functionality for inserting, modifying and 
        ////deleting customers. Write a testing class.
        public static void AddNewCustomer(string customerId, string companyName, string city, string country, string phone)
        {
            using (var db = new NorthwindEntities())
            {
                Customer customer = new Customer()
                {
                    CustomerID = customerId,
                    CompanyName = companyName,
                    City = city,
                    Country = country,
                    Phone = phone
                };

                db.Customers.Add(customer);
                db.SaveChanges();
            }

            Console.WriteLine("Customer {0} added successfully!", companyName);
        }

        public static void ModifyNewlyAddedCustomerById(string id, string contactName, string postalCode)
        {
            using (var db = new NorthwindEntities())
            {
                Customer customer = db
                        .Customers
                        .FirstOrDefault(c => c.CustomerID == id);

                if (customer == null)
                {
                    Console.WriteLine("Customer with id {0} not found!", id);
                    return;
                }

                customer.ContactName = contactName;
                customer.PostalCode = postalCode;

                db.SaveChanges();

                Console.WriteLine("Customer {0} modified successfully!", id);
            }
        }

        public static void RemoveNewlyAddedCustomerById(string id)
        {
            using (var db = new NorthwindEntities())
            {
                Customer customer = db
                        .Customers
                        .FirstOrDefault(c => c.CustomerID == id);

                if (customer == null)
                {
                    Console.WriteLine("Customer with id {0} not found!", id);
                    return;
                }

                db.Customers.Remove(customer);
                db.SaveChanges();

                Console.WriteLine("Customer {0} removed successfully!", id);
            }
        }

        //// Task 3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
        public static void FindCustomersWithSpecialOrder()
        {
            Console.WriteLine("List of customers that ordered to Canada in year 1997: ");
            using (var db = new NorthwindEntities())
            {
                var customers = db
                    .Orders
                    .Join(
                    db.Customers, 
                    o => o.CustomerID, 
                    c => c.CustomerID, 
                    (o, c) =>
                    new SpecialOrderInformation
                    {
                        Customer = c.CompanyName,
                        OrderDate = o.OrderDate.Value,
                        ShipCountry = o.ShipCountry
                    })
                    .Where(o => o.OrderDate.Year == 1997 && o.ShipCountry == "Canada")
                    .ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }

            Console.WriteLine();
        }

        //// Task 4.Implement previous by using native SQL query and executing it through the DbContext.
        public static void FindCustomerWithSpecialOrderUsingNativeSQL()
        {
            Console.WriteLine("List of customers that ordered to Canada in year 1997(Native SQL): ");
            using (var db = new NorthwindEntities())
            {
                var query = "SELECT c.CompanyName AS [Customer], o.OrderDate [Year], o.ShipCountry " +
                            "FROM Customers c " +
                            "JOIN Orders o " +
                            "ON c.CustomerID = o.CustomerID " +
                            "WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'";

                var customers = db.Database.SqlQuery<SpecialOrderInformation>(query);

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }

            Console.WriteLine();
        }

        //// Task 5. Write a method that finds all the sales by specified region and period (start / end dates).
        public static void GetAllSalesByRegionAndDate(string region, DateTime startDate, DateTime endDate)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var sales = northwindEntities.Orders
                    .Where(o => o.ShipRegion == region && o.ShippedDate > startDate && o.ShippedDate < endDate)
                    .OrderBy(sd => sd.ShippedDate)
                    .ToList();

                foreach (var sale in sales)
                {
                    Console.WriteLine(
                        "Shipped to {0} in region {1} at {2:dd.MM.yy}",
                        sale.ShipName,
                        sale.ShipRegion,
                        sale.ShippedDate);
                }
            }
        }

        //// Task 8. 
        public static void GetEmployeeTerritories()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var employee = northwindEntities.Employees.First();

                EntitySet<Territory> territories = employee.TerritoriesSet;

                Console.WriteLine("All territories for employee {0} are:", employee.FirstName);

                foreach (var territory in territories)
                {
                    Console.WriteLine(territory.TerritoryDescription);
                }
            }
        }
    }
}
