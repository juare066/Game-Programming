using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<player>().TakeDamage(1);
        Destroy(gameObject);
    }
}
