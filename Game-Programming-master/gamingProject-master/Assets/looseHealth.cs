using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looseHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        healthBarScript.health -= 20f;
        Destroy(gameObject);
    }
}
