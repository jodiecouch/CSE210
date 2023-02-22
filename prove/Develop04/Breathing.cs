using System;

public class Breathing : Game
{
    const string _name = "Breathe";
    const string _description = "This activity will help you relax by walking your through breathing in and out slowly.Clear your mind and focus on your breathing.";
    const string _breatheIn = "Breathe in ...";
    const string _breathOut = "Breathe out ...";
    public Breathing(string name = _name, string description = _description) : base(name, description)
    { }

    public void Play()
    {
        this.ShowStartMessage();
        //Do for duration - something like do while this.Timer ???
        //breath in
        //spinner
        //breathe out 
        //spinner
        this.ShowEndMessage();
    }

}