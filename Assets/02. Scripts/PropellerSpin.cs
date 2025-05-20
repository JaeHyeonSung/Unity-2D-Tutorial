using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    private float spinSpeed = 200f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f);
    }
}
