using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveDataJson : MonoBehaviour
{
    public Player Player;
    public string FileName = "SaveData"; 

    private string _filePath;

    private void Start()
    {
        _filePath = Path.Combine(Application.persistentDataPath, FileName + ".txt");
    }

    public void SaveDate()
    {
        var textJson = JsonUtility.ToJson(Player.PlayerData);
        File.WriteAllText(_filePath,textJson);
    }

    public void LoadDate()
    {
        if (File.Exists(_filePath))
        {
            var textJson = File.ReadAllText(_filePath);
            var playerData = JsonUtility.FromJson<PlayerData>(textJson);
            Player.WritePlayerData(playerData);
        }
        else
        {
            Debug.Log("NotFile");
        }

    }
}
