using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    // Update is called once per frame
    void Update()
    {
        // 월드 이동
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 이동
        //transform.localPosition += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 이동
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // 월드 회전
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);

        // 로컬 회전
        //transform.localRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);

        //로컬 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

        // 월드 방향 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        // 특정 지점 방향을 바라보며 회전
        transform.LookAt(Vector3.zero);
    }
}
