using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Interactable
{
    [Range(0, 10)]
    public float amount;
    public override void Activate()
    {
        Health.Instance.TakeDamage(-amount);
        gameObject.SetActive(false);
    }
}
