using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        HealthBarScript.health -= 10f;
    }
}
