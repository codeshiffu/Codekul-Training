using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task1 : MonoBehaviour
{
   
    public GameObject cube1, cube2;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        cube1.transform.Translate( new Vector3(0, 0, 0.05f)* speed);
        cube2.transform.Translate( new Vector3(0, 0,-0.05f) * speed);
    }
}
