using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private float speed = 5.0f;
    private Vector2 target;
    private Vector2 position;
    private Camera cam;

    void Start()
    {
        target = new Vector2(0.0f, 0.0f);
        position = gameObject.transform.position;

        cam = Camera.main;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        // ƒвижение игрока в точку клика
        transform.position = Vector2.MoveTowards(transform.position, target, step);
        Destroy(gameObject, 1.5f);
    }
    void OnGUI()
    {
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();
        Vector2 point = new Vector2();

        // ѕозици€ тапа в мировом пространстве
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;
        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0.0f));

        if (Input.GetMouseButton(0))
        {
            // назначаем таргет в точку клика
            target = point;
        }
    }

   
}