using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ArenaObjects : MonoBehaviour
{
    public GameObject[] ArenaObj;
    public List<Transform> Points;

    private void Start()
    {
        Points = new List<Transform>(Points);
        SpawnObj();
    }

    private void SpawnObj()
    {
        for (int i = 0; i < ArenaObj.Length; i++)
        {
            var Spawn = Random.Range(0, Points.Count);
            Instantiate(ArenaObj[i], Points[Spawn].transform.position, Quaternion.identity);
            Points.RemoveAt(Spawn);
        }
    }
}
