using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    GameObject target;

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

    int EnemyHP;
    void Start()
    {
        EnemyHP = 5;
    }

    void FixedUpdate()
    {
        Vector3 pos = target.transform.position;
        Move(pos);
        Rotate(pos);

        if(EnemyHP == 0){
            Destroy(charac, 0.1f);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        EnemyHP -= 1;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot(){
        yield return new WaitForSeconds(2.2f);
        c = Instantiate(projectile, charac.transform.position + (transform.forward * 1f), characRotate.transform.rotation);
        c.GetComponent<Rigidbody2D>().velocity = transform.up * 5;
        Destroy(c, 2f);
        yield return new WaitForSeconds(3f);
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
