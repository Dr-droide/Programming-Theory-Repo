using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Regular : Arrow
{
    public Arrow_Regular(){
        speed = 30f;
        damage = 5;
        lifeTime = 2f;
    }


    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Enemy")){
            other.gameObject.GetComponent<Enemy>().pv -= damage;
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<Player>().pv -= 2;
            Destroy(gameObject);
        }
    }
}
