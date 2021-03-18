using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looping : MonoBehaviour
{
    public int input_value1;
    float mymass;
    public GameObject myobject;
    private Rigidbody myRigidBody;
   
    // Start is called before the first frame update
    void Start()
    {
        input_value1++;
        myRigidBody = myobject.GetComponent<Rigidbody>();
        mymass = myRigidBody.mass;
        mymass++;
    }

    // Update is called once per frame
    void Update()
    {
        if(input_value1>mymass && mymass > input_value1)
        {
            myRigidBody.useGravity = true;
        }
        else
        {
            myRigidBody.useGravity = false;
        }
    }
}
