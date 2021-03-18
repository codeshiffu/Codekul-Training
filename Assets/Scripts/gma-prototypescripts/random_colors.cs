using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_colors : MonoBehaviour
{
    public Material[] my_mat;
    public GameObject mycube;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("change_color", 2, 3);
    }

    void change_color()
    {
        int random_value=0;
        random_value = Random.Range(0, my_mat.Length);
        mycube.gameObject.GetComponent<Renderer>().material = my_mat[random_value];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
