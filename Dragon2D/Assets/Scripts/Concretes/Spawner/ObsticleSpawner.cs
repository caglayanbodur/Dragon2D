using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObsticleSpawner : BaseSpawer
{
  

    [SerializeField] private EnemyController[] enemies;

    protected override void Spawn()
    {
        int enemyIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[enemyIndex], this.transform);

    }

  
}
