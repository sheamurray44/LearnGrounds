using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Scene reloaded!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
