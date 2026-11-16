
using UnityEngine;
using TMPro;

public class VRKeypad3D : MonoBehaviour
{
    public TMP_Text display;

    public string correctPin = "1234";

    private string enteredPin = "";

    public Material Correct;
    public Material Wrong; 
    public Renderer KeypadRenderer;

    public void AddInput(string value)
    {
        if (value == "CLR")
        {
            enteredPin = "";
        }
        else if (value == "OK")
        {
            CheckPin();
            return;
        }
        else
        {
            if (enteredPin.Length >= 4)
                return;

            enteredPin += value;
        }

        UpdateDisplay();
    }

    void CheckPin()
    {
        if (enteredPin == correctPin)
        {
            Debug.Log("Correct PIN!");
            KeypadRenderer.material = Correct;
        }
        else
        {
            Debug.Log("Wrong PIN!");
            KeypadRenderer.material = Wrong;
        }

        enteredPin = "";
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        display.text = enteredPin;
    }
}
