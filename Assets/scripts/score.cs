using System;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform ground;
    public TextMeshProUGUI scoreText;
    public PlayerCollision playerCollision;
    private float pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerCollision.isHit){
        pos += 1*Time.deltaTime*1.65673f;
        scoreText.text = pos.ToString("0m");
        }
    }
}
