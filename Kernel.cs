using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using HAL = Cosmos.HAL;

namespace Glint
{
    public class Kernel : Sys.Kernel
    {

        string version = "2.2";
        //string stop;
        //string bootstop;

        protected override void BeforeRun()
        {
            try {
                Console.WriteLine("Kernel Is Loaded, Starting Glint...");
                Console.WriteLine("Glint " + version + " Is Starting...   ");
                try { HAL.Bootstrap.Init(); } catch
                {
                    // string bootstop = "B";
                }
                Console.WriteLine("Current Time: " + HAL.RTC.Hour + ":" + HAL.RTC.Minute + ":" + HAL.RTC.Second);
                Console.WriteLine("Starting GUI...");
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Sys.PCSpeaker.Beep(800);
                Console.Write("+----------------------------------Glint---------------------------------------+");
                Console.Write("+                                HELP MENU                                     +");
                Console.Write("+                                                                              +");
                Console.Write("+                              about - About                                   +");
                Console.Write("+                            cmd - Start Again                                 +");
                Console.Write("+                           shutdown - Shutdown                                +");
                Console.Write("+                             reboot - Reboot                                  +");
                Console.Write("+                              edit - Editor                                   +");
                Console.Write("+                           programs - Programs                                +");
                Console.Write("+                            info - Just Info.                                 +");
                Console.Write("+                           time - Current Time                                +");
                Console.Write("+                              sleep - Sleep                                   +");
                Console.Write("+----------------------------------Glint---------------------------------------+");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            } catch
            {
                // string stop = "BOOT_FAULT";
            }
        }
        protected override void Run()
        {
            try {
                Console.Write(">>>");
                var command = Console.ReadLine();

                if (command == "cmd")
                {
                    Console.WriteLine("Starting GUI...");
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("+----------------------------------Glint---------------------------------------+");
                    Console.Write("+                                HELP MENU                                     +");
                    Console.Write("+                                                                              +");
                    Console.Write("+                              about - About                                   +");
                    Console.Write("+                            cmd - Start Again                                 +");
                    Console.Write("+                           shutdown - Shutdown                                +");
                    Console.Write("+                             reboot - Reboot                                  +");
                    Console.Write("+                              edit - Editor                                   +");
                    Console.Write("+                           programs - Programs                                +");
                    Console.Write("+                            info - Just Info.                                 +");
                    Console.Write("+                           time - Current Time                                +");
                    Console.Write("+                              sleep - Sleep                                   +");
                    Console.Write("+----------------------------------Glint---------------------------------------+");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (command == "about")
                {
                    Console.WriteLine("Version: " + version);
                    Console.WriteLine("Made By Gordae.");
                }

                else if (command == "shutdown")
                {
                    Sys.PCSpeaker.Beep(500);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Shutting Down...");
                    HAL.Power.ACPIShutdown();
                }

                else if (command == "reboot")
                {
                    HAL.Power.CPUReboot();
                }

                else if (command == "edit")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.Write("+----------------------------------EDIT----------------------------------------+");
                    var text = Console.ReadLine();

                    Console.WriteLine("Starting GUI...");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("+----------------------------------Glint---------------------------------------+");
                    Console.Write("+                                HELP MENU                                     +");
                    Console.Write("+                                                                              +");
                    Console.Write("+                              about - About                                   +");
                    Console.Write("+                            cmd - Start Again                                 +");
                    Console.Write("+                           shutdown - Shutdown                                +");
                    Console.Write("+                             reboot - Reboot                                  +");
                    Console.Write("+                              edit - Editor                                   +");
                    Console.Write("+                           programs - Programs                                +");
                    Console.Write("+                            info - Just Info.                                 +");
                    Console.Write("+                           time - Current Time                                +");
                    Console.Write("+                              sleep - Sleep                                   +");
                    Console.Write("+----------------------------------Glint---------------------------------------+");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                else if (command == "programs")
                {

                    Console.WriteLine("A Few Programs To Entertain You When You Are Bored.");
                    Console.WriteLine("Note: These Programs Loop Forever.");
                    Console.WriteLine("Programs: lockshow, echo, crash");
                    var program = Console.ReadLine();
                    if (program == "lockshow")
                    {
                        while (true)
                        {
                            Console.WriteLine("+" + Sys.KeyboardManager.CapsLock + "+" + Sys.KeyboardManager.NumLock + "+" + Sys.KeyboardManager.ScrollLock + "+");
                        }
                    }

                    else if (program == "echo")
                    {
                        while (true)
                        {
                            var input = Console.ReadLine();
                            Console.WriteLine(input);
                        }
                    }

                    else if (program == "crash")
                    {
                        HAL.Power.ACPIReboot();
                    }
                }

                else if(command == "info")
                {

                    Console.WriteLine("Here Is Info, OK?");
                    Console.WriteLine("\nMonitor: " + Console.WindowWidth + "x" + Console.WindowHeight + " Standard VGA Monitor.");
                    Console.WriteLine("Keyboard: Random Keyboard");
                }
                
                else if(command == "time") {
                    Console.WriteLine("Current Time: " + HAL.RTC.Hour + ":" + HAL.RTC.Minute + ":" + HAL.RTC.Second);
                }

                else if(command == "sleep")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\n\n\n\n\n           The OS is still running, Press Any Key To Exit Sleep Mode.           ");
                    Console.Write("\n\n\n\n\n                                      ");
                    Console.ReadKey();
                    Console.WriteLine("Starting GUI...");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Sys.PCSpeaker.Beep(800);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("+----------------------------------Glint---------------------------------------+");
                    Console.Write("+                                HELP MENU                                     +");
                    Console.Write("+                                                                              +");
                    Console.Write("+                              about - About                                   +");
                    Console.Write("+                            cmd - Start Again                                 +");
                    Console.Write("+                           shutdown - Shutdown                                +");
                    Console.Write("+                             reboot - Reboot                                  +");
                    Console.Write("+                              edit - Editor                                   +");
                    Console.Write("+                           programs - Programs                                +");
                    Console.Write("+                            info - Just Info.                                 +");
                    Console.Write("+                           time - Current Time                                +");
                    Console.Write("+                              sleep - Sleep                                   +");
                    Console.Write("+----------------------------------Glint---------------------------------------+");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("'" + command + "' Is Not A Valid Command, File, Or Disk.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } catch(Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Sys.PCSpeaker.Beep(200);
                Console.Clear();
                Console.WriteLine("Your Computer Was About To Crash, So We Shut Down Glint To Prevent Damage.");
                Console.WriteLine("\nTry To Restart The Computer. If This Continues, This Can Be A");
                Console.WriteLine("Disk Error. Verify The DVD/CD With An ISO, Make A New Disk, ");
                Console.WriteLine("Or Reinstall Glint On Your Device.");
                Console.WriteLine("\n\n\n" + e.Message);
                Console.WriteLine("\nRefer To The Manual, Or Contact Your System Admin.");
                Console.CursorVisible = false;
                Console.ReadKey();
                HAL.Power.CPUReboot();
            }
        }
    }
}
