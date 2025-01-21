using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoadSceneManager : MonoBehaviour
{
    public string levelName;
    private void Start()
    {
        StartCoroutine(StartNewScene());
    }
    IEnumerator StartNewScene() 
    {         
        yield return new WaitForSeconds(3);
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);
    }
}
