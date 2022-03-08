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
    public GameObject gameOverCanvas;
    public GameObject pauseCanvas;
    public Player player;
    public bool gameOver = false;
    public bool isPaused = false;

    private AudioSource audioSource;

    public AudioClip gameOverAudio;
    public AudioClip loopAudio;

    public float volume;


    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        healthBar.maxValue = player.maxPv;
        volume = 0.5f;
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = volume;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        Display();
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameOver();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseOn();
        }

        if (!audioSource.isPlaying && !gameOver && !isPaused)
        {
            audioSource.clip = loopAudio;
            audioSource.Play();
        }
    }

    void Display()
    {
        waveText.text = string.Format("Wave : {0}", wave);
        enemyText.text = string.Format("Enemies remaining : {0}", FindObjectsOfType<Enemy>().Length);
        healthBar.value = player.pv;
        audioSource.volume = volume;
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverCanvas.SetActive(true);
        audioSource.clip = gameOverAudio;
        audioSource.Play();
    }

    private void PauseOn()
    {
        isPaused = true;
        pauseCanvas.SetActive(true);
        audioSource.Pause();
    }

    public void PauseOff()
    {
        isPaused = false;
        pauseCanvas.SetActive(false);
        audioSource.Play();
    }

}
