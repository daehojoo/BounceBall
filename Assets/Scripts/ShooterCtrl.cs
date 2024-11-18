using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterCtrl : MonoBehaviour
{
    public void Start()
    {

    }

    public void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has stepped on the Shooter");

            // 플레이어의 Rigidbody2D 컴포넌트 가져오기
            Rigidbody2D collisonRb = collision.gameObject.GetComponentInParent<Rigidbody2D>();
            collisonRb.gravityScale = 0f;
            // 발판의 방향 벡터 계산 (발판의 위쪽 방향)
            Vector2 shooterDirection = transform.up; // 발판의 위쪽 방향

            // 플레이어를 발판의 위치로 이동시키기
            collision.transform.position = (Vector2)transform.position + shooterDirection * 3f; // 3f는 약간의 오프셋

            // 힘을 가하기
            collisonRb.velocity = Vector2.zero; // 기존 속도를 초기화
            collisonRb.AddForce(shooterDirection * 1000f); // 발판의 방향으로 힘을 가함
        }
    }
}
