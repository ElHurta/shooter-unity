using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletDmg;

    public void Start()
    {
        Destroy(gameObject, 5);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bot") || collision.collider.CompareTag("Player"))
        {
            Debug.Log("Hit");
            collision.gameObject.GetComponent<Life>().life -= bulletDmg;
        }
        Destroy(gameObject);
    }
}
