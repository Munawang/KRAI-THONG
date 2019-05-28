using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_boss : MonoBehaviour
{
    private Vector2 MoveDirection;
    private float moveSpeed;

    // Start is called before the first frame update
    void OnEnable(){
        Invoke("Destroy", 3f);
    }

    // Update is called once per frame
    void Start(){
        moveSpeed = 5f;
    }

    void Update(){
        transform.Translate(MoveDirection * moveSpeed * Time.deltaTime);
    }
    public void setMoveDirection(Vector2 dir) {
        MoveDirection = dir;
    }
    private void Destroy(){
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}
