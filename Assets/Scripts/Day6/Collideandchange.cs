using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collideandchange : MonoBehaviour
{
    public GameObject myobject;
    public GameObject[] objects;
    Color[] objectColors;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objectColors[i] = objects[i].GetComponent<Renderer>().material.color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        myobject.GetComponent<Renderer>().material.color = collision.gameObject.GetComponent<Renderer>().material.color;
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].GetComponent<Renderer>().material.color = objectColors[i];
        }
    }

}
