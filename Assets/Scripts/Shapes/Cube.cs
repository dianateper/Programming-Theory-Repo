using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    // POLYMORPHISM
    protected override void DisplayText()
    {
        message.text = "Message from cube\n name: " + Name + "\ncolor: " + ColorMaterial;
    }
}
