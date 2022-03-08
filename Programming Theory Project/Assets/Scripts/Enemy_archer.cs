using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_archer : Enemy
{
    public Arrow arrow;
    public GameObject arrowSpawner;
    public Enemy_archer()
    {
        pv = 10;
        speed = 0f;
        rotationSpeed = 100f;
        damage = 2;
    }

    protected override void Start()
    {
        base.Start();
        InvokeRepeating("Shoot", 1, 2);
    }

    void Shoot()
    {
        if (!GameManager.Instance.gameOver && !GameManager.Instance.isPaused)
        {
            Instantiate(arrow, arrowSpawner.transform.position, transform.rotation);
        }
    }
}
