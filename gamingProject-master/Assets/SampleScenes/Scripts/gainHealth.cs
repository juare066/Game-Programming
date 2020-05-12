using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gainHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<player>().GainHealth(1);
        ScoreScript.scoreValue += 20;
        Destroy (gameObject);
    }
}
