using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleController : EnemyController
{
    public override void SetEnemyPool()
    {
        ObsticlePool.Instance.Set(this);
    }
}
