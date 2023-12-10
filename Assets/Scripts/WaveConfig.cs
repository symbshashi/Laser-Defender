using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]

public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;

    public GameObject GetEmenyPrefab()
    { 
        return enemyPrefab; 
    }
    public List<Transform> GetWayPoints()
    { 
        var WaveWayPoints = new List<Transform>();  
        foreach (Transform child in pathPrefab.transform)
        {
            WaveWayPoints.Add(child);
        }
        return WaveWayPoints; 
    } 
    public float GetTimeBetweenSpawns()
    { 
        return timeBetweenSpawns; 
    }
    public float GetSpawnRandomFactor()
    { 
        return spawnRandomFactor; 
    }
    public int GetNumbersOfEnemies()
    {
        return numberOfEnemies;
    }
    public float GetMoveSpeed()
    {
        return moveSpeed;
    }
}
