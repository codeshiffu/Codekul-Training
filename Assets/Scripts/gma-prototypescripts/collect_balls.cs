using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collect_balls : MonoBehaviour
{
    public Text score_text;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        score_text.text = "0";
            }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(GetComponent<Renderer>().material.name);
        //Debug.Log(collision.gameObject.GetComponent<Renderer>().material.name);
        if(collision.gameObject.tag == "ball" && (GetComponent<Renderer>().material.name.ToString() == collision.gameObject.GetComponent<Renderer>().material.name.ToString()))
        {
            ++score;

            Destroy(collision.gameObject);
            Debug.Log(score);
            score_text.text = score.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
