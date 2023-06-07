using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walltwo : MonoBehaviour
{

    private void Start()
    {
        Invoke("DestroyWall",40f);
    }

    private void DestroyWall()
    {
        Destroy(gameObject);
    }
}
