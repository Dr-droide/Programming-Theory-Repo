using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed { get; set;}
    public float lifeTime { get; set;}
    public int damage { get; set;}
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(ArrowLife());
    }

    IEnumerator ArrowLife(){
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
    void Update()
    {
        Move();
    }

    void Move(){
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
}
