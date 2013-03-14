using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexandriaCLI.Domain
{
    public class HashStore
    {
        public Guid Id { get; set; }
        public string ParentName { get; set; }
        public string FileName { get; set; }
        public string HashValue { get; set; }
        public int FileSize { get; set; }
    }
}
