using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
