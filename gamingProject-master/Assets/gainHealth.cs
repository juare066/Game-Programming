using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gainHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        healthBarScript.health += 20f;
        Destroy (gameObject);
    }
}
