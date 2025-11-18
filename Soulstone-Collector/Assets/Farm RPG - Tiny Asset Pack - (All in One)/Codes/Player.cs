using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour

{
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;

    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        Vector2 nextVec = inputVec * speed * Time.fixedDeltaTime;
        // 1. 힘을 준다.
        //rigid.AddForce(inputVec);

        // 2. 속도 제어
        //rigid.linearVelocity = inputVec;

        // 3. 위치 이동
        rigid.MovePosition(rigid.position + nextVec);
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

}

