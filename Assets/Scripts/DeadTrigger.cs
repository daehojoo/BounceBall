using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip deathClip;
    public void Start()
    {
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        deathClip = Resources.Load("DeathSound") as AudioClip;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(deathClip);
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);

        }
    }









}
