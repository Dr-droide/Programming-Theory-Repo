using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public int pv { get; set;}


    private void Update() {
        if (pv <= 0){
            Destroy(gameObject);
        }
    }
}
