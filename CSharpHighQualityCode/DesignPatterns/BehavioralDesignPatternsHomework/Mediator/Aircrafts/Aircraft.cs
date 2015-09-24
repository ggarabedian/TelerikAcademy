namespace Mediator
{
    using System;

    public abstract class Aircraft
    {
        private readonly IAirTrafficControl atc;
        private int altitude;

        public string RegistrationNumber { get; set; }

        public int Altitude
        {
            get { return this.altitude; }
            set
            {
                this.altitude = value;
                this.atc.SendWarningMessage(this);
            }
        }

        public Aircraft(string registrationNumber, IAirTrafficControl atc)
        {

            this.RegistrationNumber = registrationNumber;
            this.atc = atc;
            this.atc.RegistrerAircraft(this);
        }

        public void Climb(int heightToClimb)
        {
            this.Altitude += heightToClimb;
        }

        public void ReceiveWarning(Aircraft reportingAircraft)
        {
            Console.WriteLine("ATC: ({0}) - {1} is at your flight altitude!!!",
              this.RegistrationNumber, reportingAircraft.RegistrationNumber);
        }
    }
}
