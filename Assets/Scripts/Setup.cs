using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setup : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    public GameObject SetUp;

    public GameObject Player1Actions;
    public GameObject Player2Actions;

    public GameObject boardButton;
    public GameObject playerButton;
    public GameObject adventurerButton;
    public GameObject treasureCardsButton;
    public GameObject floodInitialButton;

    public GameObject Begin;

    ObjectManager script;
    Positions positionScript;
    TokenMovement movementScript;
    PlayerTurns turnsScript;
    TreasureCardDiscard discardScript;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        positionScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
        turnsScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        discardScript = GameObject.Find("GameCanvas").GetComponent<TreasureCardDiscard>();
    }

    private void Start()
    {
        SetUp.SetActive(true);

        Player1.SetActive(false);
        Player2.SetActive(false);

        Player1Actions.SetActive(false);
        Player2Actions.SetActive(false);

        adventurerButton.SetActive(false);
        treasureCardsButton.SetActive(false);
        floodInitialButton.SetActive(false);
        Begin.SetActive(false);

        playerButton.SetActive(false);
    }

    public void BoardButton()
    {
        boardButton.SetActive(false);
        playerButton.SetActive(true);
    }

    public void PlayerButton()
    {
        Player1.SetActive(true);
        Player2.SetActive(true);
        playerButton.SetActive(false);
        adventurerButton.SetActive(true);
        treasureCardsButton.SetActive(true);
        floodInitialButton.SetActive(true);

        discardScript.DiscardPanelP1.SetActive(false);
        discardScript.DiscardPanelP2.SetActive(false);
    }

    public void AdventurerButton()
    {
        adventurerButton.SetActive(false);
    }

    public void TreasureCardButton()
    {
        treasureCardsButton.SetActive(false);

        for (int i = 0; i < script.WaterRiseInstances.Count; i++)
        {
            script.TreasureCardInstances.Add(script.WaterRiseInstances[i]);           
        }

        for (int i = 0; i < script.WaterRiseObjects.Count; i++)
        {
            script.TreasureCardsObjects.Add(script.WaterRiseObjects[i]);
        }
    }

    public void FloodInitialButton()
    {
        floodInitialButton.SetActive(false);

        for (int i = 0; i < 6; i++)
        {
            GameObject Tile = script.FloodCards[Random.Range(0, script.FloodCards.Count)];
            Tile.GetComponent<Image>().color = Color.cyan;
            script.FloodCards.Remove(Tile);
            script.FloodCardsDiscard.Add(Tile);
            script.Flooded.Add(Tile);
        }

        for (int i = 0; i < script.TilesInstances.Count; i++)
        {
            if (script.TilesInstances[i].Tile.GetComponent<Image>().color == Color.cyan)
            {
                script.TilesInstances[i].Flooded = true;
            }
        }

        Begin.SetActive(true);
    }

    public void BeginButton()
    {
        SetUp.SetActive(false);
        Player2.SetActive(false);
        positionScript.SecondTitle.SetActive(false);
        Player1Actions.SetActive(true);
        turnsScript.Player1Turn = true;
    }
}
