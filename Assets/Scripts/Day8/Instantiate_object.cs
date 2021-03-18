using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_object : MonoBehaviour
{
    public GameObject mygameobject;
    float x, y, z;
    private void Start()
    {
        Destroy(gameObject);
        InvokeRepeating("my_spawn", 10, 2);
    }

    void my_spawn()
    {
        x = Random.Range(-10, 10);
        y = Random.Range(0, 10);
        z = Random.Range(-10, 10);
        Instantiate(mygameobject, new Vector3(x, y, z), Quaternion.identity);
    }


}
