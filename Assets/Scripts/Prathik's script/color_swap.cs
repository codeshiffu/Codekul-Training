using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_swap : MonoBehaviour
{

    public GameObject cube, sphere;
    Material cube_color, sphere_color, dummy_variable;
    // Start is called before the first frame update
    void Start()
    {
        cube_color = cube.gameObject.GetComponent<Renderer>().material;  //a=5
        sphere_color = sphere.gameObject.GetComponent<Renderer>().material; //b=10
    }

    private void OnCollisionEnter(Collision collision)
    {
        dummy_variable = cube_color;  //c=a
        cube_color = sphere_color;  //a=b
        sphere_color = dummy_variable;   //b=c
    }
}
