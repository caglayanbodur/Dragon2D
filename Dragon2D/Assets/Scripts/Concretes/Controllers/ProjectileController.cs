using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : LifeCycleController
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        EnemyController enemy = col.GetComponent<EnemyController>();
        if (enemy != null)
        { 
            GameManager.Instance.IncreaseScore();
            enemy.KillGameObject();
        }
        KillGameObject();

    }

    public override void KillGameObject()
    {
        Destroy(this.gameObject);
    }
}
