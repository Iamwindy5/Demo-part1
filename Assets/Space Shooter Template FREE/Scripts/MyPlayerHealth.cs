using UnityEngine;

public class MyPlayerHealth : MyHealth
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("GAME OVER! Player died!");
        FindObjectOfType<MyGameController>().ShowGameOver();
    }
}