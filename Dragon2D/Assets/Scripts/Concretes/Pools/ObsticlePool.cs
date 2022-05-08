using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticlePool : GenericPool<ObsticleController>
{
    public static ObsticlePool Instance { get; private set; }

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
