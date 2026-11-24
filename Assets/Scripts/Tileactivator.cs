using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Tileactivator : MonoBehaviour
{
    public Rigidbody RGTile;
    public TwoHandStatus TwoHandStatus;
    public GameObject Crowbar; 
    public GameObject Wall2;
    public bool Puzzle2Answered;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        RGTile.constraints = RigidbodyConstraints.FreezeAll;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Crowbar") && TwoHandStatus.bothHandsGrabbing)
        {
            RGTile.constraints = RigidbodyConstraints.None;
            GetComponent<XRGrabInteractable>().enabled = true;
            Puzzle2Answered = true;
            Wall2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
