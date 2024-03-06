using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public int chance=6;
    public int rand;

    [SerializeField]
    GameObject c;
 

    void Start()
    {
        rand = Random.Range(1, chance);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Character" && rand>=3)
        {
            StaticVariables.weapondamage = 1;
            Debug.Log("Damage: " + StaticVariables.weapondamage);

            Destroy(c);
        }
        else if(collision.gameObject.tag == "Character" && rand <= 3)
        {
            StaticVariables.weapondamage = 3;
            Debug.Log("Damage: "+StaticVariables.weapondamage);
            Destroy(c);

        }
    }


}