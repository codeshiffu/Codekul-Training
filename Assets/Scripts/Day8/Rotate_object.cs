using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_object : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0.2f , 0.2f, 0.2f) * speed);
    }
}
