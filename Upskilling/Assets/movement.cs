using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardforce = 1000f;
    public float sidewaysforce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        //applies a forward force
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0);
        }
    }
}
