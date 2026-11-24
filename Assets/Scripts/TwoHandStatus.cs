
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class TwoHandStatus : MonoBehaviour
{
    public bool bothHandsGrabbing;

    private XRGrabInteractable grab;
    void Awake()
    {
        grab = GetComponent<XRGrabInteractable>();
    }

    void Update()
    {
        if (grab == null)
            return;

        bothHandsGrabbing =
            grab.interactorsSelecting.Count >= 2;
    }
}
