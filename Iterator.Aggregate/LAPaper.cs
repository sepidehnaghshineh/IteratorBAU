using Iterator.Iterator;

namespace Iterator.Aggregate
{
    
        //concreteAggregate
        public class LaPaper : INewspaper 
        {
            private readonly string[] _reporters;

            public LaPaper()
            {
                _reporters = new[] {
                    "Sara_LA",
                    "John_LA",
                    "Ali_LA",
                    "Noor_LA", 
                    "Sahar_LA"};
            }

            public IIterator CreatIterator()
            {
                return new LAPaperIterator(_reporters);
            }

            
        }
}
