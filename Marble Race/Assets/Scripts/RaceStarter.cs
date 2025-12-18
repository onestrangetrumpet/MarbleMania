using UnityEngine;

public class RaceStarter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Game has started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) 
        {
            Destroy(gameObject);
            //Debug.Log("Game is running");
        }
        
    }
}
