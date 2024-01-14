using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCannonLocation : MonoBehaviour
{
    private Camera _mainCam;
    private int interval = 3;
    private int offset = 25;
    private int _screenWidth;
    private int _screenHeight;

    private Vector3 spawnerPosition;
    private Vector3 fireAtPosition;
    
    private void Start()
    {
        // Cache main camera for performance
        _mainCam = Camera.main;
        
        // Get Screen width and height
        _screenWidth = Screen.currentResolution.width;
        _screenHeight = Screen.currentResolution.height;
        
        InvokeRepeating(nameof(RandomisePositions), 0f, interval);
    }
    
    private void RandomisePositions()
    {
        //fireAtPosition = GetRandomFireAtPosition();
        //float angle = Mathf.Atan2(fireAtPosition.y, fireAtPosition.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //spawnerPosition = GetRandomSpawnerPosition();
        transform.position = GetRandomSpawnerPosition();
    }
    
    public Vector3 GetRandomFireAtPosition()
    {
        int randomWidth = Random.Range(0, _screenWidth + 1);
        int randomHeight = Random.Range(0, _screenHeight + 1);
        Vector3 newPos = _mainCam.ScreenToWorldPoint(new Vector3(randomWidth, randomHeight, 0));
        fireAtPosition = newPos;
        return newPos;
    }
    
    private Vector3 GetRandomSpawnerPosition()
    {
        int randomWidth = Random.Range(-offset, _screenWidth + offset + 1);
        int randomHeight = 0;
        
        int positiveHeight = Random.Range(1, 3);
        if (positiveHeight == 1)
        {
            randomHeight = _screenHeight + offset;
        }
        else
        {
            randomHeight = 0 - offset;
        }
        
        Vector3 newPos = _mainCam.ScreenToWorldPoint(new Vector3(randomWidth, randomHeight, 0));
        return newPos;
    }
    
    // When the game object 
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(fireAtPosition, .5f);
        
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(spawnerPosition, .5f);
    }
}
