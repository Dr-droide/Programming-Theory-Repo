using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    void Move(){
        var horizontal = Input.GetAxis("Horizontal");
        var vertival = Input.GetAxis("Vertical");

        //transform.Translate(new Vector3(horizontal, 0, vertival) * speed * Time.deltaTime);
        playerRb.AddForce(new Vector3(horizontal, 0, vertival)* speed * Time.deltaTime);
    }
}
