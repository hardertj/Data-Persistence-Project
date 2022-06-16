using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEngine;
#endif

public class MainMenuManager : MonoBehaviour
{
    public string playerName;

    public TextMeshProUGUI ScoreText;

    public int score = 0; 


    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

    public void PopulateTestBestScore()
    {
        ScoreText.text = $"Best Score : {DataManager.Instance.playerName} : {score}";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
