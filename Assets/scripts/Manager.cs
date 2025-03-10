using System.Linq;
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
    float speed = 20f;
    public GameObject[] prefabInstances;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        prefabInstances = GameObject.FindGameObjectsWithTag("Finish");
        if (prefabInstances == null || prefabInstances.Length == 0)
            return;
        if(!playerCollision.isHit){
        foreach (GameObject obj in prefabInstances)
        {
            if (obj != null)
            {
                obj.transform.position += new Vector3(0, 0, -speed*Time.deltaTime); // Move right
            }
        }
        if(prefabInstances.Length > 2){
            Destroy(prefabInstances[0]);
        }
        }
    }

    public async Task endGame()
    {
        if (!isGameEnded)
        {
            Debug.Log("Game Over");
            isGameEnded = true;
            await restart();
        }
    }

    async Task restart()
    {
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