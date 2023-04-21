using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{
    private bool isActivated = false;
    public GameObject wallPrefab;
    public Transform wallSpawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            isActivated = true;

            if (wallPrefab != null && wallSpawnPoint != null)
            {
                Instantiate(wallPrefab, wallSpawnPoint.position, Quaternion.identity);
            }
        }
    }
}
