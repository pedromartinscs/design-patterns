﻿class Program
{
    static void Main(string[] args)
    {
        Originator originator = new Originator();
        Caretaker caretaker = new Caretaker();

        originator.SetState("State #1");
        originator.SetState("State #2");
        caretaker.Add(originator.SaveStateToMemento());

        originator.SetState("State #3");
        caretaker.Add(originator.SaveStateToMemento());

        originator.SetState("State #4");
        Console.WriteLine("Current State: " + originator.GetState());

        originator.GetStateFromMemento(caretaker.Get(0));
        Console.WriteLine("First saved State: " + originator.GetState());
        originator.GetStateFromMemento(caretaker.Get(1));
        Console.WriteLine("Second saved State: " + originator.GetState());
    }
}