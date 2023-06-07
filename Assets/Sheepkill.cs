using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheepkill : MonoBehaviour
{
    public GameObject coinPrefab;
    public float lifespan = 10f;

    private void Start()
    {
        Destroy(gameObject, lifespan);
    }

    private void OnDestroy()
    {
        DropCoin();
    }

    private void DropCoin()
    {
        Instantiate(coinPrefab, transform.position, Quaternion.identity);
    }
}
