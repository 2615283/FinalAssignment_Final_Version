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
        for (int i = 0; i < riseScript.DrawCardsInt; i++)
        {
            GameObject Tile = script.FloodCards[Random.Range(0, script.FloodCards.Count)];
            Tile.GetComponent<Image>().color = Color.cyan;
            script.FloodCards.Remove(Tile);
            script.FloodCardsDiscard.Add(Tile);

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

        for (int i = 0; i < script.TilesInstances.Count; i++)
        {
            if (script.TilesInstances[i].Tile.GetComponent<Image>().color == Color.cyan)
            {
                script.TilesInstances[i].Flooded = true;
            }
        }
    }

    public void FloodCardsButtP1()
    {
        turnScript.DrawFloodP1.SetActive(false);
    }

    public void FloodCardsButtP2()
    {
        turnScript.DrawFloodP2.SetActive(false);
    }
}
