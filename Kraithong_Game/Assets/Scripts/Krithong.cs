using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Krithong : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            HealthBarKT.health -= 10f;
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
