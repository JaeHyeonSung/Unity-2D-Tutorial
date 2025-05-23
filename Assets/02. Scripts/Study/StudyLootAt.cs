using UnityEngine;

public class StudyLootAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    public GameObject bulletPrefab;  // 총알 프리팹
    public Transform firePos;  // 발사 위치
    public float timer;
    public float cooldownTime;
    void Start()
    {
        cooldownTime = 1f;
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()       // 무언가를 바라보는 기능
    {
        turretHead.LookAt(targetTf);
        timer += Time.deltaTime;
        if(timer >= cooldownTime)
        {
            timer = 0f;
            
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
        
    }
}
