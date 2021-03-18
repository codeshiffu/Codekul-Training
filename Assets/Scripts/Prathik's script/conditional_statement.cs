using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditional_statement : MonoBehaviour
{
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        //Nested if
        if (speed > 10)
        {
            if (! (speed < 0))
            {
                Debug.Log("Excellent");
            }
            else
            {
                Debug.Log("Poor");
            }
        }
        else
        {
            Debug.Log("Please try again");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (! ((speed > 10) || (speed<25)))
        {
            Debug.Log("Success");
        }
        else
        {
            Debug.Log("please give value greater than 10 and less than 25");
        }
    }
}
