using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float speed = 2000f;
    public float sideSpeed = 1000f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-sideSpeed * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sideSpeed * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
    }
}