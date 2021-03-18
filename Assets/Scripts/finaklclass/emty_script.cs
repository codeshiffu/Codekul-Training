using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emty_script : MonoBehaviour
{
    public GameObject _mycube, _mysphere;
    // Start is called before the first frame update
    void Start()
    {
        
        _mycube.gameObject.GetComponent<cube_code>().myMethod1();
        Debug.Log(_mycube.GetComponent<cube_code>()._cube);


        _mysphere.gameObject.GetComponent<sphere_code>().myMethod2();
        Debug.Log(_mysphere.GetComponent<sphere_code>()._sphere);



    }

    // Update is called once per frame
    void Update()
    {
        if (_mycube.GetComponent<cube_code>()._cube)
        {
            _mycube.gameObject.GetComponent<cube_code>().enabled = false;
        }
        else
        {
            _mycube.gameObject.GetComponent<cube_code>().enabled = true;
        }
    }
}
