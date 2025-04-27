using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public static StageManager Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public List<string[]> stages = new List<string[]>
    {
        new string[] { "ESE",
                       "SLS",
                       "ESE" },

        new string[] { "ESE",
                       "SLL",
                       "ELS" },

        new string[] { "ESLE",
                       "SELS",
                       "LSLS",
                       "ELSE" },

        new string[] { "ESLE",
                       "SLLS",
                       "LSLS",
                       "ESLE" },

        new string[] { "EESLEE",
                       "SLLLSE",
                       "LLSLLL",
                       "SLLLSE",
                       "EESLEE",
                       "EEEEEE" },

        new string[] { "EESLEE",
                       "SLLLSE",
                       "LLSLLL",
                       "SLLLSE",
                       "EESLEE",
                       "EEEEEE" },

        new string[] { "EESLSEE",
                       "SLLLLSE",
                       "LLLSLLL",
                       "SLLLLSE",
                       "EESLSEE",
                       "EEEEEEE",
                       "EEEEEEE" },

        new string[] { "ESLELSE",
                       "SLLLSLL",
                       "LLLSLLL",
                       "SLLLSLL",
                       "ESLELSE" },

        new string[] { "ELELELE",
                       "LSLSLSL",
                       "ELELELE",
                       "LSLSLSL",
                       "ELELELE",
                       "LSLSLSL",
                       "ELELELE" },

        new string[] { "ESLELSE",
                       "SLLLLLS",
                       "LLSLSLL",
                       "SLLLLLS",
                       "ESLELSE" },

        new string[] { "EESLSEE",
                       "SLLLLLS",
                       "LLSLLSL",
                       "SLLLLLS",
                       "EESLSEE",
                       "EEEEEEE" },

        new string[] { "EESLSEE",
                       "SLLLLLS",
                       "LLSLSLL",
                       "SLLLLLS",
                       "EESLSEE",
                       "EEEEEEE" },

        new string[] { "ELELELE",
                       "LSLSLSL",
                       "ELELELE",
                       "LSLSLSL",
                       "ELELELE",
                       "LSLSLSL",
                       "ELELELE" },

        new string[] { "EESLSEE",
                       "SLLLSLL",
                       "LSLLLSL",
                       "SLLLSLL",
                       "EESLSEE",
                       "EEEEEEE" },

        new string[] { "ELEELEE",
                       "LSLLSLL",
                       "SLLLLLS",
                       "SLLLLLS",
                       "LSLLSLL",
                       "ELEELEE" },

        new string[] { "ELEELEE",
                       "LSLLSLL",
                       "SLLLLLS",
                       "SLLLLLS",
                       "LSLLSLL",
                       "ELEELEE" },

        new string[] { "EESLSEE",
                       "SLLLLLS",
                       "LLSLSLL",
                       "SLLLLLS",
                       "EESLSEE",
                       "EEEEEEE" },

        new string[] { "EESLSEE",
                       "SLLLLLS",
                       "LLLSLLL",
                       "SLLLLLS",
                       "EESLSEE",
                       "EEEEEEE" },

        new string[] { "ELELELE",
                       "LSLSLSL",
                       "ELELELE",
                       "LSLSLSL",
                       "ELELELE",
                       "LSLSLSL",
                       "ELELELE" },

        new string[] { "ELEELEE",
                       "LSLLSLL",
                       "SLLLLLS",
                       "SLLLLLS",
                       "LSLLSLL",
                       "ELEELEE" }
    };

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}