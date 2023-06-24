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

    // This Start function disables all the panels and buttons that have to do with the helicopter lift card, at the start of the game
    private void Start()
    {
        HelicopterPanel1.SetActive(false);
        HelicopterPanel2.SetActive(false);

        HelicopterLift1.SetActive(false);
        HelicopterLift2.SetActive(false);

        
    }

    // This Update function tracks some of teh losing conditions.
    // It loads the scene that tells you that you have lost.
    private void Update()
    {
        // This is if the Fool's Landing Tile is sunk
        if (script.Sunk.Contains(script.TilesInstances[12].Tile))
        {
            SceneManager.LoadScene(2);
        }

        //The rest is if both of the tiles where you could get one of the treasures is sunk

        if (script.Sunk.Contains(script.TilesInstances[7].Tile) && script.Sunk.Contains(script.TilesInstances[23].Tile))
        {
            SceneManager.LoadScene(2);
        }

        if (script.Sunk.Contains(script.TilesInstances[11].Tile) && script.Sunk.Contains(script.TilesInstances[22].Tile))
        {
            SceneManager.LoadScene(2);
        }

        if (script.Sunk.Contains(script.TilesInstances[2].Tile) && script.Sunk.Contains(script.TilesInstances[19].Tile))
        {
            SceneManager.LoadScene(2);
        }

        if (script.Sunk.Contains(script.TilesInstances[3].Tile) && script.Sunk.Contains(script.TilesInstances[8].Tile))
        {
            SceneManager.LoadScene(2);
        }
    }

    // Enables the correct panel when the Helicopter lift card is used
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

    // Indicates whether the tokens are on the Fool's Landing Tile
    public void OnHelicopterLift()
    {
        if (turnsScript.Player1Turn == true)
        {
            for (int i = 0; i < script.TilesInstances.Count; i++)
            {
                // These if statements check whether the position of the token and the Tile is the same and that the Tile is in fact 
                // the Fool's landing tile. Here is some Crazy Code: Light Mode :/
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

    // This is put on the button you press to Lift said Helicopter when you want to finish the game
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
                        // Determines whether both the players are on the Fool's landing tile and that the captured treasure list contains
                        // all the treasures
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

    // Move button for the Helicopter Lift action where you can take the tokens anywhere on the board. There is one for Player 1 and one for 
    // Player 2, cause when I put it in one function, it hated me :,)
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
                        pilotScript.PilotMove();
                        turnsScript.Player2Turn = true;
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
                        pilotScript.PilotMove();
                        turnsScript.Player1Turn = true;
                    }
                }
            }
        }
    }

    // Had the same issue with the done button. This just reverts everything's state back to what it was before you used the Helicopter Lift
    // card (in the UI bit I mean)
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
