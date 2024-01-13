using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StaticVariables.Scores = 0;
        StaticVariables.coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetTheGame()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("Its working");
    }
}
