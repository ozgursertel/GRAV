using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public float x;
    private float timer =2;
    private float countdown = 2f;
    private Vector2 vec2;
    private int platformSelectNum;

    // Update is called once per frame
    void Update()
    {
        countdown = countdown - Time.deltaTime;
        if (countdown <= 0)
        {
            vec2 = new Vector2(x, 0);
            platformSelectNum = UnityEngine.Random.Range(0,3);
            SpawnLvls();
            x = x + 12;
            countdown = timer;
        }
    }

    private void SpawnLvls()
    {
        switch (platformSelectNum)
        {
            case 0:
                ObjectPooler.Instance.SpawnFromPool("Lvl1", vec2, Quaternion.identity);
                break;
            case 1:
                ObjectPooler.Instance.SpawnFromPool("Lvl2", vec2, Quaternion.identity);
                break;
            case 2:
                ObjectPooler.Instance.SpawnFromPool("Lvl3", vec2, Quaternion.identity);
                break;
        }
    }
}
