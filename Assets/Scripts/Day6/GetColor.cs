using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColor : MonoBehaviour
{
    public GameObject[] mygameObject;
    Color cube_color;
    int j = 1;

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0;i<mygameObject.Length;i++)
        {
            mygameObject[i].GetComponent<Renderer>().material.color = mygameObject[j].GetComponent<Renderer>().material.color;
            if (j < 2) {
                j++;
            }
            else
            {
                j=0;
            }
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
