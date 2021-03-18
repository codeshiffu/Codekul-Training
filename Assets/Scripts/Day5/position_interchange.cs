using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position_interchange : MonoBehaviour
{
    Vector3 cube1_position,cube2_position,cube3_position;
    public GameObject cube_object1,cube_object2,cube_object3;
    Transform cube1_transform,cube2_transform,cube3_transform;
    
    // Start is called before the first frame update
    void Start()
    {
        //Cube1
        cube1_transform = cube_object1.GetComponent<Transform>(); //Getting and storing Transform component of Cube1
        cube1_position = cube1_transform.position; // Getting and Storing Position property of cube1
        Debug.Log("Initial position of cube1"+cube1_position);

        //Cube2
        cube2_transform = cube_object2.GetComponent<Transform>();
        cube2_position = cube2_transform.position;
        Debug.Log("Initial position of cube2" + cube2_position);

        //Cube3
        cube3_transform = cube_object3.GetComponent<Transform>();
        cube3_position = cube3_transform.position;
        Debug.Log("Initial position of cube3" + cube3_position);


        change_cube_position(cube1_position,cube2_position);

    }

    void change_cube_position(Vector3 cube1_position, Vector3 cube2_position)
    {
        cube1_position.x = cube2_position.x;
        cube1_position.y = cube2_position.y;
        cube1_position.z = cube2_position.z;

        Debug.Log("Position after change"+cube1_position);

        cube_object1.transform.Translate(new Vector3(cube1_position.x,cube1_position.y,cube1_position.z));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
