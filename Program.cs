using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testrepo
{
    class Program
    {
        static void Main(string[] args)
        {
            //onze repository test
            Console.WriteLine("Laten we beginnen!!!");
            //verandering door stefan

            Console.WriteLine("Test hallo! David hier.");
            Console.ReadLine();

            // test comment
            Console.WriteLine("Mark");
            Console.WriteLine("Try");

            Console.WriteLine("lorem ipsum");
            Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("nummer: {0}", Convert.ToString(i + 1));
            }
            Console.ReadLine();
        }
    }
}