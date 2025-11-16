using UnityEngine;

public class Player : MonoBehaviour

{
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;

    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {

        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        //// 1. 힘을 준다.
        //rigid.AddForce(inputVec);

        //// 2. 속도 제어
        //rigid.linearVelocity = inputVec;

        // 3. 위치 이동d
        rigid.MovePosition(rigid.position + nextVec);
    }
}

