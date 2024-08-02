using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;

    public float sideForce = 500f;

    public gameManger gm;

    public PlayerCollision pm;

    
    

   

    void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime,0,0);

        if(Input.GetKey("d"))
        {
            rb.AddForce(0,0,-forwardForce * Time.deltaTime);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        }

        if(rb.position.y < -1f)
        {
            Object.FindFirstObjectByType<gameManger>().EndGame();

        }

    }
   
}
