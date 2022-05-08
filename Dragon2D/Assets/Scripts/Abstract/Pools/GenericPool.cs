using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class GenericPool<T> : MonoBehaviour where T : Component
{
    [SerializeField] private T[] prefabs;
    [SerializeField] private int countLoop = 5;

    private Queue<T> _poolPrefabs = new Queue<T>();

    private void Awake()
    {
        SingletonObject();
    }

    private void OnEnable()
    {
        GameManager.Instance.OnSceneChanged += ResetAllObjects;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnSceneChanged -= ResetAllObjects;

    }

    private void Start()
    {
        GrowPoolPrefab();
    }

    protected abstract void SingletonObject();

    public T Get()
    {
        if (_poolPrefabs.Count == 0)
        {
            GrowPoolPrefab();

        }

        return _poolPrefabs.Dequeue();
    }

    public abstract void ResetAllObjects();
    private void GrowPoolPrefab()
    {
        for (int i = 0; i < countLoop; i++)
        {
            T newPrefab = Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
            newPrefab.transform.parent = this.transform;
            newPrefab.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(newPrefab);
        }
    }

    public void Set(T poolObject)
    {
        poolObject.gameObject.SetActive(false);
        _poolPrefabs.Enqueue(poolObject);
    }
}
