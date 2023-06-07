using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallone : MonoBehaviour
{

    private void Start()
    {
        Invoke("DestroyWall", 15f);
    }

    private void DestroyWall()
    {
        Destroy(gameObject);
    }
}
