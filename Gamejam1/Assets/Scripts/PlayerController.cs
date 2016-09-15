using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called on a fixed time
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.position += new Vector3(0, 0, 1) * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.position -= new Vector3(0, 0, 1) * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.position -= new Vector3(1, 0, 0) * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.position += new Vector3(1, 0, 0) * speed;
        }
    }
}


