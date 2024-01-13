using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Movements : MonoBehaviour
{
   
    [SerializeField]
    private float rotateSpeed = 0.2f;
    [SerializeField]
    private float movingSpeed;
    [SerializeField]
    GameObject c;




    // Start is called before the first frame update
    void Start()
    {
        movingSpeed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
            transform.Translate(new Vector2(0, 1) * movingSpeed * Time.deltaTime);
            //transform.position += transform.up * (1 * movingSpeed * Time.deltaTime);
            c.GetComponent<Rigidbody2D>().velocity = transform.up * 1;




        }
        else if(Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            transform.Translate(new Vector2(0, -1) * movingSpeed * Time.deltaTime);
            //transform.position += transform.up * (-1 * movingSpeed * Time.deltaTime);
            c.GetComponent<Rigidbody2D>().velocity = -transform.up * 1;


        }
        else if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            //transform.Translate(new Vector2(1, 0) * movingSpeed * Time.deltaTime);
                transform.Rotate(0, 0, -1 * rotateSpeed);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 1;


        }
        else if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            //transform.Translate(new Vector2(-1, 0) * movingSpeed * Time.deltaTime);
            transform.Rotate(0, 0, 1 * rotateSpeed);
            c.GetComponent<Rigidbody2D>().velocity = -transform.right * 1;





        }

    }
}
