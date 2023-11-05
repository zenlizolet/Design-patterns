namespace DesignPatterns;

//Dit is de singleton klasse, de klasse waar maar 1 instantie van kan bestaan
public class Singleton
{
    //de instantie van de klasse wordt bewaard als "instance"
    private static Singleton instance;

    //de constructor is private zodat er geen instanties van de klasse kunnen worden gemaakt buiten de klasse zelf
    private Singleton()
    {
    }

    //de klasse bevat een publieke functie die de instantie van de klasse teruggeeft, als er nog geen instantie bestaat wordt er een aangemaakt 
    public static Singleton Getinstance()
    {
        //check of de instantie al bestaat, zo nee maak een nieuwe aan. Dat kan omdat de constructor private is, maar we zijn binnen de klasse dus dat is geen probleem
        if (instance == null){
            instance = new Singleton();
        }
        //geef de bestaande instantie terug
        return instance;
    }
}
