using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo_Composition2.Entities;

namespace Estudo_Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a Nice Trip!");
            Comment c2 = new Comment("Wow That's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelling to New Zealand",
                "Im going to visit this wonderful country!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Nice Movie!");
            Comment c4 = new Comment("Good One!");
            Post p2 = new Post(
                DateTime.Parse("25/08/2018 15:44:21"),
                "Watching 'Cars 2' ",
                "It's a Funny Movie!",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
