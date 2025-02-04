using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    [SerializeField]
    string goodLevelName,badLevelName;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            if (other.GetComponent<walk>().isGlassOn)
            {
                SceneManager.LoadScene(goodLevelName);
            }
            else
            {
                SceneManager.LoadScene(badLevelName);
            }
        }
    }
}
