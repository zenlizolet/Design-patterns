
//de Factory, dit is de abstracte klasse die het het "recept" van elke concrete factory definieert
public abstract class Factory
{
   //maak eerst MEERDERE Create functies, dit zijn functies die de concrete factories zal aanmaken waarbij de specifieke product groepen per factory worden gemaakt.
   public abstract Product MakeProduct();
    public abstract OtherProduct MakeOtherProduct();

   //vervolgens kan je de MakeProduct functie gebruiken om een product te maken en zijn methodes te gebruiken
    public void UseProduct(){
        Product product = MakeProduct();
        OtherProduct otherProduct = MakeOtherProduct();
        product.DoSomething();
        otherProduct.DoSomething();
    } 
}

//de concrete factories
public class ConcreteFactoryA : Factory
{
    //de concrete factories moeten de abstracte methodes uit de factory superklasse implementeren
   public override Product MakeProduct()
   {
      return new ConcreteProductA();
   }
   public override OtherProduct MakeOtherProduct()
   {
      return new ConcreteOtherProductC();
   }
}
public class ConcreteFactoryB : Factory
{
    //de concrete factories moeten de abstracte methodes uit de factory superklasse implementeren
   public override Product MakeProduct()
   {
      return new ConcreteProductB();
   }
    public override OtherProduct MakeOtherProduct()
    {
        return new ConcreteOtherProductD();
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

public abstract class OtherProduct
{
   public abstract void DoSomething();
}

//de concrete andere producten, dit is ff vaag maar kijk naar het diagram, dit is om productgroepen te simuleren :)
public class ConcreteOtherProductC : OtherProduct
{
    // dit zijn de product specifieke methodes die de factories kunnen gebruiken in UseProduct()
   public override void DoSomething()
   {
      Console.WriteLine("I'm a concrete product C");
   }
}
public class ConcreteOtherProductD : OtherProduct
{
    // dit zijn de product specifieke methodes die de factories kunnen gebruiken in UseProduct()
   public override void DoSomething()
   {
      Console.WriteLine("I'm a concrete product D");
   }
}