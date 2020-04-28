using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider Cube)
    {
        FindObjectOfType<player>().TakeDamage(1);
        Destroy(Cube);
    }
}
