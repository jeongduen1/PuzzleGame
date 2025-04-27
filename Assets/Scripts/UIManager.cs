using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject GameClearScreen;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ShowGameClearScreen()
    {
        GameClearScreen.SetActive(true);
    }
    
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void GoToNextStage()
    {
        GameManager.Instance.selectedStageIndex += 1;
        SceneManager.LoadScene("GameScene");
    }
}
