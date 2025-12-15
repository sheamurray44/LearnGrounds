using UnityEngine;
/*
 Attach to player to handle its health and death
 */

public class PlayerCombat : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public GameObject gameOverUI;
    public Camera cam;

    void Start()
    {
        gameOverUI.SetActive(false);
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (currentHealth <= 0f)
        {
            PlayerDie();
        } 
    }

    private void PlayerDie()
    {
        cam.transform.parent = null; // Remove camera from player just to prevent errors
        gameObject.SetActive(false); // Disabling the object instead of destroying will prevent errors
        gameOverUI.SetActive(true);
    }
}
