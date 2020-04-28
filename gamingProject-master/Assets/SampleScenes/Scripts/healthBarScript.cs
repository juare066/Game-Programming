using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthBarScript : MonoBehaviour
{
    Image HealthBar;
    float maxHealth = 100f;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            Debug.Log("Player is Dead");
            FindObjectOfType<GameManager>().loseGame();
            //maxHealth = 100f;
            //Destroy(GameObject.FindGameObjectWithTag("Player"));
            //Application.LoadLevel(0);
        }
    }
}
