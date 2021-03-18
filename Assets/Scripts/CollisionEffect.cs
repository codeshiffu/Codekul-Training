using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEffect : MonoBehaviour
{
    public GameObject myEffects;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Sphere")
        {
            Instantiate(myEffects, transform.position,Quaternion.identity);
            myEffects.GetComponent<ParticleSystem>().Play();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
