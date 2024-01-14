using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    GameObject targetCharacter;

    [SerializeField]
    GameObject charac;

    [SerializeField]
    GameObject characRotate;

    [SerializeField]
    GameObject projectile;

    [SerializeField]
    float speed;

    GameObject c;

    private Vector3 direction;

    public static Vector3 left;

    private int EnemyHP;
    void Start()
    {
        StaticVariables.weapondamage = 2;
        EnemyHP = 5;
        targetCharacter = GameObject.FindWithTag("Character");
    }

    void FixedUpdate()
    {
        Vector3 pos = targetCharacter.transform.position;
        Move(pos);
        Rotate(pos);

        if (EnemyHP <= 0)
        {
            if (charac != null)
            {
                Destroy(charac, 0.1f);
                StaticVariables.Scores += 10;
                StaticVariables.coins += 1;
                charac = null; 
        }


       }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Character" || collision.gameObject.tag == "Weapons")
        {  
        EnemyHP -= StaticVariables.weapondamage;
        Debug.Log("EnemyHP: " + EnemyHP);
      
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot(){
        yield return new WaitForSeconds(3f);
        c = Instantiate(projectile, charac.transform.position + (transform.forward * 5f), characRotate.transform.rotation);
        c.GetComponent<Rigidbody2D>().velocity = transform.forward * 5;
        c.GetComponent<Rigidbody2D>().AddForce(transform.forward * 5, ForceMode2D.Impulse);
        Destroy(c, 2f);
        yield return null;
    }

    private void Move(Vector3 pos){
        Vector3 direction = pos - charac.transform.position;

        charac.transform.Translate(direction * Time.deltaTime * speed);
    }

    private void Rotate(Vector3 pos){
        Vector3 relativePos = pos - characRotate.transform.position;
        float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
        characRotate.transform.rotation = Quaternion.AngleAxis((angle-90), Vector3.forward);
    }
}
