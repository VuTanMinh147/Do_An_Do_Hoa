using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    public AudioSource BottonClick;
    public void BackmenuBotton()
    {
        StartCoroutine(Backmenu());
    }
    IEnumerator Backmenu()
    {
        BottonClick.Play();
        SceneManager.LoadScene(0);
        yield return new WaitForSeconds(0.0f);
    }
}
