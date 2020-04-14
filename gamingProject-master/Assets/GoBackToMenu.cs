using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackToMenu : MonoBehaviour
{
    public GUISkin myskin;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnGUI()
    {
        GUI.skin = myskin;
        if (GUI.Button(new Rect(20, 20, 200, 100), "Menu"))
        {
            Application.LoadLevel(0);
        }
    }
}
