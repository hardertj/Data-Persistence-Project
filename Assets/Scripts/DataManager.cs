using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName;

    public int topScore = 0;

    private void Awake()
    {
        if( Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);

        if( playerName == null)
        {
            GetPlayerName();
        }
    }

    public void GetPlayerName()
    {
        playerName = GameObject.Find("InputFieldName").GetComponent<TMPro.TMP_InputField>().text;
        Debug.Log($"Player name is: {playerName}");
    }

    public void SetTopScore( int score)
    {
        topScore = score;
    }

}
