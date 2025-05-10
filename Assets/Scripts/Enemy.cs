using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    private AudioSource audioSource;
    public AudioClip hitSound;
    private void Start()
    {
        currentHealth = maxHealth;
        audioSource = GetComponent<AudioSource>();
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (hitSound != null && audioSource != null && !audioSource.isPlaying)
        {
            audioSource.PlayOneShot(hitSound);
        }
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
            Destroy(other.gameObject);
        }
    }
}