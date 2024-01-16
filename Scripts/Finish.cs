using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    private bool levelComplete = false;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "_Sprite" && !levelComplete )
        {
           
            levelComplete = true;
            Invoke("CompleteLevelWithDelay", 0.5f); 
        }
    }

    private void CompleteLevelWithDelay()
    {
        Invoke("LoadNextScene", 0.5f); 
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}