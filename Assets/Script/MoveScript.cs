using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public int speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.RotateAround(transform.position,-transform.right, speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.RotateAround(transform.position, transform.right , speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.position, -Vector3.up, speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(transform.position, Vector3.up , speed);
        }

    }
}
