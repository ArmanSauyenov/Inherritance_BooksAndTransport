using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BooksAndTransport
{
    public abstract class Publishings
    {
        public string SourceName { get; set; }
        public string AuthorName { get; set; }

        public abstract void PrintInfo();
    }
}
