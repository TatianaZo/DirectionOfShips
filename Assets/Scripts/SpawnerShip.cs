using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerShip : MonoBehaviour
{
    
    public GameObject enemy;
    private Vector3 randomPoint;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("MineNum"))
        {
            PlayerPrefs.SetInt("MineNum", UnityEngine.Random.Range(5, 6));
        }
        SpawnShip(PlayerPrefs.GetInt("MineNum"));
    }
    public void SpawnShip(int count)
    {
        if (PlayerPrefs.GetInt("MineNum") <= 13)
        {
            PlayerPrefs.SetInt("MineNum", PlayerPrefs.GetInt("MineNum") + UnityEngine.Random.Range(5, 9));
        }
        if (PlayerPrefs.GetInt("MineNum") >= 12)
        {
            PlayerPrefs.SetInt("MineNum", UnityEngine.Random.Range(5, 11));
        }
        
        for (int i = 0; i < count; i++)
        {
            if (PlayerPrefs.GetString("PointShip") == "LVL1")
            { 
                float spawnY = Random.Range(-2.5f, 4);
                float spawnX = Random.Range(-3, -6);
                Instantiate(this.enemy.gameObject, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
            }
            if (PlayerPrefs.GetString("PointShip") == "LVL2")
            {
                float spawnY = Random.Range(-2.5f, 4);
                float spawnX = Random.Range(3, 6);
                Instantiate(this.enemy.gameObject, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
            }

            if (PlayerPrefs.GetString("PointShip") == "LVL3")
            {
                float spawnYL = Random.Range(-2.5f, 4);
                float spawnXL = Random.Range(3, 6);
                Instantiate(this.enemy.gameObject, new Vector3(spawnXL, spawnYL, 0), Quaternion.identity);

                float spawnYR = Random.Range(-2.5f, 4);
                float spawnXR = Random.Range(-3, -6);
                Instantiate(this.enemy.gameObject, new Vector3(spawnXR, spawnYR, 0), Quaternion.identity);
            }
        }
    }

}
