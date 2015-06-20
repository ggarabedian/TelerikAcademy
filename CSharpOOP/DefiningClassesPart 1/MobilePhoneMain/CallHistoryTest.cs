namespace MobilePhoneMain
{
    using System;
    using System.Linq;

    public class CallHistoryTest
    {        
        public static void TestCalls()
        {
            GSM Nexus = new GSM("Nexus", "Motorola");

            Nexus.AddCall(new Call(new DateTime(2015, 02, 15, 10, 35, 00), "+359885674898", 267));
            Nexus.AddCall(new Call(new DateTime(2015, 01, 25, 07, 25, 30), "+359885632412", 125));
            Nexus.AddCall(new Call(new DateTime(2015, 03, 12, 01, 15, 10), "+359881242134", 564));
            Nexus.AddCall(new Call(new DateTime(2014, 11, 20, 11, 15, 35), "+359870937241", 305));

            Nexus.PrintCallHistory();

            Console.WriteLine("Total price before removal: {0:F2}", Nexus.CalculateCallsPrice(0.37m));

            Call longestCall = Nexus.CallHistory.OrderByDescending(x => x.CallDuration).First();
            Nexus.RemoveCall(longestCall);

            Console.WriteLine("Total price after removal: {0:F2}", Nexus.CalculateCallsPrice(0.37m));
            
            Console.WriteLine();

            Nexus.PrintCallHistory();
        }
    }
}
