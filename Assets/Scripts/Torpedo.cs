using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Torpedo : MonoBehaviour
{
    [SerializeField] private Bullet bulletPref;
    [SerializeField] private GameObject bulletSpawner;
    private Rigidbody2D torpedoRB;
    Bullet bul;
    [SerializeField] public int bulletCount = 6;

    public Text bulletCountTorp;

    public void Start()
    {
        bulletCountTorp.text = "" + bulletCount;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (bulletCount > 0)
        {
            Bullet bullet = Instantiate(bulletPref, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
            FindObjectOfType<MoveBullet>();
            //bullet.Project(transform.up);
            bulletCount -= 1;
            bulletCountTorp.text = "" + bulletCount;
            if (bulletCount <= 0)
            {
                FindObjectOfType<GameManager>().GameOver();
            }
        }
    }
}
