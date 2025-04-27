using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    public int stageIndex;

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        GameManager.Instance.selectedStageIndex = stageIndex;
        SceneManager.LoadScene("GameScene");
    }
}
