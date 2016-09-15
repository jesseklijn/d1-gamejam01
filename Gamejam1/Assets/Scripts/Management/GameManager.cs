using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    //Play Scene data


    public int playerLives = 5;

    public static GameManager gamestats;

    //Level selector


    // Use this for initialization
    void Awake()
    {
        if (gamestats == null)
        {

            DontDestroyOnLoad(gameObject);
            gamestats = this;
        }
        else if (gamestats != this)
        {
            Destroy(gameObject);
        }

    }
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	}

}
