namespace NorthwindDatabaseManipulator.Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;

    public class Startup
    {
        private const string ConnectionStringSQL = "Server=.;Database=Northwind;Integrated Security=true";

        public static void Main()
        {
            SqlConnection db = new SqlConnection(ConnectionStringSQL);
            db.Open();

            //// 1.Write a program that retrieves from the Northwind sample database in MS SQL Server the number of 
            //// rows in the Categories table.

            Console.WriteLine("Task 1:");
            using (db)
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Categories", db);
                int categoriesCount = (int)command.ExecuteScalar();

                Console.WriteLine("Number of rows in \"Categories\" = {0}", categoriesCount);
            }

            Console.WriteLine();

            db.Dispose();
            db = new SqlConnection(ConnectionStringSQL);
            db.Open();

            //// 2.Write a program that retrieves the name and description of all categories in the Northwind DB.

            Console.WriteLine("Task 2:");
            using (db)
            {
                SqlCommand command = new SqlCommand("SELECT CategoryName, Description FROM Categories", db);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string category = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];

                    Console.WriteLine("Categorie: {0}, Description: {1}", category, description);
                }
            }

            Console.WriteLine();

            db.Dispose();
            db = new SqlConnection(ConnectionStringSQL);
            db.Open();

            //// 3.Write a program that retrieves from the Northwind database all product categories and the names 
            //// of the products in each category. Can you do this with a single SQL query (with table join)?

            Console.WriteLine("Task 3:");
            using (db)
            {
                SqlCommand command = new SqlCommand(
                    "SELECT c.CategoryName, p.ProductName FROM Categories c " +
                    "JOIN Products p ON p.CategoryID = c.CategoryID " +
                    "ORDER BY c.CategoryName",
                    db);

                SqlDataReader reader = command.ExecuteReader();

                var existingCategories = new HashSet<string>();
                while (reader.Read())
                {
                    string category = (string)reader["CategoryName"];
                    string product = (string)reader["ProductName"];

                    if (!existingCategories.Contains(category))
                    {
                        Console.WriteLine("Categorie: {0}", category);
                        existingCategories.Add(category);
                    }

                    Console.WriteLine("Product: {0}", product);
                }
            }

            Console.WriteLine();

            db.Dispose();
            db = new SqlConnection(ConnectionStringSQL);
            db.Open();

            //// 4.Write a method that adds a new product in the products table in the Northwind database.
            //// Use a parameterized SQL command.

            Console.WriteLine("Task 4:");
            using (db)
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Products " +
                    "(ProductName, SupplierID, CategoryID, UnitPrice, Discontinued) VALUES " +
                    "(@productName, @supplierId, @categoryId, @unitPrice, @discontinued)",
                    db);

                string productName = "Milka Chocolate";
                int supplierId = 25;
                int categoryId = 3;
                decimal unitPrice = 1.75M;
                bool discontinued = false;

                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@supplierId", supplierId);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                command.Parameters.AddWithValue("@unitPrice", unitPrice);
                command.Parameters.AddWithValue("@discontinued", discontinued);

                command.ExecuteNonQuery();

                Console.WriteLine("Milka Chocolate added to the Northwind database - table Products!");
            }

            Console.WriteLine();

            db.Dispose();
            db = new SqlConnection(ConnectionStringSQL);
            db.Open();

            //// 5.Write a program that retrieves the images for all categories in the Northwind database 
            //// and stores them as JPG files in the file system.

            Console.WriteLine("Task 5:");
            using (db)
            {
                SqlCommand command = new SqlCommand("SELECT Picture FROM Categories", db);

                SqlDataReader reader = command.ExecuteReader();
                int counter = 1;

                while (reader.Read())
                {
                    byte[] picture = (byte[])reader["Picture"];
                    string fileSavePath = string.Format(@"..\..\pictures\Category{0}Picture.jpg", counter);

                    using (var memoryStream = new MemoryStream(picture, 78, picture.Length - 78))
                    {
                        Image image = Image.FromStream(memoryStream);

                        image.Save(fileSavePath);
                    }

                    counter++;
                }

                Console.WriteLine("All pictures have been saved!");
            }

            Console.WriteLine();

            //// 6.Create an Excel file with 2 columns: name and score: Write a program that reads your MS Excel 
            //// file through the OLE DB data provider and displays the name and score row by row.

            Console.WriteLine("Task 6:");

            string oleDbConnectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Scores.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES""");

            OleDbConnection oleDb = new OleDbConnection(oleDbConnectionString);
            oleDb.Open();

            using (oleDb)
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Scores$]", oleDb);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];

                    Console.WriteLine("{0} <==> {1}", name, score);
                }

                oleDb.Dispose();
            }

            Console.WriteLine();

            //// 7.Implement appending new rows to the Excel file.

            Console.WriteLine("Task 7:");
            oleDb = new OleDbConnection(oleDbConnectionString);
            oleDb.Open();

            using (oleDb)
            {
                OleDbCommand command = new OleDbCommand(
                    "INSERT INTO [Scores$]" +
                    "VALUES (@name, @score)",
                    oleDb);

                command.Parameters.AddWithValue("@name", "Ivaylo Kenov");
                command.Parameters.AddWithValue("@score", 25);
                command.ExecuteNonQuery();

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@name", "Evlogi Georgiev");
                command.Parameters.AddWithValue("@score", 21);
                command.ExecuteNonQuery();

                oleDb.Dispose();
            }

            Console.WriteLine("Succesfully added new results to scores!");

            //// Task 8.Write a program that reads a string from the console and finds all products that contain 
            //// this string. Ensure you handle correctly characters like ', %, ", \ and _.

            Console.WriteLine("Task 8:");
            Console.Write("Enter your search paramater: ");

            string input = Console.ReadLine();

            db = new SqlConnection(ConnectionStringSQL);
            db.Open();

            using (db)
            {
                var command = new SqlCommand(
                                    @"SELECT ProductName FROM Products
                                    WHERE ProductName LIKE '%'+@input+'%'",
                                    db);
                command.Parameters.AddWithValue("@input", input);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["ProductName"]);
                }
            }
        }
    }
}
