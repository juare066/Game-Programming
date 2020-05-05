using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
	public int buttonWidth;
	public int buttonHeight;
	private int origin_x;
	private int origin_y;
	public GUISkin mySkin;
    // Start is called before the first frame update
    void Start()
    {
        buttonWidth = 200;
        buttonHeight = 50;
        origin_x = Screen.width/2 - buttonWidth/2;
        origin_y = Screen.height/3 - buttonHeight*2;
    }

    void OnGUI() {
    	GUI.skin = mySkin;
    	if(GUI.Button(new Rect(origin_x,origin_y,buttonWidth,buttonHeight), "Go Back")) {
    		Application.LoadLevel(0);
    	}
    	if(GUI.Button(new Rect(origin_x,origin_y+buttonHeight+15,buttonWidth,buttonHeight), "Level 1")) {
    		Application.LoadLevel(2);
    	}
    	if(GUI.Button(new Rect(origin_x,origin_y+buttonHeight*2+30,buttonWidth,buttonHeight), "Level 2")) {
    		Application.LoadLevel(3);
    	}
		if(GUI.Button(new Rect(origin_x,origin_y+buttonHeight*3+45,buttonWidth,buttonHeight), "Level 3")) {
    		Application.LoadLevel(4);
    	}
        if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight * 4 + 60, buttonWidth, buttonHeight), "Level 4"))
        {
            Application.LoadLevel(5);
        }
        if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight * 5 + 75, buttonWidth, buttonHeight), "Level 5"))
        {
            Application.LoadLevel(6);
        }
        if (GUI.Button(new Rect(origin_x,origin_y+buttonHeight*6+90,buttonWidth,buttonHeight), "Quit")) {
    		#if UNITY_EDITOR
    			UnityEditor.EditorApplication.isPlaying = false;
    		#else
    			Application.Quit();
    		#endif
    	}
    }
}
