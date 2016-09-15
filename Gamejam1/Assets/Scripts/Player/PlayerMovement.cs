using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerMovement : MonoBehaviour
{

    public bool front = false, back = false, right = false, left = false;
    public bool isMoving = false;
    SceneMaster sceneMaster;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isMoving = true;
            if (left == false)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            }
        }
        else
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            isMoving = true;
            if (right == false)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            }
        }
        else
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            isMoving = true;
            if (front == false)
            {
                gameObject.transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            }
        }
        else
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            isMoving = true;
            if (back == false)
            {
                gameObject.transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
            }

        }
        isMoving = false;

    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Key")
        {
            Destroy(collider.gameObject.GetComponent<LocknKey>().door);
            Destroy(collider.gameObject.GetComponent<LocknKey>().roof);

            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == "Pickups")
        {

            sceneMaster = GameObject.FindGameObjectWithTag("SceneMaster").GetComponent<SceneMaster>();
            foreach (GameObject collectable in sceneMaster.collectableList)
            {
                if (collider.gameObject == collectable)
                {
                    Destroy(collider.gameObject);
                    Debug.Log("Pickup is gepakt! ");

                }



            }
            sceneMaster.collectableList.Remove(collider.gameObject);

        }
        if (collider.gameObject.tag == "Exit")
        {
            Application.LoadLevel(0);
        }
    }
}
