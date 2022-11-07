using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] Transform target;

    private void Start()
    {
        target = FindObjectOfType<EnemyMover>().transform;
    }
    private void Update()
    {

        AimWeappon();


    }

    private void AimWeappon()
    {
        weapon.LookAt(target);
    }
}
