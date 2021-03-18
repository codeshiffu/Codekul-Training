using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_color_change : MonoBehaviour
{
    public GameObject player;
    public Material[] box_materials;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("change_box_colors", 2, 3); 
    }
    
    void change_box_colors()
    {
        int random_value = 0;
        random_value = Random.Range(0, box_materials.Length);
        player.gameObject.GetComponent<Renderer>().material = box_materials[random_value];
         
    }
}
