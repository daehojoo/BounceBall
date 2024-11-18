using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImGameManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickClip;
    public void Start()
    {
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }
    public void RestartBtn()
    { 
        audioSource.PlayOneShot(clickClip);
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
    public void HomeBtn()
    {
        audioSource.PlayOneShot(clickClip);
        SceneManager.LoadScene("StartScene");

    }










}
