using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss_Lv2 : MonoBehaviour
{

    void TurnOffGameObject()
    {
        gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")        {
            HealthBarBoss.health -= 0f;
        }
        else
        {
            HealthBarBoss.health -= 10f;
            if (HealthBarBoss.health == 0){
                Invoke("TurnOffGameObject", 0f);
                SceneManager.LoadScene("PassScoreLv.2");
            }
        }
        
         
    }
}
