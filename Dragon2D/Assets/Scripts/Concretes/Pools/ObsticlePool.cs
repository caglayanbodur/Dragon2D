using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticlePool : GenericPool<ObsticleController>
{
    public static ObsticlePool Instance { get; private set; }
    public override void ResetAllObjects()
    {
        foreach (ObsticleController child in GetComponentsInChildren<ObsticleController>() )
        {
            if(!child.gameObject.activeSelf) continue;
            child.KillGameObject();
            
        }
    }

    protected override void SingletonObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
}
