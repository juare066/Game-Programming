using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthBar: MonoBehaviour
{
    
    public int maxHealth = 5;
    public int health;

    public Slider slider;

    // Start is called before the first frame update
    public void setMaxHealth()
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void setHealth(int health)
    {
       slider.value = health;
            //FindObjectOfType<GameManager>().loseGame();  
    }
}
