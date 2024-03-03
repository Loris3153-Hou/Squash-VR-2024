using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeTexte : MonoBehaviour
{
    public Text Text_Timer;
    public float TimerEnSeconde = 20f;
    public int scene;

    void Start()
    {

        Text_Timer.text = FormatTimer(TimerEnSeconde);
 
    }

    void Update()
    {
        if (TimerEnSeconde > 0)
        {
            TimerEnSeconde -= Time.deltaTime;

            Text_Timer.text = FormatTimer(TimerEnSeconde);

            if (TimerEnSeconde <= 0)
            {
                TimerEnSeconde = 0;
                Text_Timer.text = FormatTimer(TimerEnSeconde);
                SceneManager.LoadScene(scene);
                Debug.Log("Fin de la session !");
            }
        }
    }

    private string FormatTimer(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
