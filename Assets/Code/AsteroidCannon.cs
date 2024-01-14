using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AsteroidCannon : MonoBehaviour
{
    [SerializeField]
    GameObject projectile;

    Vector2 asteroidDirection;

    GameObject c;    

    int chance = 15;
    void Start()
    {
        InvokeRepeating("ShootChance", 0, 5);
        InvokeRepeating("ChanceIncrease", 0, 10);
    }

    private void ShootChance(){
        int rand = Random.Range(1, chance);
        if(rand == 1){
        c = Instantiate(projectile, transform.position, Quaternion.identity);
        
        RandomCannonLocation randomiser = GetComponent<RandomCannonLocation>();
        Vector3 fireAt = randomiser.GetRandomFireAtPosition();
        asteroidDirection = (Vector2)fireAt;

        Vector2 playerPosition = this.transform.position;
        Vector2 enemyPosition = asteroidDirection;
        Vector2 fromEnemyToPlayer = enemyPosition - playerPosition;

        // Normalize it to length 1
        fromEnemyToPlayer.Normalize();
 
        // Set the speed to whatever you want:
        Vector2 velocity = fromEnemyToPlayer * 2;
 
        // Set the rigidbody velocity
        c.GetComponent<Rigidbody2D>().velocity = velocity;
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

    private void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(this.transform.position, asteroidDirection);
    }
}
