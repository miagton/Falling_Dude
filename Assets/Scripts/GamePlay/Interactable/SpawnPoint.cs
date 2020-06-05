using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    int i;
    void Start()
    {
        i = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[i], transform.position, Quaternion.identity);
    }

    
}
