using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    private TextMeshProUGUI _scoreText;
    private void Awake()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        GameManager.Instance.OnScoreChanged += HandleOnScoreChanged;
        HandleOnScoreChanged();
    }

    private void OnDisable()
    {
        GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged;
    }

    private void HandleOnScoreChanged(int score = 0)
    {
        _scoreText.text = $"Score : {score}";
    }
}
