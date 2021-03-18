using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolt_demo1_player_movement : MonoBehaviour
{
    float movehorizontal, movevertical;
    public float speed;
    Rigidbody movement;
    // Start is called before the first frame update
    void Start()
    {
       
        movement = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movehorizontal = Input.GetAxis("Horizontal");
        movevertical = Input.GetAxis("Vertical");
        movement.AddForce(movehorizontal*speed, 0, movevertical*speed);
    }
}
