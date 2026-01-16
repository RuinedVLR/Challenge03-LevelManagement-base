using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject currentlvl;

    [SerializeField] private GameObject lvl1;
    [SerializeField] private GameObject lvl2;

    public void LevelChange()
    {
        lvl1.SetActive(false);
        lvl2.SetActive(true);
    }
}
