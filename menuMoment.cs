using System;
using System.Threading;
using static System.Environment;
using static System.ConsoleColor; 
using static System.Console;
using System.Text;
using static System.ConsoleKey;
using System.Collections.Generic;

namespace ActualRPG
{
  class momentMenu{
        private int SelectedIndex;
        private string[] Selections;
        private string Prompt;

        public momentMenu(string prompt, string[] selections)
        {
           Prompt = prompt;
           Selections = selections;
           SelectedIndex = 0;
        }

        public void displayMenu()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Selections.Length; i++)
            {
                string selectedOption = Selections[i];
                WriteLine($"|| {selectedOption} ||");

            }
        }


            public static void menuThangs()
            {
               string prompt = @"               (           (               )  (         )   (                 )        (                (     
                                                )\ )        )\ )  *   )  ( /(  )\ )   ( /(   )\ )    *   )  ( /(        )\ )             )\ )  
                                                (()/(   (   (()/(` )  /(  )\())(()/(   )\()) (()/(  ` )  /(  )\()) (    (()/(   (    (   (()/(  
                                                /(_))  )\   /(_))( )(_))((_)\  /(_)) ((_)\   /(_))  ( )(_))((_)\  )\    /(_))  )\   )\   /(_)) 
                                                (_))_  ((_) (_)) (_(_())  _((_)(_))     ((_) (_))_| (_(_())  _((_)((_)  (_))_  ((_) ((_) (_))   
                                                |   \ | __|| _ \|_   _| | || |/ __|   / _ \ | |_   |_   _| | || || __|  |   \ | __|| __|| _ \  
                                                | |) || _| |  _/  | |   | __ |\__ \  | (_) || __|    | |   | __ || _|   | |) || _| | _| |  _/  
                                                |___/ |___||_|    |_|   |_||_||___/   \___/ |_|      |_|   |_||_||___|  |___/ |___||___||_|  ";
               
                string[] selections = {"Play","Restart","Exit"};
            
                momentMenu startMenu = new momentMenu(prompt, selections);
                startMenu.displayMenu();

            }


     }  

}