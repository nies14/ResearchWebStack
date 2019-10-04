using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchWebStack.BusinessLayer.Model
{
    class NodeJs
    {
        [Option('n', "name", Required = true)]
        public string Name { get; set; }
        [Option('p', "path")]
        public string FilePath { get; set; }
        [Option('r', "redirect")]
        public string RedirectPath { get; set; }
    }
}
