using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Regular : Enemy
{


    public Enemy_Regular(){
        pv = 10;
        speed = 8f;
        rotationSpeed = 100f;
        damage = 1;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<Player>().pv -= damage;
            Destroy(gameObject);
        }
    }
}
