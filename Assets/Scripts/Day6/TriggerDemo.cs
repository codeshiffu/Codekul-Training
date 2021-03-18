using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exit");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Triggering");
    }
}
