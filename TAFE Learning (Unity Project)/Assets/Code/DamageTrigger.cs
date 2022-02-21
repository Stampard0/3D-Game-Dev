using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public float damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Health health) == true)
        {
            health.TakeDamage(damage);
        }
    }
}
