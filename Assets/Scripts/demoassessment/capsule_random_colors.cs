using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule_random_colors : MonoBehaviour
{
    public Material[] capsule_materials;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, capsule_materials.Length);
        gameObject.GetComponent<Renderer>().material = capsule_materials[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
