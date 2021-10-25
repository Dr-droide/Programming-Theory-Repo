using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int wave = 0;
    public TextMeshProUGUI waveText;
    public TextMeshProUGUI enemyText;


    void Start()
    {
        Instance = this;
    }

    private void Update() {
        Display();
    }

    void Display()
    {
        waveText.text = string.Format("Wave : {0}", wave);
        enemyText.text = string.Format("Enemy remining : {0}", FindObjectsOfType<Enemy>().Length);
    }

}
