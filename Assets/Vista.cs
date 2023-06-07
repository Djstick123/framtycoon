using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vista : MonoBehaviour
{
    public GameObject pigPrefab;
    public int maxPigs = 5;
    public float spawnInterval = 2.0f;

    private int currentPigs = 0;

    private void Start()
    {

        InvokeRepeating("SpawnPig", 0.0f, spawnInterval);
    }

    private void SpawnPig()
    {
        if (currentPigs >= maxPigs)
            return;

        Vector3 randomPos = transform.position + new Vector3(Random.Range(-1.0f, 1.0f), 0.0f, Random.Range(-1.0f, 1.0f));


        GameObject newPig = Instantiate(pigPrefab, randomPos, Quaternion.identity);

        currentPigs++;
    }
}