using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy") { 
        StaticVariables.damage = 50f;
        StaticVariables.hit = true;
        }else if(collision.gameObject.tag == "Asteroid") { 
        StaticVariables.damage = 25f;
        StaticVariables.hit = true;
        }
    }
}
