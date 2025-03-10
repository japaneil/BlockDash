using Unity.Mathematics;
using UnityEditor.Build.Content;
using UnityEngine;

public class levelWon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject road;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            // manager.levelEnd();
            Instantiate(road, new Vector3(0.5638095f,1.499999f,100f), quaternion.identity);
    }
    }
}
