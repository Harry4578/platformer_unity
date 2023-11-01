using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
    
{
    public float bulletSpeed = 3.0f;

   
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
