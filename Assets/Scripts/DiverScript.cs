using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiverScript : MonoBehaviour
{
    ObjectManager script;
    PlayerTurns turnScript;
    Positions posScript;
    ShoreUp shoreScript;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        posScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
        shoreScript = GameObject.Find("GameCanvas").GetComponent<ShoreUp>();
    }

    public void Diver()
    {
        for (int j = 0; j < script.TilesInstances.Count; j++)
        {
            if (posScript.blackToken.transform.position == posScript.grid[0,2] || posScript.blackToken.transform.position == posScript.grid[1, 1] || posScript.blackToken.transform.position == posScript.grid[2, 0])
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0);
                }
                posScript.Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                posScript.Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
            }
            else if (posScript.blackToken.transform.position == posScript.grid[0, 3] || posScript.blackToken.transform.position == posScript.grid[1, 4] || posScript.blackToken.transform.position == posScript.grid[2, 5])
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0);
                }
                posScript.Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                posScript.Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
            }
            else if (posScript.blackToken.transform.position == posScript.grid[3, 0] || posScript.blackToken.transform.position == posScript.grid[4, 1] || posScript.blackToken.transform.position == posScript.grid[5, 2])
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0);
                }
                posScript.Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                posScript.Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
            }
            else if (posScript.blackToken.transform.position == posScript.grid[3, 5] || posScript.blackToken.transform.position == posScript.grid[4, 4] || posScript.blackToken.transform.position == posScript.grid[5, 3])
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0);
                }
                posScript.Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                posScript.Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
            }
            else
            {
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[0].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(1.4f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0))
                {
                    posScript.Indicator[1].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(1.4f, 0, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[2].IndicatorObject.transform.position = posScript.blackToken.transform.position + new Vector3(0, 1.4f, 0);
                }
                if (script.TilesInstances[j].Tile.transform.position == posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0))
                {
                    posScript.Indicator[3].IndicatorObject.transform.position = posScript.blackToken.transform.position - new Vector3(0, 1.4f, 0);
                }
            }
        }
    }
}
