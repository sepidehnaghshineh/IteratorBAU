namespace Iterator.Aggregate
{
    public interface IIterator
    {
        void First(); //sets current element to the first element.
        string Next(); //Advances current to the next element.
        bool IsDone(); //check if end of collection.
        string CurrentItem(); //returns the current element.
    }
}