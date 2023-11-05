using System.Data;
using System.Net.Mail;
using Microsoft.VisualBasic;

//gekke error idk why
Subject subject = new ConcreteSubject();
ConcreteObserver observer = new ConcreteObserver();
subject.attach(observer);
subject.detach(observer);
subject.notify();


//first we make an abstract subject class that defines the attach, detach and notify methods that every observable subject should have
public abstract class Subject{
    public void attach(Observer o){}
    public void detach(Observer o){}
    public void notify(){}
}

//then we make a concrete subject class that implements the abstract subject class and makes a state variable that keeps track of the state of the subject
public class ConcreteSubject: Subject{
    private State subjectState;
    public State getState(){
        return this.subjectState;
    }
    public void setState(State s){
        this.subjectState = s;
    }
}

//then we make an  observer interface that defines the update method that every observer should have
public interface Observer
{
    public void update();
}

//then we implement the observer interface in a concrete observer class
public class ConcreteObserver: Observer{
    private State observerState;
    private ConcreteSubject subject;
    public void update(){
        this.observerState = this.subject.getState();
    }
   
}

//ff een state klasse omdat ik die state errors krijg
public class State{
    public int state;
    public State(int state){
        this.state = state;
    }
}