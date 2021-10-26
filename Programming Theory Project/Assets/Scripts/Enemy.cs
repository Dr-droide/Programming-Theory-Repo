using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int pv { get; set; }
    private int maxPv;
    public Slider healthBar;
    public float speed { get; set; }
    public float rotationSpeed { get; set; }
    public int damage { get; set; }

    protected virtual void Start()
    {
        maxPv = pv;

        healthBar.maxValue = maxPv;
    }

    private void Update()
    {

        healthBar.value = pv;
        if (!GameManager.Instance.gameOver)
        {
            Move();
        }

        if (pv <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        var player = GameObject.Find("Player");

        Vector3 target = (player.transform.position - transform.position).normalized;

        transform.Translate(target * speed * Time.deltaTime, Space.World);

        if (target != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(target, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
