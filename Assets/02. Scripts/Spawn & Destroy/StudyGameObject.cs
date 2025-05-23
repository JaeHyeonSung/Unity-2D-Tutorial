using UnityEditor;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{

    public GameObject prefab;
    

    private void Awake()
    {
        Debug.Log("생성 되었습니다.");
        CreateAmongUs();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    /// <summary>
    /// 어몽어스 캐릭터를 생성하는 기능
    /// 오브젝트 이름을 변경하는 기능
    /// </summary>
    public void CreateAmongUs()
    {
        GameObject go = Instantiate(prefab);
        go.name = "어몽어스 캐릭터";
    }
}
