using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour,Event
{
    Buttonİnterface buttonİnterface;
    string _name;
    public void Handle()
    {
        
        buttonİnterface.Play(_name);
    }

    public ButtonEvent(Buttonİnterface buttonİnterface,string _name)
    {
        this.buttonİnterface = buttonİnterface;
        this._name = _name;
    }

    public bool HasEnded()
    {
        return false;
    }

    
    
}
