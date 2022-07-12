using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    void Die()
    {
        gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Die();
        }
    }
}
