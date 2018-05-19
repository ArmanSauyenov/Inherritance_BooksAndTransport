using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BooksAndTransport.Classes
{
    public class WebSites : Publishings
    {
        public string Link { get; set; }
        public string Annotation { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Source: {SourceName} \nAuthor: {AuthorName} \n" +
                $"Link: {Link} \nAnnotation: {Annotation} \n");
        }
    }
}
