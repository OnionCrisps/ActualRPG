using System;
using System.Threading;
using static System.Environment;
using static System.Console;
using static System.ConsoleColor; 
using System.Text;
using static System.ConsoleKey;
using System.Collections.Generic;

namespace ActualRPG
{
    class consUtils
    {
        public static void titleDesign()
        {
            ForegroundColor = Red;
            WriteLine(@"
                                                (           (               )  (         )   (                 )        (                (     
                                                )\ )        )\ )  *   )  ( /(  )\ )   ( /(   )\ )    *   )  ( /(        )\ )             )\ )  
                                                (()/(   (   (()/(` )  /(  )\())(()/(   )\()) (()/(  ` )  /(  )\()) (    (()/(   (    (   (()/(  
                                                /(_))  )\   /(_))( )(_))((_)\  /(_)) ((_)\   /(_))  ( )(_))((_)\  )\    /(_))  )\   )\   /(_)) 
                                                (_))_  ((_) (_)) (_(_())  _((_)(_))     ((_) (_))_| (_(_())  _((_)((_)  (_))_  ((_) ((_) (_))   
                                                |   \ | __|| _ \|_   _| | || |/ __|   / _ \ | |_   |_   _| | || || __|  |   \ | __|| __|| _ \  
                                                | |) || _| |  _/  | |   | __ |\__ \  | (_) || __|    | |   | __ || _|   | |) || _| | _| |  _/  
                                                |___/ |___||_|    |_|   |_||_||___/   \___/ |_|      |_|   |_||_||___|  |___/ |___||___||_|    
                    ");
        }

        public static void titleInvoke (string title)
        {
            ForegroundColor = ConsoleColor.Green;
             WriteLine("=====================");
             WriteLine("===="+title+"====");
             WriteLine("=====================\n ");
        }
        
        public static void openStart()
        {
              consUtils.titleDesign();

            ForegroundColor = ConsoleColor.DarkBlue;
                WriteLine("Press Enter To Initialize");
                
                consUtils.iffyStuff();
        }

        public static void iffyStuff()
        {
            ForegroundColor = ConsoleColor.Green;

            ConsoleKeyInfo keyPressed = ReadKey();
            if(keyPressed.Key == Enter)
            {
                Clear();
                Thread.Sleep(1000); 
                consUtils.titleInvoke("ITS DARK HERE");
            }
            
            else{Clear(); openStart();}

            Thread.Sleep(600);
            WriteLine("Would You Like To Continue?\n\nPress Y for 'Yes', Press N for 'No'");
            ConsoleKeyInfo keyRead = ReadKey();
            
            if(keyRead.Key == Y)
            {
                Clear();
                WriteLine("Wait 10 Seconds to exit");         
                    for (int i = 10; i > 0; i--)
                    {
                    WriteLine(i); 
                    Thread.Sleep(1000);
                    }             
                Thread.Sleep(500);
                Clear();
                WriteLine("ba bye :D!");
                Thread.Sleep(300);
                Exit(0);
            }

            else if(keyRead.Key == N)
            {
             Clear(); 
             WriteLine("Closing Game in:");    
                for (int i = 10; i > 0; i--)
                {
                  WriteLine(i); 
                  Thread.Sleep(1000);
                }
             Thread.Sleep(500);
             Environment.Exit(0);
            }

            else
            {
             Clear();
             WriteLine("Wrong Input :{ - Wait a second, let's try this again");
             Thread.Sleep(2500);
             Clear();
             openStart();
            }

        }

        public static void testPath()
        {
             WriteLine("Press <<Enter>> To Proceed");
            ConsoleKeyInfo keyPressy = Console.ReadKey(); 

            if(keyPressy.Key == Enter)
            {
                Clear();
                WriteLine("Test--Closing--");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
                else
                {
                  Clear();
                  momentMenu.menuThangs();
                  consUtils.testPath();
                }

        }
     }
}