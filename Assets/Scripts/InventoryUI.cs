using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI itemText;

    void Start()
    {
        itemText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateItemText(PlayerInventory playerInventory)
    {
        itemText.text = playerInventory.NumberOfItems.ToString();
    }

}
