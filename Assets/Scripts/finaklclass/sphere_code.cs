using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_code : MonoBehaviour
{
    public bool _sphere;
    // Start is called before the first frame update
    void Start()
    {
        _sphere = true;
    }

   //Userdefined Method
   public void myMethod2()
    {
        Debug.Log("Message from sphere");   
    }
}
