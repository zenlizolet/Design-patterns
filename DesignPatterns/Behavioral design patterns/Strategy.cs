namespace DesignPatterns;

//de context bevat een strategy en roept de buildroute methode aan van deze strategy
public class Context{
    Strategy strategy;
    public void BuildRoute(){
        strategy.BuildRoute();
    }
}
//de strategy interface is een abstracte klasse die zegt dat elke strategy een buildroute methode moet hebben, deze wordt namelijk gebruikt in de context
public abstract class Strategy
{
    public abstract void BuildRoute();
}

//diverse verschillende concrete strategies
public class ConcStrategy1 : Strategy
{
    public override void BuildRoute()
    {
        Console.WriteLine("Building route for car");
    }
}
public class ConcStrategy2 : Strategy
{
    public override void BuildRoute()
    {
        Console.WriteLine("Building route for bike");
    }
}

public class ConcStrategy3 : Strategy
{
    public override void BuildRoute()
    {
        Console.WriteLine("Building route for bus");
    }
}