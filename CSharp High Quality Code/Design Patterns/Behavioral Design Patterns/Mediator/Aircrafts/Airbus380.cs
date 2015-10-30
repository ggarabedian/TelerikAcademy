namespace Mediator
{
    public class Airbus380 : Aircraft
    {
        public Airbus380(string registrationNumber, IAirTrafficControl atc)
            : base(registrationNumber, atc)
        {
        }
    }
}
