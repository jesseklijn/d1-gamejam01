using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour
{
    int buttonWidth = 100;
    int buttonHeight = 30;
    bool isSelectorOpen = false;
    string[] allLevels;
    Sceneselector selector;
    // Use this for initialization
    void Start()
    {
        selector = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Sceneselector>();
        allLevels = selector.scenes;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect((Screen.width / 2) - (buttonWidth / 2), ((Screen.height / 2) - (buttonHeight / 2)), buttonWidth, buttonHeight), "Play"))
        {
        }
        if (GUI.Button(new Rect((Screen.width / 2) - (buttonWidth / 2), ((Screen.height / 2 + (buttonHeight * 1)) - (buttonHeight / 2)), buttonWidth, buttonHeight), "Level Selector"))
        {
            if (isSelectorOpen == true) { isSelectorOpen = false; }
            else { isSelectorOpen = true; }
        }
        if (GUI.Button(new Rect((Screen.width / 2) - (buttonWidth / 2), ((Screen.height / 2 + (buttonHeight * 2)) - (buttonHeight / 2)), buttonWidth, buttonHeight), "Settings"))
        {
        }
        if (GUI.Button(new Rect((Screen.width / 2) - (buttonWidth / 2), ((Screen.height / 2 + (buttonHeight * 3)) - (buttonHeight / 2)), buttonWidth, buttonHeight), "Quit"))
        {
        }
        if (isSelectorOpen == true)
        {
           
            GUI.Box(new Rect(((Screen.width / 2) - (buttonWidth / 2)) + buttonWidth, ((Screen.height / 2 + (buttonHeight * 1)) - (buttonHeight / 2)), buttonWidth*3, buttonHeight*3), "All Scenes");
            for (int i = 0; i < allLevels.Length; i++)
            {
                if (GUI.Button(new Rect((Screen.width / 2) - (buttonWidth / 2) + buttonWidth, ((Screen.height / 2 + (buttonHeight * i)) - (buttonHeight / 2)), buttonWidth, buttonHeight), allLevels[i])) { AutoFade.LoadLevel(i, 0.5F, 0.5F, Color.black); }
            }
        }
    }
}
