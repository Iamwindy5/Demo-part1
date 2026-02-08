using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBullet : MonoBehaviour
{
    public float flySpeed;
    public int damage = 1;
    void Update()
    { 
        Vector3 newPosition = transform.position;
        newPosition.y += flySpeed * Time.deltaTime;
        transform.position = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem cái va phải có máu không (MyEnemyHealth)
        var enemy = collision.GetComponent<MyEnemyHealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage); // Trừ máu nó
            Destroy(gameObject);      // Đạn biến mất
        }
    }
}

