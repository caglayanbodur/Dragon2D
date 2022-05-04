using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        SingletonThisGameObject();
    }

    private void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void RestartGame()
    {
        StartCoroutine(RestartGameAsync());
    }

    public IEnumerator RestartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }
}
