using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDragonController : EnemyController
{
    public override void SetEnemyPool()
    {
        RedDragonPool.Instance.Set(this);
    }
}
