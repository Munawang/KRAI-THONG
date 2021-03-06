﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss_Lv1 : MonoBehaviour
{

    void TurnOffGameObject()
    {
        gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy" || col.tag == "Krithong" || col.tag == "Heart")        {
            HealthBarBoss.health -= 0f;
        }
        else
        {
            HealthBarBoss.health -= 10f;
            if (HealthBarBoss.health == 0){
                Invoke("TurnOffGameObject", 0f);                
                SceneManager.LoadScene("PassScoreLv.1"); 
            }
        }
        
         
    }
}
