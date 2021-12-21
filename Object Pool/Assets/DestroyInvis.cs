using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyInvis : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        //Destroy(this.gameObject);
        this.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.CompareTag("asteroid") && collision.gameObject.CompareTag("Player"))
        {
            GameObject player = collision.gameObject;
            player.GetComponent<Drive>().healthbar.value -= 10;
            if (player.GetComponent<Drive>().healthbar.value <= 0)
            {
                Destroy(player.GetComponent<Drive>().healthbar, 0.1f);
                Destroy(player, 0.1f);
            }
        }
    }
}
