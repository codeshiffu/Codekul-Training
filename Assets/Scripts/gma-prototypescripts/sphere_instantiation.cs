using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_instantiation : MonoBehaviour
{
    public GameObject[] spheres;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("instantiate_prefabs", 2, 3);
    }

    void instantiate_prefabs()
    {
        int random_value = 0;
        random_value = Random.Range(0, spheres.Length);
        Instantiate(spheres[random_value], spheres[random_value].transform.position, Quaternion.identity);
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
