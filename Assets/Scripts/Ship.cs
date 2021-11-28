using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private float speed;
    private float maxLifetime = 20.0f;
    public GameObject particle;
    GameManager gm;

    private void Update()
    {
        MoveShip();
    }

    void MoveShip()
    {
        if (PlayerPrefs.GetString("PointShip") == "LVL1")
        {
            transform.Translate(speed  * Time.deltaTime, 0, 0);
        }
        if (PlayerPrefs.GetString("PointShip") == "LVL2")
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (PlayerPrefs.GetString("PointShip") == "LVL3")//сейчас не двигается в обе стороны + Скорость х2
        {
           transform.Translate(speed * 2 * Time.deltaTime, 0, 0);
        }
        Destroy(gameObject, maxLifetime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            FindObjectOfType<GameManager>().AddPoint();
            //FindObjectOfType<GameManager>().GameWin();
            Destroy(gameObject);
            GameObject particleOn = Instantiate(particle, gameObject.transform.position, Quaternion.identity);
            Destroy(particleOn,5);
        }
    }
}
