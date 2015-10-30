namespace Mediator
{
    public class Boeing747 : Aircraft
    {
        public Boeing747(string registrationNumber, IAirTrafficControl atc)
            : base(registrationNumber, atc)
        {
        }
    }
}
