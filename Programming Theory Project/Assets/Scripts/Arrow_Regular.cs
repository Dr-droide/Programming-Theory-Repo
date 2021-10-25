using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Regular : Arrow
{
    public Arrow_Regular(){
        speed = 15f;
        damage = 5;
        lifeTime = 2f;
    }


    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Enemy")){
            other.gameObject.GetComponent<Enemy>().pv -= damage;
            Destroy(gameObject);
        }
    }
}
