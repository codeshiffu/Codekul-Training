using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_position : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(new Vector3(10, 2, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
