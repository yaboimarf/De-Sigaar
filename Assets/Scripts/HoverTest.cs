using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.UI;

public class HoverTest : MonoBehaviour
{   public GameObject interactableObject;
    public bool hasRightItem;
    public string objectTag;
    public bool sendSignal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectTag = interactableObject.tag;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<SphereCollider>().enabled == false && hasRightItem)
        {
            sendSignal = true;
        }
        else
        {
            sendSignal = false;
        }
    }   
    public void ColliderOff()
    {
        this.GetComponent<SphereCollider>().enabled = false;
        
    }
    public void ColliderOn()
    {
        this.GetComponent<SphereCollider>().enabled = true;
        hasRightItem = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(objectTag))
        {
            hasRightItem = true;
        }
        else
        {
            hasRightItem = false;
        }
    }
}
