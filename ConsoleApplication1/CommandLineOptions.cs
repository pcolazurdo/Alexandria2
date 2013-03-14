using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;
using log4net;


namespace AlexandriaCLI
{
    class CommandLineOptions
    {
        [Option('r', "recursive", DefaultValue = true,
        HelpText = "Indicate if recursive scanning is desired.")]
        public bool IsRecursive { get; set; }

        // omitting long name, default --verbose
        [Option(DefaultValue = ".",
        HelpText = "Specify the directory to scan.")]
        public string ScanPath { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
            (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
