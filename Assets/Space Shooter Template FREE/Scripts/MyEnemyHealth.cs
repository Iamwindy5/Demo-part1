using UnityEngine;

public class MyEnemyHealth : MonoBehaviour
{
    // [MỚI] Biến để chứa hiệu ứng nổ
    public GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    void Die()
    {
        // [MỚI] Nếu có gán hiệu ứng nổ thì tạo nó ra
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }

        Destroy(gameObject);
    }
}