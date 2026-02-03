using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval = 0.25f;
    public Vector3 bulletOffset;

    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            UpdateFiring();
        }
    }

    private void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        Instantiate(
            bulletPrefabs,
            transform.position + bulletOffset,
            transform.rotation
        );
    }
}
