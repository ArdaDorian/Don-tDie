using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoteSceneManager : MonoBehaviour
{
    int collectedNotes = 0;
    public int totalNotes;
    public int currentTime =30;
    public TextMeshProUGUI timerText;

    private void Start()
    {
        totalNotes = GameObject.FindGameObjectsWithTag("Note").Length;
        StartCoroutine(CountDown());
    }
    public void CollectNote()
    {
        collectedNotes++;
        if (collectedNotes >= totalNotes)
        {
            SceneManager.LoadScene("win");
        }
    }

    IEnumerator CountDown()
    {
        while (currentTime > 0)
        {
            yield return new WaitForSeconds(1);
            currentTime--;
            timerText.text = currentTime.ToString();
        }
        SceneManager.LoadScene("lose");
    }
}
