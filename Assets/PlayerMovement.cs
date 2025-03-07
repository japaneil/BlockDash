using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed = 2000f;
    public float sideSpeed = 1000f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // rigidbody.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("w"))
        {
            rigidbody.AddForce(0,0,speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-sideSpeed * Time.deltaTime,0,0);
        }
        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sideSpeed * Time.deltaTime,0,0);
        }
    }
}