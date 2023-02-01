using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetableSpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay;
    [SerializeField] private GameObject[] vegetablePrefabs;
    [SerializeField] private Transform spawnerPoint;
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
        var vegetable = Instantiate( vegetablePrefabs[randomObject], spawnerPoint.position, randomRotation, spawnerPoint);
        Vegetables vegetableScript = vegetable.GetComponent<Vegetables>();
        vegetableScript.myTypeIndex = randomObject;
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
