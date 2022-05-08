using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDragonSpawner : BaseSpawer
{ 


    protected override void Spawn()
    {
        EnemyController newEnemy = RedDragonPool.Instance.Get();
        newEnemy.transform.position = transform.position;
        newEnemy.gameObject.SetActive(true);
    }
}
