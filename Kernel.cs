using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using HAL = Cosmos.HAL;

namespace Glint
{
    public class Kernel : Sys.Kernel
    {

        string version = "2.1";

        protected override void BeforeRun()
        {
            Console.WriteLine("Kernel Is Loaded, Starting Glint...");
            Console.WriteLine("Glint " + version + " Is Starting...");
            Console.Write("Starting Sound...   ");
            Cosmos.System.PCSpeaker.Beep(500); // Beeps At You To Let You Know That Sound Is Working.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("[OK]\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Press Any Key To Start Glint.");
            Console.ReadKey();

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
            Console.Write("+----------------------------------Glint---------------------------------------+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
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

                else if (command == "info")
                {
                    Console.WriteLine("Here Is Info, OK?");
                    Console.WriteLine("\nMonitor: " + Console.WindowWidth + "x" + Console.WindowHeight + " Standard VGA Monitor.");
                    Console.WriteLine("Keyboard: Random Keyboard");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not A Valid Command.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } catch
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Sys.PCSpeaker.Beep(200);
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                Console.Write("                                  !GLINT!                                       ");
                Console.Write(" Your Computer Was About To Crash, So We Shut Down Glint To Prevent Any Damage. ");
                Console.Write("     Please Turn Off Your Computer And Turn It Back On. If This Continues,      ");
                Console.Write("          Contact Your System Administrator Or Mail Gordae Support.             ");
                Console.ReadKey();
                HAL.Power.CPUReboot();
            }
        }
    }
}