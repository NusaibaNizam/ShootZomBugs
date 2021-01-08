using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Button : MonoBehaviour {
    public AudioClip button;
    AudioSource bAudio;
    private void Start()
    {
        bAudio = gameObject.GetComponent<AudioSource>();
    }
    public void startGame()
    {
        SceneManager.LoadScene("Scene1");
        bAudio.clip = button;
        bAudio.Play();
    }
    public void intro()
    {
        SceneManager.LoadScene("intro");
        bAudio.clip = button;
        bAudio.Play();
    }
    public void Quit()
    {
        Application.Quit();
        bAudio.clip = button;
        bAudio.Play();
    }
}
