namespace DesignPatterns;
// work in progress
// dit is de interface voor de verschillende soorten iterators
public interface Iterator
{
    public int getNext();
    public bool hasMore();
}
/*
public class ConcreteIterator : Iterator
{
    public ConcreteCollection collection;
    private int iterationState;

//hier nog ff naar kijken

    public ConcreteIterator(ConcreteCollection collection)
    {
        this.collection = c;
        this.iterationState = 0;
    }

    public void getNext()
    {
        this.iterationState++;
    }

    public bool hasMore()
    {
        return this.iterationState < this.aggregate.getSize();
    }
}

//dit is de interface die de collectie implementeert
interface IterableCollection{
    public Iterator createIterator();
}

//dit is de concrete collectie
interface ConcreteCollection : IterableCollection
{
    public Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }
}*/