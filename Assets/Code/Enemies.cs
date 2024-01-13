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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StaticVariables.Scores += 10;

        Destroy(c);

        System.Console.WriteLine(StaticVariables.Scores);


    }
}
