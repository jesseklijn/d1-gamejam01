using UnityEngine;
using System.Collections;

public class CollisionSensors : MonoBehaviour
{

    public SceneMaster sceneMaster;
    public GameObject player;
    PlayerMovement playerMovement;
    public enum Sensors
    {
        None,
        Front,
        Back,
        Left,
        Right
    };
    public Sensors sensor;
    void OnEnable()
    {
        sceneMaster = GameObject.FindGameObjectWithTag("SceneMaster").GetComponent<SceneMaster>();
        playerMovement = player.GetComponent<PlayerMovement>();

    }
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collision is geraakt: " + sensor.ToString());

        if (collider.gameObject.tag == "Collider" || collider.gameObject.tag == "Exit" && sceneMaster.collectableList.Count != 0 || collider.gameObject.tag == "Door")
        {
            if (sensor == Sensors.Front) { playerMovement.front = true; }
            if (sensor == Sensors.Left) { playerMovement.left = true; }
            if (sensor == Sensors.Right) { playerMovement.right = true; }
            if (sensor == Sensors.Back) { playerMovement.back = true; }
        }
        if (collider.gameObject.tag == "Door")
        {
            collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        

    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("Collision is weg: " + sensor.ToString());
        if (collider.gameObject.tag == "Door")
        {
            collider.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (sensor == Sensors.Front) { playerMovement.front = false; }
        if (sensor == Sensors.Left) { playerMovement.left = false; }
        if (sensor == Sensors.Right) { playerMovement.right = false; }
        if (sensor == Sensors.Back) { playerMovement.back = false; }

    }

}
