namespace DesignPatterns;

//dit is de basis interface die elke component moet hebben
public interface Component
{
    public void SomeOperation();
}

// dit is het leaf component, dit is een component die geen children heeft, deze hoeft alleen maar de required SomeOperation functie te implementeren
public class Leaf : Component
{
    public void SomeOperation()
    {
        Console.WriteLine("Leaf");
    }
}

//dit is de composite, dit is een component die andere components kan bevatten
// deze moet dus ook de required SomeOperation functie implementeren maar daarbij ook nog een Add, Remove en GetChildren functie voor functionaliteit
public class Composite: Component
{
    private List<Component> children = new List<Component>();
     public void SomeOperation()
    {
        foreach (Component component in children)
        {
            component.SomeOperation();
        }
    }
    public void Add(Component component)
    {
        children.Add(component);
    }
    public void Remove(Component component)
    {
        children.Remove(component);
    }

    public List<Component> GetChildren()
    {
        return children;
    }   

}