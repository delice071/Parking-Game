using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncontroller : MonoBehaviour
{
    [SerializeField] private GameObject resume, exit;

    public void Start()
    {
        resume.SetActive(false);
        exit.SetActive(false);
    }
    public void pausee()
    {
        Time.timeScale = 0;
        resume.SetActive(true);
        exit.SetActive(true);
    }

    public void Resumee()
    {
        Time.timeScale = 1f;
        resume.SetActive(false);
        exit.SetActive(false);
    }
    public void exitt()
    {
        SceneManager.LoadScene(0);
    }
}
