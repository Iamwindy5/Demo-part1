using UnityEngine;

public class MyHealth : MonoBehaviour
{
    public GameObject explosionPrefab; // Hiệu ứng nổ
    public int defaultHealth = 1;      // Máu mặc định (1 viên là chết)
    protected int currentHealth;       // Máu hiện tại

    // Start này là virtual để con cái có thể sửa đổi nếu cần
    protected virtual void Start()
    {
        currentHealth = defaultHealth;
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0) return;

        currentHealth -= damage; // Trừ máu

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Hàm Die có thể được con cái viết lại (override)
    protected virtual void Die()
    {
        // Tạo hiệu ứng nổ
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }

        // Tự hủy
        Destroy(gameObject);
    }
}