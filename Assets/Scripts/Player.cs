using System;
using UnityEngine;

public class Player: MonoBehaviour
{
    public PlayerData PlayerData;
    public PlayerNeeds PlayerNeeds;

    public event Action PlayerNeedsLoaded;

    private void Start()
    {
        PlayerData = new PlayerData();
        PlayerNeeds = new PlayerNeeds();
    }

    public void WritePlayerData(PlayerData playerData)
    {
        PlayerData = playerData;
    }

    public void WritePlayerNeeds(PlayerNeeds playerNeeds)
    {
        PlayerNeeds = playerNeeds;
        PlayerNeedsLoaded.Invoke();
    }

    [ContextMenu("AddCoin")]
    public void AddCoin()
    {
        PlayerData.Amount++;
    }
}


