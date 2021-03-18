using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision_detect_script : MonoBehaviour
{
    public int count = 0,hit_count=3;
    public Text count_text,game_over_text;
    string capsule_color;
    
    private void Start()
    {
        capsule_color = "FF0000";
        count_text.text = " ";
        game_over_text.text = " ";

    }
    private void OnCollisionEnter(Collision collision)
    {

       
        if (collision.gameObject.tag == "coinss") {
            if(ColorUtility.ToHtmlStringRGB(collision.gameObject.GetComponent<Renderer>().material.color).ToString() == capsule_color ){
                ++count;
                Destroy(collision.gameObject);
            }
            
        }
        else
        {
            --hit_count;
            Debug.Log(hit_count);

        }
        
        
    }
    private void Update()
    {
        count_text.text = "Coins" + count;
        if (hit_count < 0)
        {
            game_over_text.text = "Game Over";

        }
    }
}
