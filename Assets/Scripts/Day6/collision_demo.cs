using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision occured");
      //  Debug.Log("Parent Object Name:" + gameObject.name);
        //Debug.Log("Name of the object causes collision:" + collision.gameObject.name);
    }

   

    /* private void OnCollisionExit(Collision collision)
     {
         Debug.Log("Collision Exit");
     }

     private void OnCollisionStay(Collision collision)
     {
         Debug.Log("Still Colliding");
     }*/
}
