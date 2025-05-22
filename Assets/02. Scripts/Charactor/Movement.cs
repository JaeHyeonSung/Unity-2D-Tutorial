using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;

    void Start() //유니티 에디터에서 실행했을 떄 1번 실행되는 함수
    {
        moveSpeed = 2.0f;
    }


    void Update() //유니티 에디터에서 실행 이후에 매 프레임마다 1번 실행되는 함수
    {

        Move();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir} ");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }


}
