using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private float time;
    [SerializeField] private float timer;

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
            SceneManager.LoadScene(1);
            PlayerAnimation.Victory();
        }
    }
}
