
using System.Collections.Generic;
using Iterator.Iterator;


namespace Iterator.Aggregate
{
    
    //concreteAggregate
    public class NYPaper : INewspaper
    {
        private List<string> _reporters;

        public NYPaper()
        {
            _reporters = new List<string> {"Farid_NY", "Ramin_NY", "Zıba_NY", "Zeıneb_NY", "Elena_NY"}; 
        }

        public IIterator CreatIterator()
        {
            return new NYPaperIterator(_reporters);
        }

        
    }
}