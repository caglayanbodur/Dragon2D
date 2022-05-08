using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyController : LifeCycleController
{
    public override void KillGameObject()
    {
        _currentTime = 0f;
        SetEnemyPool();
    }

    public abstract void SetEnemyPool();
}
