using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class SceneMaster : MonoBehaviour
{

    GameManager gameManager;
    GameObject[] collectablesToCatch;
    public List<GameObject> collectableList = new List<GameObject>();
    public float timer = 100;
    public int x = 0;
    public int y = 2;
    public int z = 5;
    public bool isPlaying = false;
    // Use this for initialization
    void Start()
    {
        collectablesToCatch = GameObject.FindGameObjectsWithTag("Pickups");
        for (int i = 0; i < collectablesToCatch.Length; i++)
        {
            collectableList.Add(collectablesToCatch[i]);
        }
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collectableList.Count == 0)
        {
            GameObject.FindGameObjectWithTag("Exit").GetComponent<Renderer>().material.color = Color.green;




        }

        if (isPlaying == true)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                Application.LoadLevel(0);
            }
        }
	
	}
}
