using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int pv { get; set;}
    private int maxPv;
    public Slider healthBar;

    private void Start() {
        maxPv = pv;

        healthBar.maxValue = maxPv;
    }

    private void Update() {
        
        healthBar.value = pv;

        if (pv <= 0){
            Destroy(gameObject);
        }
    }
}
