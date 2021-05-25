using System;
using Iterator.Aggregate;
using Iterator.Iterator;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyt = new NYPaper();
            INewspaper lat = new LaPaper();

            IIterator nypIterator = nyt.CreatIterator();
            IIterator lapIterator = lat.CreatIterator();
            
            Console.WriteLine("---------  NYPaper");
            PrintReporters(nypIterator);
            Console.WriteLine("---------  LAPaper");
            PrintReporters(lapIterator);

            static void PrintReporters(IIterator iterator)
            {
                iterator.First();
                while (!iterator.IsDone())
                {
                    Console.WriteLine(iterator.Next());
                }
                {
                    
                }
            }
            
            
        }
    }
}