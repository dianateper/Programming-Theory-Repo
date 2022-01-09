using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] protected Text message;

    string name;

    string colorMaterial;

    Color color;

    // ENCAPSULATION
    public string Name { get { return name; } set { name = value; } }

    // ENCAPSULATION
    public Color Color { get { return color; } set { color = value; } }

    public string ColorMaterial { get { return colorMaterial; } set { colorMaterial = value; } }

    // ABSTRACTION
    protected abstract void DisplayText();

    private void OnMouseDown()
    {
        DisplayText();
    }

    private void Start()
    {
        colorMaterial = GetComponent<Renderer>().material.name;
        color = GetComponent<Renderer>().material.color;
        name = gameObject.name;
    }
}
