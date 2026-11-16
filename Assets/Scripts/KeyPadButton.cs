using UnityEngine;

public class KeyPadButton : MonoBehaviour
{
    public string buttonValue;

    public VRKeypad3D keypad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Press()
    {
        keypad.AddInput(buttonValue);
    }
}
