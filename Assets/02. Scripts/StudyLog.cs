using UnityEngine;
/// <summary>
/// 유니티 Console 창에 디버그 메시지 띄워보는 스크립트
/// </summary>
public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start 함수 실행");
        Debug.LogWarning("Start 함수 실행");
        Debug.LogError("Start 함수 실행");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
