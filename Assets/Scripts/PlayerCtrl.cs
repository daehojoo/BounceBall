using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Transform tr;
    public Rigidbody2D rb;
    private float moveSpeed = 3f; // 이동 속도
    private float maxSpeed = 6f; // 최대 속도
    public bool isWall = false;
    private float shootSpeed = 10f; // 날아가는 속도

    private void Start()
    {
        tr = transform;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Debug.DrawRay(tr.position, new Vector2(1, 0) * 0.6f);
        Debug.DrawRay(tr.position, new Vector2(-1, 0) * 0.6f);

        // 벽 체크
        if (Physics2D.Raycast(tr.position, new Vector2(1, 0), 0.6f, 1 << 6) || Physics2D.Raycast(tr.position, new Vector2(-1, 0), 0.6f, 1 << 6))
        {
            Debug.Log("Wall");
            isWall = true;
        }
        else
            isWall = false;

        // 이동 처리
        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow) && !isWall)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            rb.gravityScale = 1f;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && !isWall)
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            rb.gravityScale = 1f;
        }
        else
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
    }

    



}
