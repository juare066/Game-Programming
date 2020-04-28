using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider Cube)
    {
        healthBarScript.health -= 20f;
        //Destroy(gameObject);
    }
}
