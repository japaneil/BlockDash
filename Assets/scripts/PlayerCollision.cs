using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement script;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.y < -2f){
            FindFirstObjectByType<Manager>().endGame();
        }
    }

    void OnCollisionEnter(Collision collisionP){
        if(collisionP.collider.tag == "obs"){
            script.enabled = false;
            FindFirstObjectByType<Manager>().endGame();
        }
    }
}
