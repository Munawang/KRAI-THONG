﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript_Lv1 : MonoBehaviour
{
    public float speed = 5f;
    private bool canMove = true;
    

    public float bound_x = -11f;
    
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (canMove)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;

            if (temp.x < bound_x)
                gameObject.SetActive(false);


        }
    }

    void TurnOffGameObject() {
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bullet") {
            ScoreScript_Lv1.scoreValue1 += 25;
            canMove = false;
            Invoke("TurnOffGameObject", 0f);
        }
        UnityEngine.Debug.LogError("Score Lv.1  " + ScoreScript_Lv1.scoreValue1);
        
        
    }

}
