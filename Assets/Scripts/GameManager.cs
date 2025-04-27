using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int selectedStageIndex = 0;

    public float bgmVol = 1f;
    public float sfxVol = 1f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CheckClearCondition()
    {
        foreach (var tile in FindObjectsOfType<LightTile>())
        {
            if (!tile.isOn)
                return;
        }

        WinGame();
    }

    public void WinGame()
    {
        UIManager.Instance.ShowGameClearScreen();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
