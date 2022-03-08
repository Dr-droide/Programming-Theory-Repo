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
        if (!GameManager.Instance.gameOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                LaunchArrow();
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                arrowTypeSelected = 0;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                arrowTypeSelected = 1;
            }
            transform.rotation = GameObject.Find("Player").transform.rotation;
        }
    }

    void LaunchArrow()
    {
        Instantiate(arrow[arrowTypeSelected], transform.position, transform.rotation);
    }
}
