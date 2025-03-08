using System.Threading.Tasks;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    bool isGameEnded = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endGame(){
        if(!isGameEnded){
        Debug.Log("Game Over");
        isGameEnded = true;
        restart();
        }
    }

    async Task restart(){
        await Task.Delay(1000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void levelEnd(){
        Debug.Log("Level Won!");
    }
}
