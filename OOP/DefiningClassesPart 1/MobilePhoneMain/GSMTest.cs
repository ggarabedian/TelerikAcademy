namespace MobilePhoneMain
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static List<GSM> TestGSMs(int amount)
        {
            List<GSM> gsms = new List<GSM>();
            List<Battery> batteries = new List<Battery>()
            {
                new Battery("Duracell", Battery.BatteryTypes.Li_Ion),
                new Battery("Duracell++", Battery.BatteryTypes.NiCd, 24, 8),
                new Battery("Duracell#", Battery.BatteryTypes.NiMH, 48, 12)
            };

            List<Display> displays = new List<Display>()
            {
                new Display(3.5, 16000000),
                new Display(4.7, 24000000),
                new Display(5.0, 32000000),
            };

            for (int i = 0; i < amount; i++)
			{
                GSM currentGSM = new GSM("Galaxy Note " + (i + 1), "Samsung", batteries[i % batteries.Count], displays[i % displays.Count]);
                gsms.Add(currentGSM);
			}

            gsms.Add(GSM.IPhone4S);

            return gsms;
        }
    }
}
