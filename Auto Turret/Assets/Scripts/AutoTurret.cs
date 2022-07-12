using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTurret : MonoBehaviour
{
    Rigidbody _rigid;
    TurretTargeting Targeting;
    public Transform Player;
    public Transform FireLocation;
    public GameObject Bullet;


    private float FireTime = 0f;
    private float GetTime;

    Vector3 SpinVec = new Vector3(0f, 1f, 0f);
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
        Targeting = GetComponentInChildren<TurretTargeting>();
    }

    void Update()
    {
        if(false == Targeting.isLockOn)
        {
            transform.Rotate(SpinVec);
        }
        else
        {
            BulletFire();
        }
    }

    void BulletFire()
    {
        if(FireTime == 0f)
        {
            FireTime = Random.Range(0.7f, 1.4f);
        }

        transform.LookAt(Targeting.Target.transform);

        GetTime += Time.deltaTime;

        if(GetTime >= FireTime)
        {
            Instantiate(Bullet, FireLocation.position, FireLocation.rotation);
            GetTime = 0f;
            FireTime = 0f;
        }

    }
}
