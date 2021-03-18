using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_plane_color : MonoBehaviour
{
    public Material[] materials_group;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, materials_group.Length);
        gameObject.GetComponent<Renderer>().material = materials_group[index];
        InvokeRepeating("change_my_color", 1, 2);
    }

    void change_my_color()
    {
        index = Random.Range(0, materials_group.Length);
        gameObject.GetComponent<Renderer>().material = materials_group[index];
    }
}
