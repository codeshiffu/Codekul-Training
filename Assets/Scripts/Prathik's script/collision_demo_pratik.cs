using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_demo_pratik : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Renderer>().material = collision.gameObject.GetComponent<Renderer>().material;
        Destroy(collision.gameObject);
    }

}
