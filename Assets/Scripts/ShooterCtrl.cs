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

            // �÷��̾��� Rigidbody2D ������Ʈ ��������
            Rigidbody2D collisonRb = collision.gameObject.GetComponentInParent<Rigidbody2D>();
            collisonRb.gravityScale = 0f;
            // ������ ���� ���� ��� (������ ���� ����)
            Vector2 shooterDirection = transform.up; // ������ ���� ����

            // �÷��̾ ������ ��ġ�� �̵���Ű��
            collision.transform.position = (Vector2)transform.position + shooterDirection * 3f; // 3f�� �ణ�� ������

            // ���� ���ϱ�
            collisonRb.velocity = Vector2.zero; // ���� �ӵ��� �ʱ�ȭ
            collisonRb.AddForce(shooterDirection * 1000f); // ������ �������� ���� ����
        }
    }
}
