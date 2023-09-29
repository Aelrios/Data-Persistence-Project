using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PlayerNameInput;

    public void StartNew()
    {
        // Set name here
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        PlayerDataHandler.Instance.PlayerName = PlayerNameInput.text;
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
