using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;
    public bool isStop;
    private void Start()
    {
        rotSpeed = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5f;
        }
        this.transform.Rotate(Vector3.forward, rotSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if (isStop == true)
        {
            rotSpeed *= 0.98f; // 현재 속도에서 특정 값만큼 줄이는 기능
            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }
    }
}
