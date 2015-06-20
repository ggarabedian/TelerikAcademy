namespace MobilePhoneMain
{
    using System;
    using System.Collections.Generic;

    public class MobilePhoneMain
    {
        public static void Main()
        {
            // Tests the Mobile Phone Part
            var listOfGsms = GSMTest.TestGSMs(3);

            foreach (var gsm in listOfGsms)
            {
                Console.WriteLine(gsm.ToString());
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 60));
            Console.WriteLine();

            // Tests the Call Part
            CallHistoryTest.TestCalls();
        }
    }
}
