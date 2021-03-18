using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_player : MonoBehaviour
{
    float moveHorizontal, moveVertical;
    public int speed;
    Rigidbody myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        myrigidbody.AddForce(moveHorizontal * speed, 0, moveVertical * speed);
    }
}
