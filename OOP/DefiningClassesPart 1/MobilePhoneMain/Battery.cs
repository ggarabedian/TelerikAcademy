namespace MobilePhoneMain
{
    using System;
    using System.Text;

    public class Battery
    {
        private BatteryTypes batteryType;
        private string batteryModel;
        private double hoursIdle;
        private double hoursTalk;

        public Battery(string batteryModel, BatteryTypes batteryType)
            : base()
        {
            this.BatteryModel = batteryModel;
            this.BatteryType = batteryType;
        }

        public Battery(string batteryModel, BatteryTypes batteryType, double hoursIdle, double hoursTalk)
            : this(batteryModel, batteryType)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public enum BatteryTypes
        {
            Li_Ion,
            NiMH,
            NiCd
        }

        public BatteryTypes BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }

        public string BatteryModel 
        {
            get
            {
                return this.batteryModel;
            }
            private set
            {
                this.batteryModel = value;
            }
        }

        public double HoursIdle 
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HoursIdle cannot be less than zero");
                }
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HoursTalk cannot be less than zero");
                }
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            StringBuilder toStringOverride = new StringBuilder();

            toStringOverride.AppendLine(string.Format("Battery model and type: {0} {1}", this.BatteryModel, this.BatteryType));

            if (HoursIdle != 0 && HoursTalk != 0)
            {
                toStringOverride.AppendLine(string.Format("Hours idle / hours talk: {0} / {1}", this.HoursIdle, this.HoursTalk));
            }
            
            return toStringOverride.ToString();
        }
    }
}
