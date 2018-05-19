using Inheritance_BooksAndTransport.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BooksAndTransport
{
    public enum Book { SomeBook, AnyBook, GoodBook, BestBook, NewBook }
    public enum Publish { PublisherOne, PublisherTwo, PublisherThree, PublisherFour, PublisherFive }
    public enum Author { BestAuthor, GoodAuthor, NewAuthor, PopularAuthor, OldAuthor }
    public enum Mag { EnglandMagazine, RussiaMagazine, GreeceMagazine, KazakhstanMagazine, JapanMagazine }
    public enum Link { www_best_com, www_new_com, www_old_com, www_world_com, www_metropol_com }

    public class Generator
    {
        private Random rand = new Random();
        public List<Publishings> pub;

        public Generator()
        {
            pub = new List<Publishings>();
        }

        public void GenerateBook()
        {
            Books b = new Books();
            b.SourceName = ((Book)rand.Next(0, 5)).ToString();
            b.AuthorName = ((Author)rand.Next(0, 5)).ToString();
            b.PublishDate = DateTime.Now.AddMonths(-rand.Next(1, 24));
            b.Publishment = ((Publish)rand.Next(0, 5)).ToString();

            pub.Add(b);
        }

        public void GenerateArticle()
        {
            Articles a = new Articles();
            a.SourceName = ((Book)rand.Next(0, 5)).ToString();
            a.AuthorName = ((Author)rand.Next(0, 5)).ToString();
            a.MagazineName = ((Mag)rand.Next(0, 5)).ToString();
            a.MagNumber = rand.Next(0, 300);
            a.PublishDate = DateTime.Now.AddMonths(-rand.Next(1, 24));

            pub.Add(a);
        }

        public void GenerateWeb()
        {
            WebSites w = new WebSites();
            w.SourceName = ((Book)rand.Next(0, 5)).ToString();
            w.AuthorName = ((Author)rand.Next(0, 5)).ToString();
            w.Link = ((Link)rand.Next(0, 5)).ToString();
            w.Annotation = "Not available";

            pub.Add(w);
        }

        public void PrintAll()
        {
            foreach (Publishings item in pub)
            {
                item.PrintInfo();
            }
        }

        public void FindAuthor(string aut)
        {
            foreach (Publishings item in pub)
            {
                if (item.AuthorName == aut)
                    Console.WriteLine($" Author was found {item.AuthorName}");
                else
                    Console.WriteLine("Invalid author name");
            }
        }
    }
}
