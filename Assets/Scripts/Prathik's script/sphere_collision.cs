using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_collision : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
        Destroy(gameObject);
    }
}
