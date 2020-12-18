using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component as "rb"
    public Rigidbody rb;


    public float forwardForce = 2000f;
    public float sidewardForce = 500f;

    // We have marked this as "Fixed" Update because we
    // are using it to mess with physics
    void FixedUpdate()
    {
        // Add a forward force 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    
        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
        }

        if ( Input.GetKey("a"))
        {
            rb.AddForce(-sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
