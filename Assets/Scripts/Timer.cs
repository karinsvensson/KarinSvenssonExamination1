using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] float targetTime = 30f;
    [SerializeField] GameObject WinSceneUI;
    [SerializeField] TMP_Text timer;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {
        targetTime -= Time.deltaTime;
        timer.text = "Time left " + targetTime.ToString() + "s";
        if(targetTime <= 0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        WinSceneUI.SetActive(true);
        Time.timeScale = 0;
    }

}
