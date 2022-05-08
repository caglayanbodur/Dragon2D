using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    private void Awake()
    {
        gameOverPanel = transform.GetChild(1).gameObject;
    }

    private void Start()
    {
        Dead dead = FindObjectOfType<Dead>();
        dead.OnDead += HandleOnDead;
    }

    private void HandleOnDead()
    {
        gameOverPanel.SetActive(true);
    }
}
