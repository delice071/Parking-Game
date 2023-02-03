using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CarKontrollerr : MonoBehaviour
{
    private float move, movespeed, rotation, rotationspeed;
    [SerializeField] private TMP_Text tur;
    [SerializeField] private GameObject resume, exit, win;
    public int score, scoremax;

    void Start()
    {
        Time.timeScale = 1f;
        movespeed = 6f;
        rotationspeed= 285f;
        score = 0;
        scoremax= 1;
        resume.SetActive(false);
        exit.SetActive(false);
        win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical")  * movespeed* Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * -rotationspeed* Time.deltaTime;

        tur.text = scoremax.ToString() + "/3";
    }

    private void LateUpdate()
    {
        transform.Translate(0f, move, 0f);
        transform.Rotate(0f, 0f, rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "Round")
        {
            if (score >= 3)
            {
                scoremax++;
                if (scoremax >= 4)
                {
                    scoremax--;
                    Time.timeScale= 0;
                    win.SetActive(true);
                    exit.SetActive(true);
                    Debug.Log("Game Finish");
                }
                
                score = 0;
            }
            
        }
        if (collision.gameObject.tag == "tur")
        {
            score++;
        }
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
