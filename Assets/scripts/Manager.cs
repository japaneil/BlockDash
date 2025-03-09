using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Manager : MonoBehaviour
{
    bool isGameEnded = false;
    public GameObject levelCompleteUI;
    public PlayerCollision playerCollision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async Task endGame(){
        if(!isGameEnded){
        Debug.Log("Game Over");
        isGameEnded = true;
        await restart();
        }
    }

    async Task restart(){
        await Task.Delay(1000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public async Task levelEnd()
    {
        Debug.Log("Level Won!");
        if (playerCollision.isHit == false)
        {
            levelCompleteUI.SetActive(true);
            await Task.Delay(500);
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
        }
    }
}
