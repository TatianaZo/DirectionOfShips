using UnityEngine;



public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 500.0f;
    [SerializeField] private float maxLifetime = 10.0f; //время жизни пульки
    private Rigidbody2D bulletRB;


    private void Awake()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    }
   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ship")
        {
            //FindObjectOfType<GameManager>().AddPoint();
            Destroy(gameObject);
        }
    }
}
