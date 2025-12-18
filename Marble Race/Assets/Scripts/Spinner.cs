using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -speed);
        }
    }
}
