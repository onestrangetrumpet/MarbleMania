using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float force;
    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey("j"))
            collision.rigidbody.AddForce(transform.up * force);
    }
}
