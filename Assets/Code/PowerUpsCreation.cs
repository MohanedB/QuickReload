using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsCreation : MonoBehaviour
{
    [SerializeField]
    GameObject c;
    private Camera _mainCam;
    private int offset = 100;
    private float _screenWidth;
    private float _screenHeight;

    void Start()
    {
        _mainCam = Camera.main;

        _screenWidth = _mainCam.orthographicSize * _mainCam.aspect;
        _screenHeight = _mainCam.orthographicSize;

        InvokeRepeating("SpawnPowerup", 0, 10);
        Debug.Log("A power up has been spawned");
    }

    private Vector3 GetRandomSpawnerPosition()
    {

        float randomX = Random.Range(0f, 1f);


        float fixedY = 0.9f;


        Vector3 newPos = _mainCam.ViewportToWorldPoint(new Vector3(randomX, fixedY, 0f));
        newPos.z = 0;
        return newPos;
    }

    private void SpawnPowerup()
    {
        transform.position = GetRandomSpawnerPosition();
        c.GetComponent<Rigidbody2D>().velocity = transform.up * -1;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Destroy")
        {
            Destroy(c);
            Debug.Log("It has been destroyed");
        }
    }


}