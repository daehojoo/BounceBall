using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyUiManager : MonoBehaviour
{
    public Sprite bgmMuteSprite;
    public Sprite bgmPlaySprite;

    public Sprite soundMuteSprite;
    public Sprite soundPlaySprite;

    public AudioClip btnClickedSound;
    public AudioSource bgmAudioSource;
    public AudioSource soundAudioSource;


    public Image bgmImage;
    public Image soundImage;


    public Image levelImage;
    public Image optionImage;
    public Image helpImage;

    public Scrollbar bgmScroll;
    public Scrollbar soundScroll;
    public void Start()
    {
        bgmAudioSource = GameObject.Find("BGMManager").GetComponent<AudioSource>();
        soundAudioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();

        levelImage.gameObject.SetActive(false);
        optionImage.gameObject.SetActive(false);
        helpImage.gameObject.SetActive(false);
    }
    public void Update()
    {
        bgmAudioSource.volume = bgmScroll.value;
        soundAudioSource.volume = soundScroll.value;
    }
    public void BGMMuteClicked()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        if (bgmAudioSource.mute == false)
        {
            bgmAudioSource.mute = true;
            bgmImage.sprite = bgmMuteSprite;
        }
        else if (bgmAudioSource.mute == true)
        {
            bgmAudioSource.mute = false;
            bgmImage.sprite = bgmPlaySprite;
        }
    }
    public void SoundMuteClicked()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        if (soundAudioSource.mute == false)
        {
            soundAudioSource.mute = true;
            soundImage.sprite = soundMuteSprite;
        }
        else if (soundAudioSource.mute == true)
        {
            soundAudioSource.mute = false;
            soundImage.sprite = soundPlaySprite;
        }
    }
    public void BackHome()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        optionImage.gameObject.SetActive(false);
        levelImage.gameObject.SetActive(false);
        helpImage.gameObject.SetActive(false);
    }
    public void OpenLevelBtn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        levelImage.gameObject.SetActive(true);
    }
    public void OpenOptionBtn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        optionImage.gameObject.SetActive(true);
    }
    public void OpenHelpBtn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        helpImage.gameObject.SetActive(true);
    }
    public void Lv1Btn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        
            SceneManager.LoadScene("Lv1");
    }
    public void Lv2Btn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        
            SceneManager.LoadScene("Lv2");
    }
    public void Lv3Btn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        
            SceneManager.LoadScene("Lv3");
    }
    public void Lv4Btn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        
            SceneManager.LoadScene("Lv4");
    }
    public void Lv5Btn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        
            SceneManager.LoadScene("Lv5");
    }
    public void Lv6Btn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        
            SceneManager.LoadScene("Lv6");
    }
    public void Lv7Btn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        
            SceneManager.LoadScene("Lv7");
    }
    public void Lv8Btn()
    {
        soundAudioSource.PlayOneShot(btnClickedSound);
        
            SceneManager.LoadScene("Lv8");
    }






}
