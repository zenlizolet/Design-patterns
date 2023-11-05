namespace DesignPatterns;

public abstract class Skeleton
{
    //operation 1 en 2 worden altijd uitgevoerd op dezelfde manier, maar operation 3 en 4 kunnen verschillen want die moeten zelf worden geimplementeerd door subklassen
   public void Operation1 (){
         Console.WriteLine("Operation 1");
   }
   public void Operation2(){
        Console.WriteLine("Operation 2");
   }
   public abstract void Operation3();
   public abstract void Operation4();  

   public void TemplateMethod(){
        Operation1();
        Operation2();
        Operation3();
        Operation4();
   } 

}

public class ConcreteSolution : Skeleton
{
    public override void Operation3()
    {
        Console.WriteLine("Operation 4 los ik zo op >:(");
    }
    public override void Operation4()
    {
        Console.WriteLine("Operation 4 los ik zo op >:(");
    }
}

public class ConcreteSolution2 : Skeleton
{
    public override void Operation3()
    {
        Console.WriteLine("Wie dit leest is een sukkel");
    }
    public override void Operation4()
    {
        Console.WriteLine("Wie dit leest is een sukkel");
    }
}
// de implementaties roep je aan door de template method te gebruiken
// concreteSolution.TemplateMethod();