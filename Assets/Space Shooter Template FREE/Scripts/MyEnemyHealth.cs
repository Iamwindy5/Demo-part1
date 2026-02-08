using UnityEngine;

public class MyEnemyHealth : MyHealth
{
    // Ghi đè hàm Die để báo log kiểm tra
    protected override void Die()
    {
        base.Die(); // Gọi hàm Die của cha (để nổ và biến mất)
        Debug.Log("Enemy died!"); // Log thêm dòng chữ
    }
}