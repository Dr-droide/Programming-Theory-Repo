using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public Arrow[] arrow;
    public int arrowTypeSelected = 0;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            LaunchArrow();
        }
    }

    void LaunchArrow(){
        Instantiate(arrow[arrowTypeSelected], transform.position, transform.rotation);
    }
}
