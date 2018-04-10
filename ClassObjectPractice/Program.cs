using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectPractice
{
    class Program
    {
        static void Calculate(params int[] numbers)
        {
            var s = 0;
            foreach (var item in numbers)
            {
                s += item;
            }
            Console.WriteLine(s);
        }
        static void print_word(string name, params string[] greets)
        {
            foreach (var greet in greets)
            {
                Console.WriteLine(name +" Hello "+greet);
            }
        }
        static void Main(string[] args)
        {
            /*
             * test object instializer 
            var lu = new Cat();
            var lv = new {Name="lv",Id=1 };
            Console.WriteLine(lv.Name+lv.Id);
            */
            Calculate(1, 2, 3, 4);
            Calculate(1,2);
            print_word("hua","hi","welcome","awesome","fabulous");
            print_word("lee",new string[] {"good","perfect","cool","amazing" });
            Console.ReadLine();
        }
    }
}
