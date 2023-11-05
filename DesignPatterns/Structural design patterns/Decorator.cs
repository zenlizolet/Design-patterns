
public abstract class Component
{
        public abstract void Operation();
}

public class ConcreteComponent : Component
{
        public override void Operation()
        {
                Console.WriteLine("ConcreteComponent.Operation()");
        }
}
public  abstract class Decorator : Component
{
        protected Component component;

        public Decorator(Component component)
        {
                this.component = component;
        }

        public override void Operation(){}
}

public class ConcreteDecoratorA : Decorator
{
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        public override void Operation()
        {
                //voer de originele operation uit
                component.Operation();
                //voeg hier nog extra functionaliteit toe
                Console.WriteLine("You have been decorated :)");
        }
}