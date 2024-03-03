using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RecupScore : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score.text = PlayerPrefs.GetString("score");

    }
}
