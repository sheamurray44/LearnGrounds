using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public GameObject gameOverUI;
    public Camera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverUI.SetActive(false);
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0f)
        {
            PlayerDie();
        } 
    }

    private void PlayerDie()
    {
        gameObject.SetActive(false);
        gameOverUI.SetActive(true);
        cam.transform.parent = null;
    }
}
