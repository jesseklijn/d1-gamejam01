using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {
    public SceneMaster sceneMaster;

    int boxWidth = 200;
    int boxHeight = 100;
    void OnGUI()
    {
        GUI.Box(new Rect(0,0,boxWidth,boxHeight), "Game info");
        GUI.Label(new Rect(5, 20, 200, 40), "Time left: " + Mathf.Round(sceneMaster.timer));
        GUI.Label(new Rect(5, 40, 200, 40), "Collectables left: " + Mathf.Round(sceneMaster.collectableList.Count));

    }
}
