using UnityEngine;

public class SwitchTrigger : MonoBehaviour
{

    public LevelManager levelManager;

    public GameObject levelToActivate;
    public Transform spawnLocation;

    private void Start()
    {
        levelManager = ServiceHub.Instance.levelManager;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered the switch trigger area.");
            levelManager.LevelChange(levelToActivate, spawnLocation);
        }
    }
}
