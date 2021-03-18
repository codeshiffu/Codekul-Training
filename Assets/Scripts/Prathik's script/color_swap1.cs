using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_swap1 : MonoBehaviour
{
     Material cube_color;
    // Start is called before the first frame update
    void Start()
    {
        cube_color = gameObject.GetComponent<Renderer>().material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Renderer>().material = collision.gameObject.GetComponent<Renderer>().material;
        collision.gameObject.GetComponent<Renderer>().material = cube_color;

    }
}
