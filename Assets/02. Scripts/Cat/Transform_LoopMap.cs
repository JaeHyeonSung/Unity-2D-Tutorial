using TMPro;
using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{

    public float moveSpeed = 3f;
    // 배경 이미지의 길이가 30이기 때문에 x는 30에 재배치 하는 위치 지정
    public Vector3 returnPos ;
    private void Start()
    {
       returnPos = new Vector3(30f, transform.position.y, transform.position.z);
    }
    void Update()
    {
        // 배경을 왼쪽으로 이동하는 코드
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        
        if(transform.position.x <= -29f)
        {
            transform.position = returnPos;
        }
    
    }
}
