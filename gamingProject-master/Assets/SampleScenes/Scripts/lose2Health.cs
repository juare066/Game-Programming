using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose2Health : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<player>().TakeDamage(2);
        Destroy(gameObject);
    }
}
