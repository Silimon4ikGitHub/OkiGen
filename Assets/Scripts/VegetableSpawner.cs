using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] vegetablePrefabs;
    [SerializeField] private Transform spawnerPoint;
    [SerializeField] private float spawnDelay;
    private float _timeCounter;

    void FixedUpdate()
    {
        _timeCounter += Time.deltaTime;
        
            SpawnWithDelay();
        
    }

    private void SpawnVegetable()
    {
        Quaternion randomRotation = new Quaternion (Random.Range(0,180),Random.Range(0,180),Random.Range(0,180), 0);
        int randomObject = Random.Range(0, vegetablePrefabs.Length);
        var pin = Instantiate( vegetablePrefabs[randomObject], spawnerPoint.position, randomRotation, spawnerPoint);
    }

    private void SpawnWithDelay()
    {
        if (_timeCounter >= spawnDelay)
        {
            SpawnVegetable();
            _timeCounter = 0;
        }
    }
}
