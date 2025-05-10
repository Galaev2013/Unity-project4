using UnityEngine;
public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab; // Префаб патрона
    public Transform bulletSpawn; // Позиция, откуда будет происходить выстрел
    public float bulletSpeed = 20f; // Скорость пули
    void Update()
    {
        // Проверяем нажатие левой кнопки мыши для стрельбы
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        // Создание экземпляра пули
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        
        // Установка скорости пули
        rb.velocity = bulletSpawn.forward * bulletSpeed;
    }
}