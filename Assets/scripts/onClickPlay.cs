using UnityEngine;
using UnityEngine.SceneManagement;
public class onClickPlay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int i = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick(){
        SceneManager.LoadScene(i);
    }
}
