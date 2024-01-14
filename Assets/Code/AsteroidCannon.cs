using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCannon : MonoBehaviour
{
    [SerializeField]
    GameObject projectile;

    GameObject c;    

    int chance = 6;
    void Start()
    {
        InvokeRepeating("ShootChance", 0, 3);
        InvokeRepeating("ChanceIncrease", 0, 15);
    }

    private void ShootChance(){
        int rand = Random.Range(1, chance);
        if(rand > 0){
        c = Instantiate(projectile, transform.position, transform.rotation);
        c.GetComponent<Rigidbody2D>().AddForce(transform.right * 5, ForceMode2D.Impulse);
        c.GetComponent<Rigidbody2D>().velocity = transform.right * 3;
        Destroy(c, 40f);
        }
    }

    private void ChanceIncrease(){
        if(chance > 3){
        chance -= 1;
        }else{
            chance = 3;
        }
    }
}
