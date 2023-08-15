using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public movement move;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "obstacle")
        {
            move.enabled = false;
        }
    }
}
