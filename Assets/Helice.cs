using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helice : MonoBehaviour
{
    private Rigidbody myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            //transform.Rotate(new Vector3(Input.GetAxis("Jump"), 0f, 0f) * Time.deltaTime);
            //Lui fonctionne, mais c'est pas comme ça qu'il est écrit de le faire
            transform.Rotate(new Vector3(100f, 0f, 0f) * Time.deltaTime);
            //myRigidBody.rot
        }
    }
}
