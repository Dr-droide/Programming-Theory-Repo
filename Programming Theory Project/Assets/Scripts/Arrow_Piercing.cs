using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Piercing : Arrow
{
    
    public Arrow_Piercing(){
        speed = 10f;
        damage = 5;
        lifeTime = 5f;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ennemy")){
            Physics.IgnoreCollision(other.gameObject.GetComponent<Collider>(), GetComponent<Collider>()); //The arrow passes through the target regardless of the Rigibody, to simulate the piercing effect.
            other.gameObject.GetComponent<Ennemy>().pv -= damage;
        }
    }
    
}
