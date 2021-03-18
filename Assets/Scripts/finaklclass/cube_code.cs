using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_code : MonoBehaviour
{
    public bool _cube;
    // Start is called before the first frame update
    void Start()
    {
        _cube = false;
    }

    //Userdefined Method
   public  void myMethod1()
    {
        Debug.Log("Message from Cube");
    }
}
