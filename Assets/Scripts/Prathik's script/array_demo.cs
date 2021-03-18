using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array_demo : MonoBehaviour
{
    public int[] values;
    
    // Start is called before the first frame update
    void Start()
    {
       



        for(int i = 0; i < 10; i++)
        {
            Debug.Log(values[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
