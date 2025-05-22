using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    //public GameObject objToDestroy;  // 삭제할 오브젝트
    public GameObject prefab;
    public Quaternion rot;
    public Vector3 pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("생성 되었습니다.");
        CreateAmongUs();

    }

    /// <summary>
    /// 어몽어스 캐릭터를 생성하는 기능
    /// 오브젝트 이름을 변경하는 기능
    /// </summary>
    public void CreateAmongUs()
    {
        GameObject go = Instantiate(prefab, pos, rot);
        go.name = "어몽어스 캐릭터";
        Transform objTf = go.transform;
        int childCount = objTf.childCount;
        Debug.Log($"캐릭터의 자식 오브젝트 수 : {childCount}");

        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 {objTf.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(childCount - 1).name}");
    }
}
