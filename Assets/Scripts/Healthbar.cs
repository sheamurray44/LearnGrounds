using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Image playerHealthBar;

    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        playerHealthBar.fillAmount = currentHealth / maxHealth;
    }
}
