using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    public bool playerInRange;
    public float attackDamage = 40f;
    [SerializeField] private PlayerCombat playerCombat;

    private void Awake()
    {
        playerInRange = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            DoDamage(attackDamage);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerInRange = false;
    }
    private void DoDamage(float damage)
    {
        if (playerInRange)
        {
           playerCombat.currentHealth -= damage;
           Debug.Log("Player damaged");
        }
    }
}
