using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu(){
        SceneManager.LoadScene(0);
    }
}