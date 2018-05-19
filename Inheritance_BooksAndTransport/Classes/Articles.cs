using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BooksAndTransport.Classes
{
    public class Articles : Publishings
    {
        public string MagazineName { get; set; }
        public int MagNumber { get; set; }
        public DateTime PublishDate { get; set; }


        public override void PrintInfo()
        {
            Console.WriteLine($"Source: {SourceName} \nAuthor: {AuthorName} \n" +
                $"Magazine name: {MagazineName} \nMagazine number: {MagNumber} \n" +
                $"Publish date: {PublishDate} \n");
        }




    }
}
