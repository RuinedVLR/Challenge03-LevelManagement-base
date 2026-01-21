using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject currentlvl;

    [SerializeField] private GameObject lvl1;
    [SerializeField] private GameObject lvl2;
    GameObject current;

    [SerializeField] Transform player;

    private void Start()
    {
        current = lvl1;
    }

    public void LevelChange(GameObject targetLevel, Transform spawnPoint)
    {
        current.SetActive(false);
        targetLevel.SetActive(true);

        current = targetLevel;

        player.position = spawnPoint.position;
    }
}
