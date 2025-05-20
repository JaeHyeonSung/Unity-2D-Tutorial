using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;

    void Start() //����Ƽ �����Ϳ��� �������� �� 1�� ����Ǵ� �Լ�
    {
        moveSpeed = 2.0f;
    }


    void Update() //����Ƽ �����Ϳ��� ���� ���Ŀ� �� �����Ӹ��� 1�� ����Ǵ� �Լ�
    {

        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
    }


}
