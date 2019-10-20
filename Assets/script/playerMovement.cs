using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 1000f;
    public float sidewayforce = 1000f;
  

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManger>().EndGame();
        }
    }
   
}
