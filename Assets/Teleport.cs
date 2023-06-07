using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public AudioSource audio;

    public Transform target;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.transform.position = target.position + Vector3.up * 0.5f;

            audio.Play();
        }
    }
    
    void Start()
    {

    }

   
    void Update()
    {

    }
}

