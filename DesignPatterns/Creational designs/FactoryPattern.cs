namespace DesignPatterns;
//de Factory, dit is de abstracte klasse die het het "recept" van elke concrete factory definieert
public abstract class Factory
{
   //maak eerst een Create functie, dit is een functie die de concrete factories zal aanmaken waarbij de specifieke producten per factory worden gebruikt.
   public abstract Product MakeProduct();

   //vervolgens kan je de MakeProduct functie gebruiken om een product te maken en zijn methodes te gebruiken
    public void UseProduct(){
        Product product = MakeProduct();
        product.DoSomething();
    } 
}

//de concrete factories
public class ConcreteFactoryA : Factory
{
    //de concrete factories moeten de abstracte methode uit de factory superklasse implementeren
   public override Product MakeProduct()
   {
      return new ConcreteProductA();
   }
}
public class ConcreteFactoryB : Factory
{
    //de concrete factories moeten de abstracte methode uit de factory superklasse implementeren
   public override Product MakeProduct()
   {
      return new ConcreteProductB();
   }
}

//de abstracte klasse van de producten die de factories moeten maken
public abstract class Product
{
   public abstract void DoSomething();
}

//de concrete producten
public class ConcreteProductA : Product
{
    // dit zijn de product specifieke methodes die de factories kunnen gebruiken in UseProduct()
   public override void DoSomething()
   {
      Console.WriteLine("I'm a concrete product A");
   }
}
public class ConcreteProductB : Product
{
    // dit zijn de product specifieke methodes die de factories kunnen gebruiken in UseProduct()
   public override void DoSomething()
   {
      Console.WriteLine("I'm a concrete product B");
   }
}