using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using OLDHAL = Cosmos.HAL;

namespace Glint
{
    public class Kernel : Sys.Kernel
    {

        string version = "2.3";
        int MajorVer = 2;
        int MinorVer = 3;
        Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        string path = @"0:\";

        protected override void BeforeRun()
        {
            try {
                Console.WriteLine("Kernel Is Loaded, Starting Glint...");
                Console.WriteLine("Glint " + version + " Is Starting...   ");
                HAL.Init.Initalize();
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
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
                Console.Write("+                              edit - Editor                                   +");
                Console.Write("+                           programs - Programs                                +");
                Console.Write("+                            info - Just Info.                                 +");
                Console.Write("+                           time - Current Time                                +");
                Console.Write("+                          power - Power Options                               +");
                Console.Write("+                              dir - DirList                                   +");
                Console.Write("+                         readfile - Read A File.                              +");
                Console.Write("+                          mkfile - Make A File.                               +");
                Console.Write("+                          mkdir - Make A Folder                               +");
                Console.Write("+                        gotodir - Go To a Folder.                             +");
                Console.Write("+----------------------------------Glint---------------------------------------+");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            } catch(Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Sys.PCSpeaker.Beep(200);
                Console.Write("A Problem Occured During Starting Up, So Glint Has Been Shut Down To Prevent Any");
                Console.WriteLine("Damage. Contact Your System Admin.\n\n");
                Console.WriteLine(e.Message);
                Console.ReadKey();
                HAL.Power.ACPIReset();
            }
        }
        protected override void Run()
        {
            try
            {
                Console.Write(path + ">>>");
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
                    Console.Write("+                              edit - Editor                                   +");
                    Console.Write("+                           programs - Programs                                +");
                    Console.Write("+                            info - Information.                                 +");
                    Console.Write("+                           time - Current Time                                +");
                    Console.Write("+                          power - Power Options                               +");
                    Console.Write("+                              dir - DirList                                   +");
                    Console.Write("+                         readfile - Read A File.                              +");
                    Console.Write("+                          mkfile - New File.                               +");
                    Console.Write("+                          mkdir - New Folder                               +");
                    Console.Write("+                        gotodir - Go To a Folder.                             +");
                    Console.Write("+----------------------------------Glint---------------------------------------+");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (command == "about")
                {
                    Console.WriteLine("Version: " + version);
                    Console.WriteLine("Made By Gordae.\n");
                    long available_space = fs.GetAvailableFreeSpace("0:/");
                    string fs_type = fs.GetFileSystemType("0:/");
                    Console.WriteLine("Available Free Space: " + available_space);
                    Console.WriteLine("File System Type: " + fs_type);
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
                    Console.Write("+                              edit - Editor                                   +");
                    Console.Write("+                           programs - Programs                                +");
                    Console.Write("+                            info - Just Info.                                 +");
                    Console.Write("+                           time - Current Time                                +");
                    Console.Write("+                          power - Power Options                               +");
                    Console.Write("+                              dir - DirList                                   +");
                    Console.Write("+                         readfile - Read A File.                              +");
                    Console.Write("+                          mkfile - Make A File.                               +");
                    Console.Write("+                          mkdir - Make A Folder                               +");
                    Console.Write("+                        gotodir - Go To a Folder.                             +");
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
                        HAL.System.CrashSys();
                    }
                }

                else if (command == "info")
                {

                    Console.WriteLine("Here Is Info, OK?");
                    Console.WriteLine("\nMonitor: " + Console.WindowWidth + "x" + Console.WindowHeight + " Standard VGA Monitor.");
                    Console.WriteLine("Keyboard: Random Keyboard");
                }

                else if (command == "time")
                {
                    Console.WriteLine("Current Time: " + HAL.RTC.Hour + ":" + HAL.RTC.Minute + ":" + HAL.RTC.Second);
                    Console.WriteLine("Current Date: 20" + HAL.RTC.Year + "/" + HAL.RTC.Month + "/" + HAL.RTC.Day);
                }

                else if (command == "power")
                {
                    Console.WriteLine("Power Options: sleep, shutdown, reboot");
                    var PowerChoice = Console.ReadLine();
                    if (PowerChoice == "sleep")
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
                        Console.Write("+                              edit - Editor                                   +");
                        Console.Write("+                           programs - Programs                                +");
                        Console.Write("+                            info - Just Info.                                 +");
                        Console.Write("+                           time - Current Time                                +");
                        Console.Write("+                          power - Power Options                               +");
                        Console.Write("+                              dir - DirList                                   +");
                        Console.Write("+                         readfile - Read A File.                              +");
                        Console.Write("+                          mkfile - Make A File.                               +");
                        Console.Write("+                          mkdir - Make A Folder                               +");
                        Console.Write("+                        gotodir - Go To a Folder.                             +");
                        Console.Write("+----------------------------------Glint---------------------------------------+");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    else if (PowerChoice == "reboot")
                    {
                        HAL.Power.ACPIReset();
                    }

                    else if (PowerChoice == "shutdown")
                    {
                        Sys.PCSpeaker.Beep(500);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Shutting Down...");
                        HAL.Power.ACPIShutdown();
                    }
                }

                else if (command == "") { }

                else if (command == "dir")
                {
                    var directory_list = fs.GetDirectoryListing(path);
                    foreach (var directoryEntry in directory_list)
                    {
                        Console.WriteLine(directoryEntry.mName);
                    }
                }

                else if (command == "readfile")
                {
                    Console.WriteLine("Which File? ");
                    string file = Console.ReadLine();
                    var FTR = fs.GetFile(path + file);
                    var FTRS = FTR.GetFileStream();
                    if (FTRS.CanRead)
                    {
                        byte[] TTR = new byte[FTRS.Length];
                        FTRS.Read(TTR, 0, (int)FTRS.Length);
                        Console.WriteLine(Encoding.Default.GetString(TTR));
                    }

                    else
                    {
                        Console.WriteLine("Failed!");
                    }
                }

                else if (command == "mkfile")
                {
                    Console.WriteLine("What To Name The New File? ");
                    string mkfile = Console.ReadLine();
                    fs.CreateFile(path + mkfile);
                }

                else if (command == "mkdir")
                {
                    Console.WriteLine("What To Name The New File? ");
                    string mkdir = Console.ReadLine();
                    fs.CreateDirectory(path + mkdir);
                }

                else if (command == "gotodir")
                {
                    Console.WriteLine("What Folder? ");
                    string gotodir = Console.ReadLine();
                    path = path + gotodir + "\\";
                    
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
                HAL.Power.ACPIReset();
            }
        }
    }
}
