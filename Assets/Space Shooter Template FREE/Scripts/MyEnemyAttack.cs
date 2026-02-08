using UnityEngine;

public class MyEnemyAttack : MonoBehaviour
{
    public int damage = 1; // Sát thương khi húc vào người chơi

    // Cần tham chiếu đến máu của chính mình (để tự sát)
    private MyEnemyHealth myHealth;

    void Start()
    {
        myHealth = GetComponent<MyEnemyHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem húc phải Player không
        var playerHealth = collision.GetComponent<MyPlayerHealth>();

        if (playerHealth != null)
        {
            // 1. Gây sát thương cho Player
            playerHealth.TakeDamage(damage);

            // 2. Kẻ thù tự sát (trừ 1000 máu cho chết luôn)
            if (myHealth != null)
            {
                myHealth.TakeDamage(1000);
            }
        }
    }
}