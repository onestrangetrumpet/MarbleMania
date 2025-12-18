using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform marbleToFollow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keep camera following the marble
        transform.position = marbleToFollow.position;

        //Check for A and D input - Horizontal Rotation
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -50f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 50f * Time.deltaTime, 0);
        }
    }
}
