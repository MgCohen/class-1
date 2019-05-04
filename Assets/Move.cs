using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    public int points;


    public void Update()
    {
        var pos = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            pos.y -= Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y += Time.deltaTime * speed;
        }
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var circle = collision.GetComponent<CircleCollider2D>();
        if (circle)
        {
            Destroy(circle.gameObject);
            points += 1;
            Debug.Log(points);
        }
    }
}
