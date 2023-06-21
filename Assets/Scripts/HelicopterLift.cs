using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelicopterLift : MonoBehaviour
{
    Treasures treasureScript;
    ObjectManager script;
    PlayerTurns turnsScript;
    Positions posScript;
    PilotScript pilotScript;

    public GameObject HelicopterPanel1;
    public GameObject HelicopterPanel2;

    public GameObject HelicopterLift1;
    public GameObject HelicopterLift2;

    public GameObject Move1;
    public GameObject Move2;

    private void Awake()
    {
        treasureScript = GameObject.Find("GameCanvas").GetComponent<Treasures>();
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnsScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        posScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
        pilotScript = GameObject.Find("GameCanvas").GetComponent<PilotScript>();
    }

    private void Start()
    {
        HelicopterPanel1.SetActive(false);
        HelicopterPanel2.SetActive(false);

        HelicopterLift1.SetActive(false);
        HelicopterLift2.SetActive(false);

        
    }

    private void Update()
    {
        
    }

    public void HelicopterPanel()
    {
        OnHelicopterLift();

        if (turnsScript.Player1Turn == true)
        {
            HelicopterPanel1.SetActive(true);
        }
        else if (turnsScript.Player2Turn == true)
        {
            HelicopterPanel2.SetActive(true);
        }
    }

    public void OnHelicopterLift()
    {
        if (turnsScript.Player1Turn == true)
        {
            for (int i = 0; i < script.TilesInstances.Count; i++)
            {
                if (posScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift1.SetActive(true);
                }
                else if (posScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift1.SetActive(true);
                }
                else if (posScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift1.SetActive(true);
                }
                else if (posScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift1.SetActive(true);
                }
                else if (posScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift1.SetActive(true);
                }
                else if (posScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift1.SetActive(true);
                }
            }
        }
        else if (turnsScript.Player2Turn == true)
        {
            for (int i = 0; i < script.TilesInstances.Count; i++)
            {
                if (posScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift2.SetActive(true);
                }
                else if (posScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift2.SetActive(true);
                }
                else if (posScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift2.SetActive(true);
                }
                else if (posScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift2.SetActive(true);
                }
                else if (posScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift2.SetActive(true);
                }
                else if (posScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                {
                    HelicopterLift2.SetActive(true);
                }
            }
        }
    }

    public void HelicopterLiftButt()
    {
        if (turnsScript.Player1Turn == true)
        {
            for (int k = 0; k < script.TilesInstances.Count; k++)
            {
                for (int j = 0; j < script.AdventurersInstances.Count; j++)
                {
                    for (int i = 0; i < script.AdventurersInstances.Count; i++)
                    {
                        if (script.AdventurersInstances[j].Player1 == true && script.AdventurersInstances[i].Player2 == true)
                        {
                            if (script.AdventurersInstances[j].Token.transform.position == script.TilesInstances[k].Tile.transform.position && script.AdventurersInstances[i].Token.transform.position == script.TilesInstances[k].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                            {
                                if (treasureScript.Capturedtreasures.Contains(treasureScript.EarthStone) && treasureScript.Capturedtreasures.Contains(treasureScript.OceansChalice) && treasureScript.Capturedtreasures.Contains(treasureScript.CrystalOfFire) && treasureScript.Capturedtreasures.Contains(treasureScript.StatueOfTheWind))
                                {
                                    SceneManager.LoadScene(1);
                                }
                            }
                        }
                    }
                }
            }                        
        }
        else if (turnsScript.Player2Turn == true)
        {
            for (int k = 0; k < script.TilesInstances.Count; k++)
            {
                for (int j = 0; j < script.AdventurersInstances.Count; j++)
                {
                    for (int i = 0; i < script.AdventurersInstances.Count; i++)
                    {
                        if (script.AdventurersInstances[j].Player1 == true && script.AdventurersInstances[i].Player2 == true)
                        {
                            if (script.AdventurersInstances[j].Token.transform.position == script.TilesInstances[k].Tile.transform.position && script.AdventurersInstances[i].Token.transform.position == script.TilesInstances[k].Tile.transform.position && script.TilesInstances[i].TileName == "Fool's Landing")
                            {
                                if (treasureScript.Capturedtreasures.Contains(treasureScript.EarthStone) && treasureScript.Capturedtreasures.Contains(treasureScript.OceansChalice) && treasureScript.Capturedtreasures.Contains(treasureScript.CrystalOfFire) && treasureScript.Capturedtreasures.Contains(treasureScript.StatueOfTheWind))
                                {
                                    SceneManager.LoadScene(1);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public void MoveButt1()
    {
       pilotScript.PilotMove();

        Move1.SetActive(false);

        for (int i = 0; i < script.AdventurersInstances.Count; i++)
        {
            for (int j = 0; j < script.AdventurersInstances.Count; j++)
            {
                if (script.AdventurersInstances[i].Player1 == true && script.AdventurersInstances[j].Player2 == true)
                {
                    if (script.AdventurersInstances[i].Token.transform.position == script.AdventurersInstances[j].Token.transform.position)
                    {
                        turnsScript.Player2Turn = true;
                        pilotScript.PilotMove();
                    }
                }
            }
        }
    }

    public void MoveButt2()
    {
        pilotScript.PilotMove();

        Move2.SetActive(false);

        for (int i = 0; i < script.AdventurersInstances.Count; i++)
        {
            for (int j = 0; j < script.AdventurersInstances.Count; j++)
            {
                if (script.AdventurersInstances[i].Player1 == true && script.AdventurersInstances[j].Player2 == true)
                {
                    if (script.AdventurersInstances[i].Token.transform.position == script.AdventurersInstances[j].Token.transform.position)
                    {
                        turnsScript.Player1Turn = true;
                        pilotScript.PilotMove();
                    }
                }
            }
        }
    }

    public void Done1()
    {
        turnsScript.Player2Turn = false;

        HelicopterLift1.SetActive(false);
        HelicopterPanel1.SetActive(false);

        Move1.SetActive(true);
    }

    public void Done2()
    {
        turnsScript.Player1Turn = false;

        HelicopterLift2.SetActive(false);
        HelicopterPanel2.SetActive(false);

        Move2.SetActive(true);
    }
}
