using UnityEngine;

public class KeyPadButton : MonoBehaviour
{
    public string buttonValue;

    public VRKeypad3D keypad;

    public void Press()
    {
        keypad.AddInput(buttonValue);
    }
}
