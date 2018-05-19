using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BooksAndTransport
{
    public class Books : Publishings
    {
        private string _publishment;

        public DateTime PublishDate { get; set; }
        public string Publishment
        {
            get { return _publishment; }
            set { _publishment = value; }
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Source: {SourceName} \nAuthor: {AuthorName} \n" +
                $"Publish date: {PublishDate} \nPublishment: {Publishment} \n");
        }
    }
}
