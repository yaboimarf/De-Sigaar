
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
        //if (collision.gameObject.GetComponent<GameObject>() != null)
        //{
        //    collision.gameObject.transform.position = ReturnPoint.position;
        //}
        collision.gameObject.transform.position = ReturnPoint.position;
    }
}
