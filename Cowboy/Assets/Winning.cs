using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{
    public string sceneToLoad = "Menu"; // Replace with the name of the scene you want to load

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        SceneManager.LoadScene(sceneToLoad);
        
    }
}