using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            dictionary.AddElements(1, "Value 1");
            dictionary.AddElements(2, "Value 2");
            dictionary.AddElements(3, "Value 3");
            dictionary.AddElements(4, "Value 4");
            dictionary.AddElements(5, "Value 5");
            dictionary.AddElements(6, "Value 6");

            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary.NumberOfElements);

            foreach (var element in dictionary.dictionary)
            {
                Console.Write(element);
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
