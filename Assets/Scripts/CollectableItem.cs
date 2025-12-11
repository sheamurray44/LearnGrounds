using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    /*
    The OnTriggerEnter method lets us have things happen
    when we have our player overlap with a trigger collider
    */
    private void OnTriggerEnter(Collider other)
    {
        /*
        Lets this script see the PlayerInventory script
        */
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        /*
        As long as the PlayerInventory script is attached to the player,
        the following code can be executed
        */
        if(playerInventory != null)
        {
            playerInventory.ItemsCollected();
            gameObject.SetActive(false);
        }
    }
}
