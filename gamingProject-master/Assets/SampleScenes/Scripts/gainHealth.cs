using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gainHealth : MonoBehaviour
{
    private AudioSource collectedSound; // sound to be played when collecting co

    private void OnTriggerEnter(Collider other)
    {
//        collectedSound.Play();
        FindObjectOfType<player>().GainHealth(1);
        ScoreScript.scoreValue += 20;
        Destroy(gameObject);

    }
}
