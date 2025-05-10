using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 20f;
    public float speed = 30f;

    private void Start()
    {
        // Уничтожаем пулю через определенное время, если не столкнется с чем-либо
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        // Двигаем пулю вперед
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}