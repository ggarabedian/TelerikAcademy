namespace EntityFrameworkNorthwind.Data
{
    using System;

    public class SpecialOrderInformation
    {
        public string Customer { get; set; }

        public DateTime OrderDate { get; set; }

        public string ShipCountry { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Ordered by {0} in year {1}, shipped to {2}.",
                        this.Customer,
                        this.OrderDate.Year,
                        this.ShipCountry);
        }
    }
}
