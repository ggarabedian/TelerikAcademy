namespace MobilePhoneMain
{
    using System;
    using System.Linq;

    public class Call
    {
        private DateTime callDateAndTime;
        private string callerNumber;
        private int callDuration;

        public Call(DateTime callDateAndTime, string callerNumber, int callDuration)
        {
            this.CallDateAndTime = callDateAndTime;
            this.CallerNumber = callerNumber;
            this.CallDuration = callDuration;
        }

        public DateTime CallDateAndTime 
        { 
            get 
            {
                return this.callDateAndTime;
            }

            set
            {
                if (value.GetType() != typeof(DateTime))
                {
                    throw new ArgumentException("Invalid format. Input must be in DateTime format.");
                }

                this.callDateAndTime = value;
            }
        }

        public string CallerNumber
        {
            get 
            {
                return this.callerNumber;
            }
            private set
            {
                this.callerNumber = value;
            }
        }

        public int CallDuration
        {
            get
            {
                return this.callDuration;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Call duration must be greater than zero");
                }
                this.callDuration = value;
            }
        }

        public override string ToString()
        {
            return String.Format(@"{0}, {1}, Duration: {2:F1} sec",
                this.CallDateAndTime.ToString("dd/MM/yy - HH:mm:ss"), this.CallerNumber, this.CallDuration);
        }

    }
}
