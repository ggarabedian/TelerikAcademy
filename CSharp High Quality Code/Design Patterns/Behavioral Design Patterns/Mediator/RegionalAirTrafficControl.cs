namespace Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RegionalAirTrafficControl : IAirTrafficControl
    {
        readonly List<Aircraft> registeredAircrafts = new List<Aircraft>();

        public void RegistrerAircraft(Aircraft aircraft)
        {
            if (!this.registeredAircrafts.Contains(aircraft))
            {
                this.registeredAircrafts.Add(aircraft);
            }
        }

        public void SendWarningMessage(Aircraft aircraft)
        {
            var list = from a in this.registeredAircrafts
                       where a != aircraft &&
                             Math.Abs(a.Altitude - aircraft.Altitude) < 1000
                       select a;
            foreach (var a in list)
            {
                a.ReceiveWarning(aircraft);
                aircraft.Climb(1000);
            }
        }
    }
}
