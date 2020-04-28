using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(1);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -=damage;
        if(currentHealth<=0)
        {
            FindObjectOfType<GameManager>().loseGame();
        }
        healthbar.SetHealth(currentHealth);
    }
    public void GainHealth(int health)
    {
        if(currentHealth!=maxHealth)
        {
             currentHealth+=health;
        }
    }
}
