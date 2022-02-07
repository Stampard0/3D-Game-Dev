using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public float kickDistance;
    public float kickForce;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") == true)
        {
            // Draw INTERACTION RAY
            Debug.DrawRay(transform.position, transform.forward * kickDistance, Color.blue, 1.5f);
            //Raycast in forward direction from camra
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, kickDistance) == true)
            {
                //Get direction player is facing
                Vector3 dir = new Vector3(transform.forward.x, 0, transform.forward.z);
                //Draw kick trajectory
                Debug.DrawRay(transform.position, dir * 3, Color.green, 1.5f);

                if(hit.collider.tag == "Ball") //is the thing we hit tagged as 'Ball'
                {
                    if(hit.collider.TryGetComponent(out Rigidbody rb) == true) //try to find a rigidbody on the ball
                    {
                        rb.AddForce(dir * kickForce, ForceMode.Impulse); //add an instant force to the ball
                    }
                }
            }
        }
    }
}
