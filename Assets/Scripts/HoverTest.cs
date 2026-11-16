using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.UI;

public class HoverTest : MonoBehaviour
{
    public XRSocketInteractor socketInteractor;
    public GameObject interactableObject;
    public bool rightItem;
    public GameObject test;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<Collider>().enabled == false && rightItem)
        {
            Debug.Log("Hovering over interactable object: " + interactableObject.name);
            test.SetActive(true);
        }
        else
        {
            test.SetActive(false);
        }
    }   
    public void ColliderOff()
    {
        this.GetComponent<Collider>().enabled = false;
    }
    public void ColliderOn()
    {
        this.GetComponent<Collider>().enabled = true;
        rightItem = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            rightItem = true;
            // You can add additional logic here, such as highlighting the object or enabling a UI element
        }
        else
        {
            rightItem = false;
        }
    }
}
