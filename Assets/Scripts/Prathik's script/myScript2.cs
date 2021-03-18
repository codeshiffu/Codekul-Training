using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript2 : MonoBehaviour
{
    public GameObject cube_object;
    // Start is called before the first frame update
    void Start()
    {
        cube_object.gameObject.GetComponent<Rigidbody>().mass = 500;
        cube_object.gameObject.GetComponent<Rigidbody>().useGravity = false;

        Debug.Log(cube_object.gameObject.GetComponent<Transform>().position);
    }

    // Update is called once per frame
    void Update()
    {
        cube_object.gameObject.GetComponent<Transform>().position = new Vector3(10, 40, 23);
    }
}
