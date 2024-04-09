using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent :Event
{
    Buttonİnterface buttonİnterface;
    
    public void Handle()
    {
        
        buttonİnterface.Play();
    }

    public ButtonEvent(Buttonİnterface buttonİnterface)
    {
        this.buttonİnterface = buttonİnterface;
    }

    public bool HasEnded()
    {
        return false;
    }

    
    
}
