using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject FadeOut;
    public GameObject LoadingText;
    public AudioSource BottonClick;

    public void NewGameBotton()
    {
        StartCoroutine(NewGameStart());
    }

    IEnumerator NewGameStart()
    {
        BottonClick.Play();
        FadeOut.SetActive(true);
        LoadingText.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(1);
    }
    public void OptionBotton()
    {
        StartCoroutine(OptionStart());
    }
    IEnumerator OptionStart()
    {
        BottonClick.Play();
        SceneManager.LoadScene(2);
        yield return new WaitForSeconds(0.0f);
    }
}
