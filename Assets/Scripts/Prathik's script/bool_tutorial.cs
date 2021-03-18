using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bool_tutorial : MonoBehaviour
{
    public bool dummy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dummy)
        {
            Debug.Log("Success");
        }
        else
        {
            Debug.Log("Failure");
        }
       
    }
}
