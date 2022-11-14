using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class Spawn : MonoBehaviour
{
    [Header("Factory")]
    [Space(10)]
    [SerializeField] Mesh enemyMesh;
    [SerializeField] Material[] materials;
    [SerializeField] ItemData data;
    [Space(20)]
    [SerializeField] Transform[] enemiesSpawns;
    void Start()
    {
        InvokeRepeating("CreateEnemy", 0.0f, 3.0f);
    }

    void CreateEnemy()
    {
        int randomPos = Random.Range(0,enemiesSpawns.Length);
        Factory.CreateObject(enemyMesh,materials,enemiesSpawns[randomPos].position,data);
    }
}
