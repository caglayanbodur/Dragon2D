using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentObject : MonoBehaviour
{
   [SerializeField] private GameObject persistentPrefab;
   private static bool _isFirstTime = true;
   private void Start()
   {
      if (_isFirstTime)
      {
         SpawnPersistentObject();
         _isFirstTime = false;
      }
   }

   private void SpawnPersistentObject()
   {
      GameObject newObject = Instantiate(persistentPrefab);
      DontDestroyOnLoad(newObject);
      
   }
}
