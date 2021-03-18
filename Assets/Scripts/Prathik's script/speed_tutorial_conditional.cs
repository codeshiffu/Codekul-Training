using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed_tutorial_conditional : MonoBehaviour
{
    public int speed;
    public GameObject mycube, mysphere, mycapsule;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      if(speed == 0)
        {
            Debug.Log(mysphere.gameObject.name);
        }
      else if (speed > 0)
        {
            Debug.Log(mycapsule.gameObject.name);
        }
        else
        {
            Debug.Log(mycube.gameObject.name);
        }
    }
}
