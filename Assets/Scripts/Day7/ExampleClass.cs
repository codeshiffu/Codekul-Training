using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    float moveHorizontal, moveVertical;
    public float speed;
    Vector3 movement;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

          movement = new Vector3(moveHorizontal,0.0f, moveVertical);
       

       rigidbody.AddForce(movement * speed );
    }
}
