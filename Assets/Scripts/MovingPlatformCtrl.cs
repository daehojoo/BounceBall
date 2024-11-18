using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    public float speed = 2f; // 이동 속도
    public float distance = 5f; // 이동 범위

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
        // 이동 비율 계산
        float journeyProgress = Mathf.PingPong(Time.time * speed, journeyLength);
        // 새로운 위치 계산
        transform.position = Vector3.Lerp(startPosition, targetPosition, journeyProgress / journeyLength);
    }
}
