using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionswap : MonoBehaviour
{
    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 4; i++)
        {
            Debug.Log(objects[i].gameObject.transform.position);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
