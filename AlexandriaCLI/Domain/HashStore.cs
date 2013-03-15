using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexandriaCLI.Domain
{
    public class HashStore
    {
        public virtual Guid Id { get; set; }
        public virtual string ParentName { get; set; }
        public virtual string FileName { get; set; }
        public virtual string HashValue { get; set; }
        public virtual int FileSize { get; set; }
    }
}
