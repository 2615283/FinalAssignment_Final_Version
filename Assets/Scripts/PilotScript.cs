using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Pilot can move to any card on the board
public class PilotScript : MonoBehaviour
{
    ObjectManager script;
    PlayerTurns turnScript;
    Positions posScript;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        posScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
    }

    //Crazy Code alert. This puts the indicators that show you where to move and that you click to move on all the available Tiles on the board.
    public void PilotMove()
    {
        for (int i = 0; i < script.TilesInstances.Count; i++)
        {
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[0])
            {
                posScript.Indicator[0].IndicatorObject.transform.position = posScript.pos[0];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[1])
            {
                posScript.Indicator[1].IndicatorObject.transform.position = posScript.pos[1];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[2])
            {
                posScript.Indicator[2].IndicatorObject.transform.position = posScript.pos[2];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[3])
            {
                posScript.Indicator[3].IndicatorObject.transform.position = posScript.pos[3];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[4])
            {
                posScript.Indicator[4].IndicatorObject.transform.position = posScript.pos[4];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[5])
            {
                posScript.Indicator[5].IndicatorObject.transform.position = posScript.pos[5];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[6])
            {
                posScript.Indicator[6].IndicatorObject.transform.position = posScript.pos[6];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[7])
            {
                posScript.Indicator[7].IndicatorObject.transform.position = posScript.pos[7];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[8])
            {
                posScript.Indicator[8].IndicatorObject.transform.position = posScript.pos[8];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[9])
            {
                posScript.Indicator[9].IndicatorObject.transform.position = posScript.pos[9];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[10])
            {
                posScript.Indicator[10].IndicatorObject.transform.position = posScript.pos[10];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[11])
            {
                posScript.Indicator[11].IndicatorObject.transform.position = posScript.pos[11];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[12])
            {
                posScript.Indicator[12].IndicatorObject.transform.position = posScript.pos[12];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[13])
            {
                posScript.Indicator[13].IndicatorObject.transform.position = posScript.pos[13];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[14])
            {
                posScript.Indicator[14].IndicatorObject.transform.position = posScript.pos[14];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[15])
            {
                posScript.Indicator[15].IndicatorObject.transform.position = posScript.pos[15];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[16])
            {
                posScript.Indicator[16].IndicatorObject.transform.position = posScript.pos[16];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[17])
            {
                posScript.Indicator[17].IndicatorObject.transform.position = posScript.pos[17];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[18])
            {
                posScript.Indicator[18].IndicatorObject.transform.position = posScript.pos[18];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[19])
            {
                posScript.Indicator[19].IndicatorObject.transform.position = posScript.pos[19];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[20])
            {
                posScript.Indicator[20].IndicatorObject.transform.position = posScript.pos[20];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[21])
            {
                posScript.Indicator[21].IndicatorObject.transform.position = posScript.pos[21];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[22])
            {
                posScript.Indicator[22].IndicatorObject.transform.position = posScript.pos[22];
            }
            if (script.TilesInstances[i].Tile.transform.position == posScript.pos[23])
            {
                posScript.Indicator[23].IndicatorObject.transform.position = posScript.pos[23];
            }
        }
    }
}
