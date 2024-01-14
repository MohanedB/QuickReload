using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsDestroy : MonoBehaviour
{
    [SerializeField]
    GameObject weapon;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(weapon);


        }
    }
}