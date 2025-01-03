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
    public static void command(string arg){
            if (arg == "info")
            {
                Console.Write("Coded by "); Console.BackgroundColor = ConsoleColor.DarkBlue; Console.Write("DD2/MD0"); Console.Write(" "); Console.BackgroundColor = ConsoleColor.Black; Console.Write("and designed by ");
                Console.BackgroundColor = ConsoleColor.DarkGreen; Console.Write("DD2/MD0/Rock Muncher"); Console.BackgroundColor = ConsoleColor.Black; Console.Write("");
            }}
        public class Kernel : Sys.Kernel
        {   protected override void BeforeRun()
            {info("Welcome to lambDOS");}
            protected override void Run()
            {Console.Write(">"); var cmd = Console.ReadLine(); command(cmd);}
        }}}

