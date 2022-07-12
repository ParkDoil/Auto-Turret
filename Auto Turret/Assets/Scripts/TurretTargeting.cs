using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTargeting : MonoBehaviour
{
    public bool isLockOn { get; private set; }
    public GameObject Target { get; private set; }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            isLockOn = true;
            Target = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isLockOn = false;
            Target = null;
        }
    }
}
