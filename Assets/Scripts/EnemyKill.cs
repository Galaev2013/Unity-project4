using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    public float maxHealth = 100f;
    public float damageToPlayer = 10f;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            float damage = other.GetComponent<Bullet>().damage;
            TakeDamage(damage);
            Destroy(other.gameObject); // Уничтожаем пулю
        }
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
   player.TakeDamage(damageToPlayer);
            }
        }
    }
}