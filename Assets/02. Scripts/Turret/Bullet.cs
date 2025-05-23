using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed=100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        // transform.forward : 로컬 좌표의 정면(this 의 정면)
        // Vector3.forward : 월드 좌표계의 정면
    }
}
