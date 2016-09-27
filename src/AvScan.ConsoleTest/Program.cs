﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvScan.ConsoleTest
{
    using System.Diagnostics;
    using WindowsDefender;
    using Avast;
    using AVG;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to scan");
            Console.ReadLine();
            var sw = Stopwatch.StartNew();

            var exeLocation = @"C:\Program Files (x86)\AVG\Av\avgscanx.exe";
            var fileToScan = args[0];

            var scanner = new AVGScanner(exeLocation);
            var result = scanner.Scan(fileToScan, 10000);
            sw.Stop();

            Console.WriteLine(result);
            Console.WriteLine($"Completed scan in {sw.ElapsedMilliseconds}ms");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
