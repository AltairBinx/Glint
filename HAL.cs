using System;
using System.Text;
using SYS = Cosmos.System;
using OLDHAL = Cosmos.HAL;

namespace HAL
{
    public class RTC {
        public static int Year = OLDHAL.RTC.Year;
        public static int Month = OLDHAL.RTC.Month;
        public static int Day = OLDHAL.RTC.DayOfTheMonth;

        public static int Hour = OLDHAL.RTC.Hour;
        public static int Minute = OLDHAL.RTC.Minute;
        public static int Second = OLDHAL.RTC.Second;
    }

    public class PCS
    {
        public static void Beep(uint freq)
        {
            OLDHAL.PCSpeaker.Beep(freq);
        }
    }

    public class Power
    {
        public static void ACPIShutdown()
        {
            OLDHAL.Power.ACPIShutdown();
        }

        public static void ACPIReset()
        {
            OLDHAL.Power.CPUReboot();
        }
    }

    public class KernelException
    {
        public static void InvalidDate()
        {
            throw new Exception("INVALID_DATE");
        }
    }

    public class Init
    {
        public static void Initalize()
        {
            OLDHAL.Bootstrap.Init();
            OLDHAL.PCI.Setup();
            Console.SetWindowSize(80, 25);
            if(HAL.RTC.Year < 01)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                SYS.PCSpeaker.Beep(200);
                Console.Write("A Problem Occured During Starting Up, So Glint Has Been Shut Down To Prevent Any");
                Console.WriteLine("Damage. Contact Your System Admin.\n\n");
                Console.WriteLine("The Date Is Invalid.");
                HAL.KernelException.InvalidDate();
                Console.ReadKey();
                HAL.Power.ACPIReset();
            }

            if (HAL.RTC.Year > 50)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                SYS.PCSpeaker.Beep(200);
                Console.Write("A Problem Occured During Starting Up, So Glint Has Been Shut Down To Prevent Any");
                Console.WriteLine("Damage. Contact Your System Admin.\n\n");
                Console.WriteLine("The Date Is Invalid.");
                HAL.KernelException.InvalidDate();
                Console.ReadKey();
                HAL.Power.ACPIReset();
            }
        }
    }

    public class System
    {
        public static void CrashSys()
        {
            OLDHAL.Power.ACPIReboot();
        }
    }
}