using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthbar;
    public float healthamount = 100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (StaticVariables.hit == true)
        {
            TakeDamage();
            StaticVariables.hit = false;

        }

     


        if (Input.GetKeyDown(KeyCode.B))
            {
            Heal();

            }
    }

    public void TakeDamage()
    {
        //StaticVariables.damage = 20f;
        
        healthamount -= StaticVariables.damage;
        healthbar.fillAmount = healthamount/100f;
        
    }

    public void Heal()
    {
        StaticVariables.healingamount = 5f;

        healthamount += StaticVariables.healingamount;

        healthamount = Mathf.Clamp(healthamount, 0, 100f);

        healthbar.fillAmount = healthamount / 100f;
    }

}

    


