﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Buttons : MonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

}