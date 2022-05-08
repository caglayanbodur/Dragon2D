using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeCycleController : MonoBehaviour
{
    [SerializeField] private float maxLifeTime = 5f;
    protected float _currentTime;

    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > maxLifeTime)
        {
            KillGameObject();
        }
    }

    public abstract void KillGameObject();
   
}
