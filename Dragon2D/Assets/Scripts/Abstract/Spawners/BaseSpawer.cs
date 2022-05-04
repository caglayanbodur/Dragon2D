using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSpawer : MonoBehaviour
{
    [Range(2f, 5f)] [SerializeField] private float maxSpawnTime = 3f;
    [Range(0.3f, 1.5f)] [SerializeField] private float minSpawnTime = 1f;    
    private float _currentSpawnTime;
    private float _timeBoundy;
    private void Start()
    {            
        ResetTime();
    }
    
    private void Update()
    {
        _currentSpawnTime += Time.deltaTime;
        if (_currentSpawnTime > _timeBoundy)
        {
            Spawn();
            ResetTime();

        }
    }

    protected abstract void Spawn();
    

    private void ResetTime()
    {
        _currentSpawnTime = 0f;
        _timeBoundy = Random.Range(minSpawnTime, maxSpawnTime);
    }

}
