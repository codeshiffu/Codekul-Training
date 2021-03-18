using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array_color_objects : MonoBehaviour
{
    public Material[] colors;
    public GameObject[] objects;
    int j;

    // Start is called before the first frame update
    void Start()
    {
        j = 4;
        for(int i = 0; i < 5; i++)
        {
            objects[i].gameObject.GetComponent<Renderer>().material = colors[j];
            if (j > 0) 
            {
                j--; 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
