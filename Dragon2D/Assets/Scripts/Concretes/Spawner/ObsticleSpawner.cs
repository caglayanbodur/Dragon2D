using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObsticleSpawner : BaseSpawer
{
  
    protected override void Spawn()
    {
        EnemyController poolEnemy = ObsticlePool.Instance.Get();
        poolEnemy.transform.position = this.transform.position;
        poolEnemy.gameObject.SetActive(true);
    }

  
}
