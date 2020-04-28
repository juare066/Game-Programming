using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gainHealthObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        FindObjectOfType<player>().GainHealth(1);
        Destroy (col);
    }
}
