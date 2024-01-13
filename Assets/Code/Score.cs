using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    TMP_Text t;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "Score:"+ StaticVariables.Scores.ToString();

    }
}
