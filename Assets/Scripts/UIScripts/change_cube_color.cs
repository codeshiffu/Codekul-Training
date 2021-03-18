using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_cube_color : MonoBehaviour
{
    public Material button1, button2, button3;
    public GameObject myCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void apply_button1_color()
    {
        myCube.gameObject.GetComponent<Renderer>().material = button1;
    }

    public void apply_button2_color()
    {
        myCube.gameObject.GetComponent<Renderer>().material = button2;
    }

    public void apply_button3_color()
    {
        myCube.gameObject.GetComponent<Renderer>().material = button3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
