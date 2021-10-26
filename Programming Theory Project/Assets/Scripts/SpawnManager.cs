using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public int enemyCount;


    private float xSpawn = 70;
    private float zSpawn = 70;


    private void LateUpdate()
    {

        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0 && !GameManager.Instance.gameOver)
        {
            GameManager.Instance.wave ++;
            if (GameManager.Instance.wave > 4){
                GameManager.Instance.wave = 1;
            }
            SpawnNewWave();
        }
    }

    private void SpawnNewWave()
    {
        switch (GameManager.Instance.wave)
        {
            case 1:
                SpawnEnemy(enemies[0]);
                SpawnEnemy(enemies[0]);
                SpawnEnemy(enemies[0]);
                break;
            case 2:
                for (int i = 0; i < 3; i++){
                    SpawnEnemy(enemies[0]);
                }
                SpawnEnemy(enemies[1]);
                SpawnEnemy(enemies[1]);
                break;
            case 3:
                for (int i = 0; i < 5; i++){
                    SpawnEnemy(enemies[0]);
                }
                SpawnEnemy(enemies[1]);
                SpawnEnemy(enemies[1]);
                SpawnEnemy(enemies[1]);
                break;
            case 4:
                for (int i = 0; i < 10; i++){
                    SpawnEnemy(enemies[1]);
                }
                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            case 9:

                break;
            case 10:

                break;
        }
    }

    private void SpawnEnemy(GameObject enemyToSpawn){
        float xPos = Random.Range( -xSpawn, xSpawn);
        float zPos = Random.Range( -zSpawn, zSpawn);
        Vector3 Pos = new Vector3 (xPos, 0.5f, zPos);

        Instantiate(enemyToSpawn, Pos, enemyToSpawn.transform.rotation);

    }

}
