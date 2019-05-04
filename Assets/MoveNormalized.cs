using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNormalized : MonoBehaviour
{


    public float speed;
    public int points;

    public void Update()
    {
        var pos = Vector3.zero; // ou new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            pos.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x = 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            pos.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y = -1;
        }
        transform.position += pos.normalized * speed * Time.deltaTime;
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
