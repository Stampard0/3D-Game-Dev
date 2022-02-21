using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") == true)
        {
            RaycastHit hit; // this can only be accessed in this if statment
            if(Physics.Raycast(transform.position, transform.forward, out hit, distance) == true)
            {
                Debug.DrawRay(transform.position, transform.forward * distance, Color.blue, 0.2f);
                if(hit.collider.TryGetComponent(out Interactable interaction) == true)
                {
                    interaction.Activate();
                }
            }
        }
    }
}

public abstract class Interactable : MonoBehaviour
{
    public abstract void Activate();
}