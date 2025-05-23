using UnityEngine; // UnityEngine이라는 namespace를 활용하겠다

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;
    public Mesh mesh;
    public Material mat;

    void Start()
    {
        
        CreateCube(mesh, mat);


    }
    void Update()
    {
        //obj = GameObject.Find("Main Camera"); // Main Camera 오브젝트를 찾아서 할당하는 기능
        //obj = GameObject.FindGameObjectWithTag("Player");

        //objtf = GameObject.FindGameObjectWithTag("Player").transform;

        //obj.GetComponent<MeshRenderer>().enabled = false;

        //obj.SetActive(false);

        //Debug.Log($"<color=#FF0000>이름 : {obj.name}</color>");    // 게임 오브젝트의 이름
        //Debug.Log($"<color=#FF0000>태그 : {obj.tag}</color>");     // 게임 오브젝트의 태그
        //Debug.Log($"<color=#FF0000>위치 : {obj.transform.position}</color>");      // 게임 오브젝트의 Transform 컴포넌트의 위치
        //Debug.Log($"<color=#FF0000>회전 : {obj.transform.rotation}</color>");      // 게임 오브젝트의 Transform 컴포넌트의 회전 값
        //Debug.Log($"<color=#FF0000>크기 : {obj.transform.localScale} </color>");    // 게임 오브젝트의 Transform 컴포넌트의 크기
        //Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");

        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");

        //obj.name = changeName;
    }


    // 코드상에서 GameObject 생성 및 컴포넌트 추가하기
    // 큐브 만들기
    public void CreateCube(Mesh mesh0, Material mat0)
    {//obj = GameObject.CreatePrimitive(PrimitiveType.Cube); // 큐브 생성하기 지원 메소드
        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>().mesh = mesh0;
        obj.AddComponent<MeshRenderer>().material = mat0;
        obj.AddComponent<BoxCollider>();
    }

}
