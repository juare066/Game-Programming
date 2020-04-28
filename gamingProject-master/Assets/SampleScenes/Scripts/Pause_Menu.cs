using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    public void Update()
    {
        Debug.Log("Escape1");
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape2");
            if (GameIsPaused)
                {
                    Debug.Log("If");
                    Resume();    
                }
            else
                {
                    Debug.Log("else");
                    Pause();    
                }
        
        }
    }
    
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    public void BackToMenu()
    {
        Time.timeScale =1f;
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
            #if UNITY_EDITOR
    			UnityEditor.EditorApplication.isPlaying = false;
    		#else
    			Application.Quit();
    		#endif
            }
}