using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed_acceleration_task : MonoBehaviour
{
    public int acceleration, gear;
    // Start is called before the first frame update
    void Start()
    {
        acceleration = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        if(gear == 1)
        {
            if(acceleration>100 || acceleration <1)
            {
                acceleration = 1;
            }
            if(acceleration>0 && acceleration < 100)
            {
                acceleration++;
            }
        }
        if(gear == 2)
        {
            if(acceleration<=100 || acceleration>200)
            {
                acceleration = 101;
            }
            if(acceleration>100 && acceleration < 200)
            {
                acceleration++;
            }
        }
        if(gear == 3)
        {
            if(acceleration<=1 || acceleration <= 200)
            {
                acceleration = 201;
            }
            if(acceleration>200 && acceleration < 300)
            {
                acceleration++;
            }
        }
    }
}
