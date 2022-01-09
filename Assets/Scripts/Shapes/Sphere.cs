using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    // POLYMORPHISM
    protected override void DisplayText()
    {
        message.text = "Message from sphere\n name: " + Name + "\ncolor: " + ColorMaterial;
    }
}
