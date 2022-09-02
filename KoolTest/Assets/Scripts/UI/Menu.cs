using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator anim;
    public float transitionTime = 1f;

    //Load any level by using name inside Inspector
    public void LoadLevel(string a)
    {
        StartCoroutine(LoadLevelAnim(a));
    }

    IEnumerator LoadLevelAnim(string a)
    {
        anim.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(a);
    }

    //Close the App
    public void Exit()
    {
        Application.Quit();
    }

    public void RequestSaveLevel()
    {
        //save level here
    }
}

