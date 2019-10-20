using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercol : MonoBehaviour
{
    public playerMovement movement;
   // public gameManger gameManger;

    private void OnCollisionEnter(Collision collisioninfo)
    {
       
        // Debug.Log(collisioninfo.collider.name);
        if (collisioninfo.collider.tag == "Obstacle")
        {
            // movement.enabled = false;
            //Debug.Log("we hit");
            FindObjectOfType<gameManger>().EndGame();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
