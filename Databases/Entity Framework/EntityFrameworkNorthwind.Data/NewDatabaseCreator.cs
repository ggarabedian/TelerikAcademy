namespace EntityFrameworkNorthwind.Data
{
    using System;

    public static class NewDatabaseCreator
    {
        //// Task 6.Create a database called NorthwindTwin with the same structure as Northwind using the features 
        //// from DbContext. Find for the API for schema generation in MSDN or in Google.
        public static void CreateNorthwindTwin()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                //// In app.config of EntityFrameworkNorthwind.ConsoleUI change the connection string 
                //// "initial catalog=Northwind" part with "initial catalog=NorthwindTwin"

                var isCreated = northwindEntities.Database.CreateIfNotExists();

                Console.WriteLine("Database NorthWindTwin {0}", isCreated ? "created successfully!" : "already exist!");
            }
        }
    }
}
