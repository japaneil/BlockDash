using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using FirstGearGames.SmoothCameraShaker;
public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement script;
    public MeshRenderer mesh;
    public BoxCollider boxCollider;
    public ParticleSystem particle;
    public bool isHit = false;
    public Transform player;
    public Rigidbody rb;
    public AudioSource audioSource;
    public ShakeData shakeData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.y < -3f){
            _ = FindFirstObjectByType<Manager>().endGame();
        }
    }

    void OnCollisionEnter(Collision collisionP){
        if(collisionP.collider.tag == "obs"){
            rb.freezeRotation = true;
            mesh.enabled = false;
            script.enabled = false;
            rb.linearVelocity = Vector3.zero;
            particle.Play();
            audioSource.Play();
            CameraShakerHandler.Shake(shakeData);
            GameObject.FindGameObjectWithTag("ps").SetActive(true);
            isHit = true;
            _ = FindFirstObjectByType<Manager>().endGame();
        }
    }
}
