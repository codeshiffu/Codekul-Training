using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_position : MonoBehaviour
{
    
    Rigidbody myRigidBody;
    Vector3 myposition,myscale;
    Quaternion myrotation;
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>(); // Getting RigidBody Component and storing it to the same type of variable
        myTransform = GetComponent<Transform>(); //Getting Transform Component and storing it to the same type of variable
        myposition = myTransform.position; //Getting the Position Vectors from the Transform Component and storing it in Vector3 variable
        myrotation = myTransform.rotation;//Getting the Rotation Vectors from the Transform Component and storing it in Vector3 variable
        myscale = myTransform.localScale;


        Debug.Log("Position"+myposition);
        Debug.Log("Rotation"+myrotation);
        Debug.Log("Scale"+myscale);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
