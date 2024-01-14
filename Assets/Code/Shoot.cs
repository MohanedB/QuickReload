using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    GameObject character, projectile;

    GameObject c;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))


        {
            c = Instantiate(projectile, character.transform.position + (transform.up * 1.5f), character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.up * 5;
            Destroy(c, 1f);
        }
        
    }

   

    }


