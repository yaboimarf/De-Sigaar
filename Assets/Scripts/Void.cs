
using UnityEngine;

public class Void : MonoBehaviour
{
    public Transform ReturnPoint;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.position = ReturnPoint.position;
    }
}
