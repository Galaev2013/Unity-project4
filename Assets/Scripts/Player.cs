using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Player took damage: " + damage);

        // Проверка, если здоровье игрока меньше или равно нулю
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player died!");
        // Здесь можно добавить логику для смерти игрока, например, перезапуск уровня или отображение экрана конца игры.
    }
}