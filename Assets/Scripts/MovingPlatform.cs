using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Player attached to the moving platform!");
            player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Player detached from the moving platform!");
            player.transform.parent = null;
        }
    }
}
