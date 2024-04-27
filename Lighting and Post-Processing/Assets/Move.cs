using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 0.01f;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 0.01f;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * 0.01f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * 0.01f;
        }
    }
}
