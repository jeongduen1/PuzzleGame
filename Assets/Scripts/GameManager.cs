using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    void Awake() => Instance = this;

    public void CheckClearCondition()
    {
        foreach (var tile in FindObjectsOfType<LightTile>())
        {
            if (!tile.isOn)
                return;
        }

        Debug.Log("Clear!");
    }
}
