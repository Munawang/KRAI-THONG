using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Krithong_Lv2: MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            HealthBarKT.health -= 10f;
            if (HealthBarKT.health == 0)
            {
                SceneManager.LoadScene("FailScoreLv.2");
            }
        }
        else if (col.tag == "Heart") {
            HealthBarKT.health += 10f;
        }
        else
        {
            HealthBarKT.health -= 0f;
        }
    }
}
