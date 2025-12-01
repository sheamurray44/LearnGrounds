using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfItems {  get; private set; }
    public UnityEvent<PlayerInventory> OnItemsCollected;

    public void ItemsCollected()
    {
        NumberOfItems++;
        OnItemsCollected.Invoke(this);
        Debug.Log("You collected an item!");
    }
}
