using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawFloodCard : MonoBehaviour
{
    ObjectManager script;
    PlayerTurns turnScript;
    WaterRise riseScript;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        riseScript = GameObject.Find("GameCanvas").GetComponent<WaterRise>();
    }

    public void DrawFloodCards()
    {
        // Adds the flood cards back into the pile when they run out, or in other words when they less
        // than the amount that needs to be drawn at the end of a turn.
        if (script.FloodCards.Count <= riseScript.DrawCardsInt)
        {
            for (int i = 0; i < script.FloodCardsDiscard.Count; i++)
            {
                script.FloodCards.Add(script.FloodCardsDiscard[i]);
                script.FloodCardsDiscard.Remove(script.FloodCardsDiscard[i]);
            }
        }

        // This is the cards that are drawn at the end of each turn. A random one is chosen out of the deck,
        // it's clolour is changed and it is removed from the floodcards list and added to the discard pile.
        for (int i = 0; i < riseScript.DrawCardsInt; i++)
        {
            GameObject Tile = script.FloodCards[Random.Range(0, script.FloodCards.Count)];
            Tile.GetComponent<Image>().color = Color.cyan;
            script.FloodCards.Remove(Tile);
            script.FloodCardsDiscard.Add(Tile);

            // The following determines whether the tile needs to be sunk or not.
            if (script.Flooded.Contains(Tile))
            {
                script.Sunk.Add(Tile);
                script.Flooded.Remove(Tile);

                Tile.transform.position = new Vector3(-20, 0, 0);
            }
            else
            {
                script.Flooded.Add(Tile);
            }
        }

        // Changes the state of the tile to flooded
        for (int i = 0; i < script.TilesInstances.Count; i++)
        {
            if (script.TilesInstances[i].Tile.GetComponent<Image>().color == Color.cyan)
            {
                script.TilesInstances[i].Flooded = true;
            }
        }
    }

    // The following two functions just disables the buttons when they are pressed
    public void FloodCardsButtP1()
    {
        turnScript.DrawFloodP1.SetActive(false);
    }

    public void FloodCardsButtP2()
    {
        turnScript.DrawFloodP2.SetActive(false);
    }
}
