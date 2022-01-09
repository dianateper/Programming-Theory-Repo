using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    // POLYMORPHISM
    protected override void DisplayText()
    {
        message.text = "Message from cylinder\n name: " + Name + "\ncolor: " + ColorMaterial;
    } 
}
