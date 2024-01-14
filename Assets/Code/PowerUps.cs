using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField]
    GameObject c;

    public int chance=6;
    public int rand;
 

    void Start()
    {
        rand = Random.Range(1, chance);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Character" && rand>=3)
        {
            StaticVariables.weapondamage = 1;
            Debug.Log("Damafe: " + StaticVariables.weapondamage);

            Destroy(c);
        }
        else
        {
            StaticVariables.weapondamage = 3;
            Debug.Log("Damafe: "+StaticVariables.weapondamage);
            Destroy(c);

        }
    }


}