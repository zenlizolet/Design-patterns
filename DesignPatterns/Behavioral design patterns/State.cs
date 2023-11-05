using System.Xml.Serialization;

namespace DesignPatterns;

//als eerste de context, deze bepaalt in de eerste plaats wat de state van het programma is, belangrijk! niet vergeten
Context context = new Context(new State1());


public class Context{
    public State state;
    public Context(State state)
    {
        this.state = state;
    }
    public void goNext(){}
}

//eerst maken we een interface/abstracte klasse voor de verschillende states
public abstract class State
{
    public abstract void goNext(); //deze wordt geimplementeerd in de concrete states en aangeroepen in de states/context
}

//dan maken we de concrete states
public class State1 : State
{

    public override void goNext()
    {
        Context.state = new State2();
    }
}

public class State2 : State
{
    public override void goNext()
    {
        Context.state = new State3();

    }
}

public class State3 : State
{
    public override void goNext()
    {
        Context.state = new State1();
    }
}