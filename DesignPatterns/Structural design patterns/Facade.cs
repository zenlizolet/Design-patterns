namespace DesignPatterns;
public class Client{
    Facade facade = new Facade();
    //de client kan de versimpelde methodes van de facade aanroepen
    public void Main(){
        facade.answerPhone();
        facade.makeCoffee();
        facade.printPage();
    }

}
public class Facade
{
    //zet alle subsystemen in de facade zodat je hun functionaliteit kan aanroepen
    system1 sublink1 = new system1();
    system2 sublink2 = new system2();
    system3 sublink3 = new system3();

    //maak versimpelde methodes voor de functionaliteiten die je wilt aanroepen
    public void answerPhone(){
        sublink1.Wait();
        sublink1.ReceiveCall();
    }
    public void printPage(){
        sublink2.checkInk();
        sublink2.checkPage();
        sublink2.printPage();
    }
    public void makeCoffee(){
        sublink3.heat();
        sublink3.pourBeans();
        sublink3.pourWater();
    }

}

public class system1{
    //alles is ff int en void want ik ben te lui om een heel subsystem te maken ofc
    int phone;
    int phoneline;
    int buttons;
    int numbers;
    public void makeCall(){}
    public void dialNumber(){}
    public void Wait(){}
    public void ReceiveCall(){}
}
public class system2{
    //alles is ff int en void want ik ben te lui om een heel subsystem te maken ofc
    int printer;
    int page;
    int ink;
    public void refillInk(){}
    public void refillPage(){}
    public void checkInk(){}
    public void checkPage(){}
    public void printPage(){}

}
public class system3{
    //alles is ff int en void want ik ben te lui om een heel subsystem te maken ofc
    int beans;
    int water;
    int machine;
    public void refillBeans(){}
    public void refillWater(){}
    public void heat(){}
    public void pourBeans(){}
    public void pourWater(){}

}