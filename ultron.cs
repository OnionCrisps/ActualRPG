using System;
using System.Threading;
using static System.Environment;
using static System.Console;
using static System.ConsoleColor;
using static System.ConsoleKey;
using System.Text; 
using System.Collections.Generic;
namespace ActualRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ForegroundColor = Green;
            BackgroundColor = Black;
            Title = "Depths Of The Deep";

            momentMenu.menuThangs();

             consUtils.testPath();
           
             // consUtils.openStart();

            // consUtils.iffyStuff();



        }

    }
}