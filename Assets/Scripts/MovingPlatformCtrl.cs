using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    public float speed = 2f; // �̵� �ӵ�
    public float distance = 5f; // �̵� ����

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float journeyLength;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + Vector3.right * distance;
        journeyLength = Vector3.Distance(startPosition, targetPosition);
    }

    void Update()
    {
        // �̵� ���� ���
        float journeyProgress = Mathf.PingPong(Time.time * speed, journeyLength);
        // ���ο� ��ġ ���
        transform.position = Vector3.Lerp(startPosition, targetPosition, journeyProgress / journeyLength);
    }
}
