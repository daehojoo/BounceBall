using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterStar : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clearClip;
    public void Start()
    {
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        clearClip = Resources.Load("ClearSound")as AudioClip;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(clearClip);
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        int currentLevel;

        // Extract level number from scene name
        if (int.TryParse(currentScene.Substring(2), out currentLevel)) // Assuming "Lv1", "Lv2", etc.
        {
            currentLevel++;
            string nextScene = "Lv" + currentLevel;

            // Check if the next scene exists before loading
            if (Application.CanStreamedLevelBeLoaded(nextScene))
            {
                SceneManager.LoadScene(nextScene);
            }
            else
            {
                Debug.Log("No such scene: " + nextScene);
                SceneManager.LoadScene("StartScene");
            }
        }
        else
        {
            Debug.Log("Current scene is not in the expected format: " + currentScene);
        }
    }
}
