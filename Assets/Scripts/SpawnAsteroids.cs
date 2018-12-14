﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour {
    [Header("Set in Inspector")]
    public GameObject AsterPrefab;
    public float spawnPerSec = 1f;
    public float spawnPadding = 1.5f;
    public Vector3 spawnZone;

    void Awake()
    {
        Invoke("SpawnAster", 1f / spawnPerSec);
    }

    void SpawnAster()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnZone.x, spawnZone.x), spawnZone.y, spawnZone.z);
        Instantiate(AsterPrefab, spawnPos, Quaternion.identity);
        Invoke("SpawnAster", 1f / spawnPerSec);
    }
}
