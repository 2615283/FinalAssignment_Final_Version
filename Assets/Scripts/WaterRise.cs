using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WaterRise : MonoBehaviour
{
    public TextMeshProUGUI WaterLevel;
    public TextMeshProUGUI DrawCards;

    public GameObject WaterRise1;
    public GameObject WaterRise2;
    public GameObject WaterRise3;

    public int WaterLevelInt = 1;
    public int DrawCardsInt = 2;

    ObjectManager script;
    PlayerTurns turnScript;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        // Meter Text
        WaterLevel.text = "" + WaterLevelInt;
        DrawCards.text = "" + DrawCardsInt;

        // Water Level from level 2 to 10. If it goes up, it adds the flood cards in the discard list back to the card list
        // At level Ten it takes the player to the Lose Scene
        if (WaterLevelInt == 2)
        {
            for (int i = 0; i < script.FloodCardsDiscard.Count; i++)
            {
                script.FloodCards.Add(script.FloodCardsDiscard[i]);
                script.FloodCardsDiscard.Remove(script.FloodCardsDiscard[i]);                
            }
        }
        else if (WaterLevelInt == 3)
        {
            for (int i = 0; i < script.FloodCardsDiscard.Count; i++)
            {
                script.FloodCards.Add(script.FloodCardsDiscard[i]);
                script.FloodCardsDiscard.Remove(script.FloodCardsDiscard[i]);
            }
        }
        else if (WaterLevelInt == 4)
        {
            for (int i = 0; i < script.FloodCardsDiscard.Count; i++)
            {
                script.FloodCards.Add(script.FloodCardsDiscard[i]);
                script.FloodCardsDiscard.Remove(script.FloodCardsDiscard[i]);
            }
        }
        else if (WaterLevelInt == 5)
        {
            for (int i = 0; i < script.FloodCardsDiscard.Count; i++)
            {
                script.FloodCards.Add(script.FloodCardsDiscard[i]);
                script.FloodCardsDiscard.Remove(script.FloodCardsDiscard[i]);
            }
        }
        else if (WaterLevelInt == 6)
        {
            for (int i = 0; i < script.FloodCardsDiscard.Count; i++)
            {
                script.FloodCards.Add(script.FloodCardsDiscard[i]);
                script.FloodCardsDiscard.Remove(script.FloodCardsDiscard[i]);
            }
        }
        else if (WaterLevelInt == 7)
        {
            for (int i = 0; i < script.FloodCardsDiscard.Count; i++)
            {
                script.FloodCards.Add(script.FloodCardsDiscard[i]);
                script.FloodCardsDiscard.Remove(script.FloodCardsDiscard[i]);
            }
        }
        else if (WaterLevelInt == 8)
        {
            for (int i = 0; i < script.FloodCardsDiscard.Count; i++)
            {
                script.FloodCards.Add(script.FloodCardsDiscard[i]);
                script.FloodCardsDiscard.Remove(script.FloodCardsDiscard[i]);
            }
        }
        else if (WaterLevelInt == 9)
        {
            for (int i = 0; i < script.FloodCardsDiscard.Count; i++)
            {
                script.FloodCards.Add(script.FloodCardsDiscard[i]);
                script.FloodCardsDiscard.Remove(script.FloodCardsDiscard[i]);
            }
        }
        else if (WaterLevelInt == 10)
        {
            SceneManager.LoadScene(2);
        }
        
        // This tracks if a Water Rise card goes into aplayer hand. if it does, it gets removed and the Water level gets increased by 1
        if (turnScript.Player1Turn == true)
        {
            if (script.Player1TreasureCards.Contains(WaterRise1))
            {
                script.Player1TreasureCards.Remove(WaterRise1);
                script.TreasureCardsDiscard.Add(WaterRise1);
                WaterRise1.transform.position = new Vector3(20, 0, 0);
                script.Player1TreasureCards[script.Player1TreasureCards.Count - 1].transform.position = script.Player1TreasureCardsSpaces[script.Player1TreasureCards.Count - 1].transform.position;

                WaterLevelInt += 1;
            }
            else if (script.Player1TreasureCards.Contains(WaterRise2))
            {
                script.Player1TreasureCards.Remove(WaterRise2);
                script.TreasureCardsDiscard.Add(WaterRise2);
                WaterRise2.transform.position = new Vector3(20, 0, 0);
                script.Player1TreasureCards[script.Player1TreasureCards.Count - 1].transform.position = script.Player1TreasureCardsSpaces[script.Player1TreasureCards.Count - 1].transform.position;

                WaterLevelInt += 1;
            }
            else if (script.Player1TreasureCards.Contains(WaterRise3))
            {
                script.Player1TreasureCards.Remove(WaterRise3);
                script.TreasureCardsDiscard.Add(WaterRise3);
                WaterRise3.transform.position = new Vector3(20, 0, 0);
                script.Player1TreasureCards[script.Player1TreasureCards.Count - 1].transform.position = script.Player1TreasureCardsSpaces[script.Player1TreasureCards.Count - 1].transform.position;

                WaterLevelInt += 1;
            }
        }
        else if (turnScript.Player2Turn == true)
        {
            if (script.Player2TreasureCards.Contains(WaterRise1))
            {
                script.Player2TreasureCards.Remove(WaterRise1);
                script.TreasureCardsDiscard.Add(WaterRise1);
                WaterRise1.transform.position = new Vector3(20, 0, 0);
                script.Player2TreasureCards[script.Player2TreasureCards.Count - 1].transform.position = script.Player2TreasureCardsSpaces[script.Player2TreasureCards.Count - 1].transform.position;

                WaterLevelInt += 1;
            }
            else if (script.Player2TreasureCards.Contains(WaterRise2))
            {
                script.Player2TreasureCards.Remove(WaterRise2);
                script.TreasureCardsDiscard.Add(WaterRise2);
                WaterRise2.transform.position = new Vector3(20, 0, 0);
                script.Player2TreasureCards[script.Player2TreasureCards.Count - 1].transform.position = script.Player2TreasureCardsSpaces[script.Player2TreasureCards.Count - 1].transform.position;

                WaterLevelInt += 1;
            }
            else if (script.Player2TreasureCards.Contains(WaterRise3))
            {
                script.Player2TreasureCards.Remove(WaterRise3);
                script.TreasureCardsDiscard.Add(WaterRise3);
                WaterRise3.transform.position = new Vector3(20, 0, 0);
                script.Player2TreasureCards[script.Player2TreasureCards.Count - 1].transform.position = script.Player2TreasureCardsSpaces[script.Player2TreasureCards.Count - 1].transform.position;

                WaterLevelInt += 1;
            }
        }

        // This indicates the amount of flood cards that are drawn at different levels.
        if (WaterLevelInt == 1 || WaterLevelInt == 2)
        {
            DrawCardsInt = 2;
        }
        else if (WaterLevelInt == 3 || WaterLevelInt == 4 || WaterLevelInt == 5)
        {
            DrawCardsInt = 3;
        }
        else if (WaterLevelInt == 6 || WaterLevelInt == 7)
        {
            DrawCardsInt = 4;
        }
        else if (WaterLevelInt == 8 || WaterLevelInt == 9)
        {
            DrawCardsInt = 5;
        }
    }
}
