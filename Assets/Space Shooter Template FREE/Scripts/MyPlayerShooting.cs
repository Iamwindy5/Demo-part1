using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class MyPlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval;
    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPrefab, transform.position + new Vector3(0, 1f, 0), transform.rotation);
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);

        // [MỚI] Lấy component âm thanh và phát
        GetComponent<AudioSource>().Play();
    }
}