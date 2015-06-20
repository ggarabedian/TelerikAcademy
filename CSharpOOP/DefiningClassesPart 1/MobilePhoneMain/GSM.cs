namespace MobilePhoneMain
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class GSM
    {
        private static GSM iPhone4S = new GSM("iPhone4S", "Apple", new Battery("iBattery", Battery.BatteryTypes.Li_Ion), new Display(4.0, 256));
        private string model;
        private string manufacturer;
        private int price;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
            : base()
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, int price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
            : this(model, manufacturer)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM IPhone4S 
        { 
            get { return iPhone4S; } 
        }

        public string Model 
        { 
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Manufacturer can't be null or empty");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Manufacturer can't be null or empty");
                }
                this.manufacturer = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Price must be greater than zero");
                }
                this.price = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
        } 

        public void AddCall(Call callToAdd)
        {
            this.CallHistory.Add(callToAdd);
        }

        public void RemoveCall(Call callToRemove)
        {
            this.CallHistory.Remove(callToRemove);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public void PrintCallHistory()
        {
            foreach (var call in CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
            Console.WriteLine();
        }

        public decimal CalculateCallsPrice(decimal pricePerMinute)
        {
            decimal total = 0;

            foreach (var call in this.callHistory)
            {
                total += ((decimal)(call.CallDuration / 60.0) * pricePerMinute);
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder toStringOverride = new StringBuilder();

            toStringOverride.AppendLine(string.Format("Model / Manufacturer: {0} / {1}", this.model, this.manufacturer));

            if (this.Price != 0)
            {
                toStringOverride.AppendLine(string.Format("Price: {0}", this.Price));
            }

            if (this.Battery != null)
            {
                toStringOverride.Append(string.Format("{0}", this.Battery.ToString()));
            }

            if (this.Display != null)
            {
                toStringOverride.Append(string.Format("{0}", this.Display.ToString()));
            }

            return toStringOverride.ToString();
        }
    }
}
