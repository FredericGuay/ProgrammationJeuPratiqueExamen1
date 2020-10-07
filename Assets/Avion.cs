using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour
{
    private Rigidbody myRigidBody;
    public int movementSpeed = 100;
    [SerializeField] ParticleSystem Fumee = null;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") != 0)
        {

            //myRigidBody.MovePosition(new Vector3(inputHorizontal, 0f, inputVertical) * Time.deltaTime);
            myRigidBody.AddForce(new Vector3(Input.GetAxis("Jump") * 500, 0f, 0f) * Time.deltaTime);
            //myRigidBody.AddRelativeForce(new Vector3(1, 0, 0) * Time.deltaTime);
            //transform.Rotate(new Vector3(inputHorizontal, 0f, inputVertical) * Time.deltaTime);

            //Vector3 movement = new Vector3(inputHorizontal, 0, 0) * Time.deltaTime * movementSpeed;
            //myRigidBody.MovePosition(myRigidBody.position + movement);

            //Fumee.Play();
            Fumee.Emit(1);
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            float inputHorizontal = Input.GetAxis("Horizontal");
            myRigidBody.AddTorque(new Vector3((float)(-inputHorizontal * 0.1), 0f, 0f));
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            float inputVertical = Input.GetAxis("Vertical");
            myRigidBody.AddTorque(new Vector3(0f, 0f, (float)(inputVertical * 0.1)));
        }
    }
}
