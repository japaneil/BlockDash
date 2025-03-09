using System.Diagnostics;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    [Range(7f,15f)]public float smoothSpeed; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed*Time.deltaTime);
        transform.position = smoothedPosition;
    }
}
