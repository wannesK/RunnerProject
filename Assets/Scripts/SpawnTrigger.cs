using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    private SpawnManager spawnManager;
    private void Start()
    {
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnManager.SpawnTriggerEntered();
        }
    }
}
