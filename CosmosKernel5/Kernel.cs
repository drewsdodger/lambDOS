using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosKernel5
{
    public class commands
    {
    public static void info(string arg){Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;Console.WriteLine(arg); Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White; }
    
        /// Standard commands
        public static void command(string arg){
            if (arg == "info")
            {Console.Write("Coded by "); Console.BackgroundColor = ConsoleColor.DarkBlue; Console.Write("DD2/MD0"); Console.Write(" "); Console.BackgroundColor = ConsoleColor.Black; Console.Write("and designed by ");
             Console.BackgroundColor = ConsoleColor.DarkGreen; Console.Write("DD2/MD0/Rock Muncher"); Console.BackgroundColor = ConsoleColor.Black; Console.Write("");}
        
            if (arg == "clr") { Console.Clear(); }
            if (arg == "highlight") { Console.BackgroundColor = ConsoleColor.White; }
            if (arg == "accessibility.dyslexia") 
            { if (Console.BackgroundColor == ConsoleColor.Yellow) { Console.BackgroundColor = ConsoleColor.Black; }
              if (Console.BackgroundColor == ConsoleColor.Black) { Console.BackgroundColor = ConsoleColor.Yellow; }}


        }
       // public static void colterm(string arg)
       // {
       //     if (arg == "") { }
      //  } }
            





        public class Kernel : Sys.Kernel
        {   protected override void BeforeRun()
            {info("Welcome to lambDOS V0.05");}
            protected override void Run()
            {Console.Write(">"); var cmd = Console.ReadLine(); command(cmd);}
        }}}

