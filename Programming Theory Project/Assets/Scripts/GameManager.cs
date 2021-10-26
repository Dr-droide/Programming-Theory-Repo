using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int wave = 0;
    public TextMeshProUGUI waveText;
    public TextMeshProUGUI enemyText;
    public Slider healthBar;
    public GameObject GameOverCanvas;
    public Player player;
    public bool gameOver = false;


    void Start()
    {
        Instance = this;
        healthBar.maxValue = player.maxPv;
    }

    private void Update() {
        Display();
        if (Input.GetKeyDown(KeyCode.B)){
            GameOver();
        }
    }

    void Display()
    {
        waveText.text = string.Format("Wave : {0}", wave);
        enemyText.text = string.Format("Enemies remaining : {0}", FindObjectsOfType<Enemy>().Length);
        healthBar.value = player.pv;
    }

    public void GameOver(){
        gameOver = true;
        GameOverCanvas.SetActive(true);
    }

}
