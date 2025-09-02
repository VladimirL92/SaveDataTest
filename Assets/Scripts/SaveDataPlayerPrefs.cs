using System;
using UnityEngine;

public class SaveDataPlayerPrefs : MonoBehaviour
{
    public Player Player;

    public void SaveNeeds()
    {
        var needs = Player.PlayerNeeds;
        PlayerPrefs.SetInt("Energy", needs.Energy);
        PlayerPrefs.SetInt("Hunger", needs.Hunger);
        PlayerPrefs.SetInt("Happiness", needs.Happiness);
        PlayerPrefs.Save();
    }

    public void LoadNeeds()
    {
        var loadedNeeds = new PlayerNeeds();
        loadedNeeds.Energy = PlayerPrefs.GetInt("Energy",1);
        loadedNeeds.Happiness = PlayerPrefs.GetInt("Happiness",1);
        loadedNeeds.Hunger = PlayerPrefs.GetInt("Hunger",1);
        Player.WritePlayerNeeds(loadedNeeds);
    }
}
