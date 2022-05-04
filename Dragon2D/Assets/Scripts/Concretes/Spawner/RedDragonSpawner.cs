using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDragonSpawner : BaseSpawer
{ 
    [SerializeField] private EnemyController enemy;


    protected override void Spawn()
    {
        Instantiate(enemy, this.transform);
    }
}
