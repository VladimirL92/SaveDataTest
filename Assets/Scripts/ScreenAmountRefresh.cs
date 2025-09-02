using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScreenAmountRefresh : MonoBehaviour
{
    public TextMeshProUGUI TextAmount;
    public Player Player;

    private int _lastAmount;
    private void Start()
    {
        _lastAmount = Player.PlayerData.Amount;
    }
    private void Update()
    {
        if (_lastAmount != Player.PlayerData.Amount)
        {
            TextAmount.text = Player.PlayerData.Amount.ToString();
            _lastAmount = Player.PlayerData.Amount;
        }
    }
}
