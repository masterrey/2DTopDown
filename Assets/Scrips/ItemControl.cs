using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public int coins; // Number of coins collected
    public int health; // Health of the player
    public int maxHealth = 100; // Maximum health of the player

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collision = Physics2D.OverlapCircle(transform.position, 0.1f, 128);
        if (collision)
        {
            coins ++; // Increment coins when colliding with a coin item

            Destroy(collision.gameObject); // Destroy the coin item after collecting it
        }

    }
}
