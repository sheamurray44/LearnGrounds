using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory != null)
        {
            playerInventory.ItemsCollected();
            gameObject.SetActive(false);
        }
    }
}
