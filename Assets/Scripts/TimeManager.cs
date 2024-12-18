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

    public PlayerAnimation PlayerAnimation;

    public Text TimeText;

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

            InGameUI.active = false;

            SceneManager.LoadScene(1);
            PlayerAnimation.Victory();
        }
    }
}
