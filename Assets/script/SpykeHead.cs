using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpykeHead : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damaged");
            collision.transform.GetComponent<Respawn>().PlayerDamaged();
        }
    }



}
