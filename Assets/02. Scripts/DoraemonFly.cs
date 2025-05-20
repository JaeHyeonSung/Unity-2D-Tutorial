using UnityEngine;

public class DoraemonFly : MonoBehaviour
{
    [SerializeField]
    private float flyingSpeed = 0.02f;
    bool isUp = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 1.25f)
        {
            isUp = false;
        }
        else if(transform.position.y < 0)
        {
            isUp = true;
        }
        Flying();
    }

    public void Flying()
    {
        if (isUp)
        {
            transform.position += Vector3.up * flyingSpeed;
        }
        else
        {
            transform.position -= Vector3.up * flyingSpeed;
        }
    }

    
}
