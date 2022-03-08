using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    [SerializeField]
    private Slider volume;
    public static MainUI Instance;

    private void Start() {
         if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);   
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu(){
        SceneManager.LoadScene(0);
    }

    public void Pause(){
        GameManager.Instance.PauseOff();
    }

    public void VolumeChange(){
        GameManager.Instance.volume = volume.value;
    }
}
