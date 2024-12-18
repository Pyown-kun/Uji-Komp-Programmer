using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private float time;
    [SerializeField] private float timer;

    public Camera MainCamera;
    public Camera RanderCamera;

    public GameObject InGameUI;
    public GameObject GameOver;

    public PlayerAnimation PlayerAnimation;

    public GameObject StopWall;

    public Text TimeText;

    public bool GameEnd;

    private void Start()
    {
        time = timer;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        TimeText.text = "Timer: " + timer;

        if (timer <= 0)
        {
            MainCamera.enabled = false;
            RanderCamera.enabled = true;

            InGameUI.SetActive(false);
            GameOver.SetActive(true);

            //Time.timeScale = 0;

            StopWall.SetActive(true);

            PlayerAnimation.Victory();

            GameEnd = true;
        }
    }
}
