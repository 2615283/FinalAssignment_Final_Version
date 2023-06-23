using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This script sets up the UI for the Game
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

    // Enables and Disables the relevant objects at the beginning of the game
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

    // Takes Board Button away and adds Player Button
    public void BoardButton()
    {
        boardButton.SetActive(false);
        playerButton.SetActive(true);
    }

    //Enables objects or rather Buttons and panels for the players
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

    // Takes away Adventurer button
    public void AdventurerButton()
    {
        adventurerButton.SetActive(false);
    }

    // Takes away Treasure card button and adds the Water rise card stuff to the relevant lists
    public void TreasureCardButton()
    {
        treasureCardsButton.SetActive(false);

        for (int i = 0; i < script.WaterRiseInstances.Count; i++)
        {
            script.TreasureCardsObjects.Add(script.WaterRiseObjects[i]);
            script.TreasureCardInstances.Add(script.WaterRiseInstances[i]);
        }
    }

    // Floods the Initial 6 Tiles
    public void FloodInitialButton()
    {
        floodInitialButton.SetActive(false);

        // Chooses random Tile, change it's color to cyan, remove it from the Flood Cards and add it to the dircard pile as well as to the flooded pile
        for (int i = 0; i < 6; i++)
        {
            GameObject Tile = script.FloodCards[Random.Range(0, script.FloodCards.Count)];
            Tile.GetComponent<Image>().color = Color.cyan;
            script.FloodCards.Remove(Tile);
            script.FloodCardsDiscard.Add(Tile);
            script.Flooded.Add(Tile);
        }

        // Sets the Tile to flooded
        for (int i = 0; i < script.TilesInstances.Count; i++)
        {
            if (script.TilesInstances[i].Tile.GetComponent<Image>().color == Color.cyan)
            {
                script.TilesInstances[i].Flooded = true;
            }
        }

        Begin.SetActive(true);
    }

    // Disables Initial setup stuff and starts the game by enabling Player 1's stuff.
    public void BeginButton()
    {
        SetUp.SetActive(false);
        Player2.SetActive(false);
        positionScript.SecondTitle.SetActive(false);
        Player1Actions.SetActive(true);
        turnsScript.Player1Turn = true;
    }
}
