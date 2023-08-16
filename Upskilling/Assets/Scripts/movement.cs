using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardforce = 1000f;
    public float sidewaysforce = 50f;
    // Update is called once per frame
    void FixedUpdate()
    {
        //applies a forward force
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
