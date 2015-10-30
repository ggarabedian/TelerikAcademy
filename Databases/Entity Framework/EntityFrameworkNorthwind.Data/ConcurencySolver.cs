namespace EntityFrameworkNorthwind.Data
{
    using System;
    using System.Linq;

    /// <summary>
    /// Gives example of what happens when two(or more) different data contexts attempt to change same piece of information.
    /// Only the last given information is saved and can be used later, the others are lost.
    /// </summary>
    public static class ConcurencySolver
    {
        //// Task 7.Try to open two different data contexts and perform concurrent changes on the same records.
        //// What will happen at SaveChanges()? How to deal with it?
        public static void TestTwoConcurentContexts()
        {
            var firstContext = new NorthwindEntities();
            var secondContext = new NorthwindEntities();

            using (firstContext)
            {
                var companyFromFirstContext = firstContext.Customers.First();
                companyFromFirstContext.CompanyName = "Blizzard";

                using (secondContext)
                {
                    var companyFromSecondContext = secondContext.Customers.First();
                    companyFromSecondContext.CompanyName = "Bioware";

                    Console.WriteLine(
                        "Initial name:{2}First Context Company: {0} {2}Second Context Company: {1}",
                        companyFromFirstContext.CompanyName, 
                        companyFromSecondContext.CompanyName, 
                        Environment.NewLine);

                    firstContext.SaveChanges();
                    secondContext.SaveChanges();
                }

                using (var resultContex = new NorthwindEntities())
                {
                    var result = new NorthwindEntities().Customers.First();

                    Console.WriteLine("Company name after change: {0}", result.CompanyName);
                }
            }          
        }
    }
}
