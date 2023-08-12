using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardforce = 2000f;

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
    }
}
