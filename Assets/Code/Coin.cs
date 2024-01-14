using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    TMP_Text t;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "Coins:" + StaticVariables.coins.ToString();
    }
}
