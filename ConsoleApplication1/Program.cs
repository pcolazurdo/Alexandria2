using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace AlexandriaCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new CommandLineOptions();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                // Values are available here
                Console.WriteLine("Filename: {0} - Recursive: {1}", options.ScanPath, options.IsRecursive);
                FileUtil fu = new FileUtil();
                fu.ProcessDirectory(options.ScanPath, options.IsRecursive);
            }   
        }
    }
}
