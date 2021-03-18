using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript1 : MonoBehaviour
{
   public int speed;//Declaration
    public GameObject myobject;

    // Start is called before the first frame update
    void Start()
    {
       myobject.gameObject.name = "renamed Cube Object";
       Debug.Log(myobject.gameObject.name);
       Debug.Log("Hi");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello");
        Debug.Log(speed);
    }
}
