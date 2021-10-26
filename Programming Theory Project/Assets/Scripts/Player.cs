using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed { get; set; }
    private float rotateSpeed;
    public int pv = 10;
    public int maxPv = 10;


    public Rigidbody playerRb;

    void Start()
    {
        speed = 10f;
        rotateSpeed = 100f;
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!GameManager.Instance.gameOver)
        {
            Move();

            if (pv <= 0){
                GameManager.Instance.GameOver();
            }
        }
    }

    void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertival = Input.GetAxis("Vertical");
        var rotate = Input.GetAxis("Rotate");

        transform.Translate(new Vector3(horizontal, 0, vertival) * speed * Time.deltaTime);
        //playerRb.AddForce(new Vector3(horizontal, 0, vertival)* speed * Time.deltaTime);

        transform.Rotate(new Vector3(0, rotate, 0) * rotateSpeed * Time.deltaTime);
    }
}
