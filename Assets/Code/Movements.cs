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

    void Start()
    {
        movingSpeed = 3.0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, 1) * movingSpeed * Time.deltaTime);
            c.GetComponent<Rigidbody2D>().velocity = transform.up * 0.5f;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0, -1) * movingSpeed * Time.deltaTime);
            c.GetComponent<Rigidbody2D>().velocity = -transform.up * 0.5f;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -1 * rotateSpeed);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 0.5f;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 1 * rotateSpeed);
            c.GetComponent<Rigidbody2D>().velocity = -transform.right * 0.5f;
        }
    }
}
