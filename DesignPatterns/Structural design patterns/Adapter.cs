namespace DesignPatterns;
//stel je hebt de bestaande klasse
public abstract class Shapes
{
    //deze klasse heeft een functie die een string teruggeeft
    public abstract void Display();
}
public class Rectangle : Shapes
{
    public override void Display()
    {
        //ff ter illustratie 
        Console.WriteLine("Rectangle");
    }
}
public class Circle : Shapes
{
    public override void Display()
    {
        //ff ter illustratie 
        Console.WriteLine("Circle");
    }
}

//stel nou dat ik een klasse vind van een andere student die ik wil gebruiken, deze student heeft een ster 
// ik wil ook een ster >:(, maar ik wil ook dat mijn ster de functie display heeft
// maar omdat ik een goede leerling ben en me graag aan de O in SOLID houdt, wil ik niet de klasse van de andere student aanpassen

//zie de onderstaande sterklasse van iemand anders
public class VreemdeStar
{
    //show doet eigenlijk hetzelfde als display, maar dan met een andere naam, en een andere return type/ interface, eigenlijk heel anders dus
    public string Show()
    {
        return "Star";
    }
}

// om dit op te lossen maak ik een adapter klasse (Ster) die de star klasse aanpast naar de interface van shapes
public class Star : Shapes
{
    //deze adapter klasse heeft een vreemde star als member
    // op deze manier kan ik de functie show van de vreemde star gebruiken in de functie display van de shapes interface
    private VreemdeStar vreemdeStar;
    public override void Display()
    {
        //hier gebruik ik de functie show van de vreemde star
        Console.WriteLine(vreemdeStar.Show());
    }
    //je  gebruikt de adapter dus eigenlijk als een soort verzamelplekje van de interface die je gebruikt, (shapes) en de klasse die je wil gebruiken (vreemde star).
    //De functies die de interface moet hebben kan je maken met de functies uit de "legacy" klasse
}
