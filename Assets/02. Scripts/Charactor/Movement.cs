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

        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normalDir = dir.normalized;   // 정규화 과정 - 벡터값의 합이 1이 넘어갈 경우를 대비해 값을 0~1 사이의 값으로 보정 해주는 작업
        Debug.Log($"현재 입력 : {normalDir} ");

        transform.position += normalDir * moveSpeed * Time.deltaTime;
        transform.LookAt(transform.position + normalDir);
    }


}
