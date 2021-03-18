using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class myDemoScript1 : MonoBehaviour
{
    //GameDesign,GameDevelopment,GameProgramming
    public GameObject myemptygameobject, myemptygameobject1,myemptygameobject2;
   
    
    // Start is called before the first frame update
    void Start()
    {
        myemptygameobject1.gameObject.name = myemptygameobject.gameObject.name; //GameDesign
        myemptygameobject2.gameObject.name = myemptygameobject1.gameObject.name; //GameDesign
        myemptygameobject.gameObject.name = myemptygameobject2.gameObject.name; //GameDesign

        Debug.Log(myemptygameobject.gameObject.name); //
        Debug.Log(myemptygameobject1.gameObject.name); //
        Debug.Log(myemptygameobject1.gameObject.name); //
       
    }

    
}
