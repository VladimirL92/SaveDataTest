using UnityEngine;
using UnityEngine.UI;

public class RefreshNeeds : MonoBehaviour
{
    public Player Player;
    public Slider SliderHappiness;
    public Slider SliderHunger;
    public Slider SliderEnergy;

    private void OnEnable()
    {
        Player.PlayerNeedsLoaded += RefreshPlayerNeedsToSliders;
    }

    private void OnDisable()
    {
        Player.PlayerNeedsLoaded -= RefreshPlayerNeedsToSliders;
    }
    private void Start()
    {
        RefreshSlidersToPlayerNeds();
    }
    public void RefreshSlidersToPlayerNeds()
    {
        Player.PlayerNeeds.Happiness = Mathf.RoundToInt(SliderHappiness.value);
        Player.PlayerNeeds.Energy =  Mathf.RoundToInt(SliderEnergy.value);
        Player.PlayerNeeds.Hunger = Mathf.RoundToInt(SliderHunger.value);
    }
    public void RefreshPlayerNeedsToSliders()
    {
        SliderEnergy.SetValueWithoutNotify(Player.PlayerNeeds.Energy);
        SliderHappiness.SetValueWithoutNotify(Player.PlayerNeeds.Happiness);
        SliderHunger.SetValueWithoutNotify(Player.PlayerNeeds.Hunger);
    }

}
