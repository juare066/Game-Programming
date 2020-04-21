using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarScript : MonoBehaviour
{
    public Image HealthBar;
    public Slider slider;

   
    public static float health;

    // Start is called before the first frame update
 
    public void setMaxHealth(int health)
    {
        slider.maxValue= health;
        slider.value = health;
    }

   public void setHealth(int health)
   {
        slider.value = health;
   }
    void Update()
    {
        //HealthBar.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            Debug.Log("Called loseGame");
            //FindObjectOfType<GameManager>().loseGame();
            //Destroy(GameObject.FindGameObjectWithTag("Player"));
            //Application.LoadLevel(0);
        }
    }
}
