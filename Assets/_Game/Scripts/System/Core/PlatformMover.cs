using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    float speed;
    float range;
    Vector3 startPos;
    Vector3 direction;

    void Start()
    {
        startPos = transform.position;
        speed = Random.Range(3f, 5f);              // Tốc độ ngẫu nhiên
        range = Random.Range(1.5f, 2f);            // Biên độ di chuyển
        direction = (Random.value > 0.5f) ? Vector3.left : Vector3.right; // Hướng ban đầu
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * range;
        transform.position = startPos + direction * offset;
    }
}
