using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void NewGameBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Level1()
    {
        SceneManager.LoadScene(2); //Level1
	}
    public void Level2()
    {
        SceneManager.LoadScene(3); //Level2
	}
    public void Level3()
    {
        SceneManager.LoadScene(4); //Level3
	}
    public void backButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void ExitGameBtn()
    {
        Application.Quit();
    }
}
