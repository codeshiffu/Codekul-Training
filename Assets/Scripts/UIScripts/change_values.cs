using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_values : MonoBehaviour
{
    public int myValue;
    // Start is called before the first frame update
    void Start()
    {
        myValue = 0;
    }

    public void increment_value()
    {
        ++myValue;
        Debug.Log(myValue);
    }

   public void decrement_value()
    {
        if (myValue > 0) {
            --myValue;
            Debug.Log(myValue);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
