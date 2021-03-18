using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_tutorial : MonoBehaviour
{
    public GameObject object1, object2, object3;
    Color mycolor;
    // Start is called before the first frame update
    void Start()
    {
        

        //This will return the material name applied over the object
      Debug.Log(  object1.gameObject.GetComponent<Renderer>().material);
      Debug.Log(object2.gameObject.GetComponent<Renderer>().material);
      Debug.Log(object3.gameObject.GetComponent<Renderer>().material);


        //This will return the color values of the material applied over objet.
        Debug.Log(object1.gameObject.GetComponent<Renderer>().material.color);
        Debug.Log(object2.gameObject.GetComponent<Renderer>().material.color);
        Debug.Log(object3.gameObject.GetComponent<Renderer>().material.color);

        //The ColorUtility.ToHtmlStringRGBA() converts color value into Hexadecimal format
        Debug.Log(ColorUtility.ToHtmlStringRGBA(object1.gameObject.GetComponent<Renderer>().material.color));
        Debug.Log(ColorUtility.ToHtmlStringRGBA(object2.gameObject.GetComponent<Renderer>().material.color));
        Debug.Log(ColorUtility.ToHtmlStringRGBA(object3.gameObject.GetComponent<Renderer>().material.color));


       if((object1.gameObject.GetComponent<Renderer>().material) == (object2.gameObject.GetComponent<Renderer>().material))
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
