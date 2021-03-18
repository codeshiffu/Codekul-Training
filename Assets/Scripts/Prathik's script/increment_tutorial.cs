using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increment_tutorial : MonoBehaviour
{
    public int x, y, z;
    public GameObject object1, object2, object3;
    // Start is called before the first frame update
    void Start()
    {
        x++;//Increment value by 1 (x = x+1 -> x = 0+1 -> x = 1)
        x++;
       
        y++;
        y++;
       
        z++;
        z++;
       
        if(x == z)
        {
            object1.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        if(y == z)
        {
            object2.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        if(x == y)
        {
            object3.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
