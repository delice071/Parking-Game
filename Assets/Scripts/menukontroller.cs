using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menukontroller : MonoBehaviour
{
    public void Start()
    {
        Time.timeScale= 1.0f;
    }
    public void Startt()
    {
        SceneManager.LoadScene(1);
    }
    public void exitt()
    {
        Application.Quit();
    }
}
