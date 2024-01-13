using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject c;

    

    
    void Start()
    {
        StaticVariables.hit = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Collision Detected: {collision.gameObject.name}");
        StaticVariables.Scores += 10;

        StaticVariables.damage = 10f;

        //StaticVariables.hit = true;
        StaticVariables.hit = true;
        Destroy(c);




        System.Console.WriteLine(StaticVariables.Scores);


    }
}
