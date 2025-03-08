using UnityEditor.Build.Content;
using UnityEngine;

public class levelWon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Manager manager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            manager.levelEnd();
    }
    }
}
