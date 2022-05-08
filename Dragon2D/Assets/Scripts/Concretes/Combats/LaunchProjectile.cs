using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    [SerializeField] private ProjectileController projectilePrefabs;
    [SerializeField] private Transform projectileTransform;
    [SerializeField] private GameObject projectileParent;
    [SerializeField] private float delayProjectile = 1f;
    private float _curruntDelayTime;
    private bool _canLaunch=false;

    private void Update()
    {
        _curruntDelayTime += Time.deltaTime;
        if (_curruntDelayTime > delayProjectile)
        {
            _canLaunch = true;
            _curruntDelayTime = 0f;
        }
    }

    public void LaunchAction()
    {
        if (_canLaunch)
        {
            
            ProjectileController newProjectile 
                = Instantiate(projectilePrefabs, projectileTransform.position, projectileTransform.rotation);
            newProjectile.transform.parent = projectileParent.transform;
            _canLaunch = false;

        }
    }
}
