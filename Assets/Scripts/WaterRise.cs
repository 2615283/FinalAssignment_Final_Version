using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaterRise : MonoBehaviour
{
    public TextMeshProUGUI WaterLevel;
    public TextMeshProUGUI DrawCards;

    public int WaterLevelInt = 1;
    public int DrawCardsInt = 3;

    private void Start()
    {
        
    }

    private void Update()
    {
        WaterLevel.text = "" + WaterLevelInt;
        DrawCards.text = "" + DrawCardsInt;
    }
}
