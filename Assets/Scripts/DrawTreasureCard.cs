using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTreasureCard : MonoBehaviour
{
    ObjectManager script;
    PlayerTurns turnScript;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
    }

    // The initial treasure cards that are drawn at the beginning of the game
    public void DrawTreasureCards()
    {
        if (turnScript.Player1Turn == true)
        {
            // Removes the card from the card list and adds it to the player hand list, as well as determines where it should be placed in the
            // hand according to the spaces determined before hand
            GameObject Player1Card1 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
            script.Player1TreasureCards.Add(Player1Card1);
            script.TreasureCardsObjects.Remove(Player1Card1);
            script.Player1TreasureCards[script.Player1TreasureCards.Count - 1].transform.position = script.Player1TreasureCardsSpaces[script.Player1TreasureCards.Count - 1].transform.position;

            GameObject Player1Card2 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
            script.Player1TreasureCards.Add(Player1Card2);
            script.TreasureCardsObjects.Remove(Player1Card2);
            script.Player1TreasureCards[script.Player1TreasureCards.Count - 1].transform.position = script.Player1TreasureCardsSpaces[script.Player1TreasureCards.Count - 1].transform.position;
        }
        else if (turnScript.Player2Turn == true)
        {
            GameObject Player2Card1 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
            script.Player2TreasureCards.Add(Player2Card1);
            script.TreasureCardsObjects.Remove(Player2Card1);
            script.Player2TreasureCards[script.Player2TreasureCards.Count - 1].transform.position = script.Player2TreasureCardsSpaces[script.Player2TreasureCards.Count - 1].transform.position;

            GameObject Player2Card2 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
            script.Player2TreasureCards.Add(Player2Card2);
            script.TreasureCardsObjects.Remove(Player2Card2);
            script.Player2TreasureCards[script.Player2TreasureCards.Count - 1].transform.position = script.Player2TreasureCardsSpaces[script.Player2TreasureCards.Count - 1].transform.position;
        }

        DrawTreasureCardsButton();
    }


    // Makes the button go away when pressed
    public void DrawTreasureCardsButton()
    {
        if (turnScript.Player1Turn == true)
        {
            turnScript.DrawTreasureP1.SetActive(false);
        }
        else if (turnScript.Player2Turn == true)
        {
            turnScript.DrawTreasureP2.SetActive(false);
        }
    }
}
