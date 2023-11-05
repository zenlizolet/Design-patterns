// abstraction
public abstract class Plumber {
    protected Graphics Graphics;

    protected Plumber(Graphics graphics) {
        Graphics = graphics;
    }

    public abstract void Draw();
}

public class Mario : Plumber {
    public Mario(Graphics graphics) : base(graphics) { }

    public override void Draw() {
        Graphics.SetColor("Red");
    }
}
public class Luigi : Plumber 
{
    public Luigi(Graphics graphics) : base(graphics) { }

    public override void Draw() 
    {
        Graphics.SetColor("Green");

    }
    
}
// implementation 
// de abstracte klassen kunnen op verschillende manieren wornden geimplementeerd, op iOS en op Android, elk van deze implementaties heeft een eigen Graphics klasse
public abstract class Graphics 
{
    // dit is een methode die elke implementatie moet hebben
    public abstract void SetColor(string kleur);
}

//dit zijn de concrete implementations
public class AndroidGraphics : Graphics 
{
    public override void SetColor (string kleur){}
}
public class iOSGraphics : Graphics 
{
    public override void SetColor (string kleur){}
}