using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Treasures : MonoBehaviour
{
    public GameObject OceansChalice;
    public GameObject CrystalOfFire;
    public GameObject StatueOfTheWind;
    public GameObject EarthStone;

    public GameObject Continue1;
    public GameObject Continue2;

    public GameObject Capture1;
    public GameObject Capture2;

    public GameObject InitialCaptureTreasurePanelP1;
    public GameObject InitialCaptureTreasurePanelP2;

    public TextMeshProUGUI CapTTxt1;
    public TextMeshProUGUI CapTTxt2;

    public int EarthStones;
    public int FireCrystal;
    public int WindStatue;
    public int OceanChalice;

    ObjectManager script;
    PlayerTurns turnScript;
    Setup setupScript;
    TreasureCardTrade tradeScript;
    Use useScript;
    TokenMovement moveScript;

    public List<GameObject> Capturedtreasures = new List<GameObject>();

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        setupScript = GameObject.Find("GameCanvas").GetComponent<Setup>();
        tradeScript = GameObject.Find("GameCanvas").GetComponent<TreasureCardTrade>();
        useScript = GameObject.Find("GameCanvas").GetComponent<Use>();
        moveScript = GameObject.Find("GameCanvas").GetComponent<TokenMovement>();
    }
    private void Start()
    {
        InitialCaptureTreasurePanelP1.SetActive(false);
        InitialCaptureTreasurePanelP2.SetActive(false);

        Capture1.SetActive(false);
        Capture2.SetActive(false);
    }

    public void TreasureInitial()
    {
        OceansChalice.transform.position = new Vector3(-3.5f, 3, 0);
        CrystalOfFire.transform.position = new Vector3(3.5f, 3, 0);
        StatueOfTheWind.transform.position = new Vector3(-3.5f, -3, 0);
        EarthStone.transform.position = new Vector3(3.5f, -3, 0);
    }

    public void InitialCaptureButt()
    {
        if (turnScript.Player1Turn == true)
        {
            for (int i = 0; i < script.TilesInstances.Count; i++)
            {
                if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP1.SetActive(true);
                    CapTTxt1.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }

            }
        }
        else if (turnScript.Player2Turn == true)
        {
            for (int i = 0; i < script.TilesInstances.Count; i++)
            {
                if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }
                else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Earth Stone if you have 4 Earth Stone cards.";
                }
                else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Ocean's Chalice if you have 4 Ocean's Chalice cards.";
                }
                else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Crystal of Fire if you have 4 Crystal of Fire cards.";
                }
                else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                {
                    InitialCaptureTreasurePanelP2.SetActive(true);
                    CapTTxt2.text = "Can only capture Statue of the Wind if you have 4 Statue of the Wind cards.";
                }

            }
        }
    }

    public void Continue()
    {
        if (turnScript.Player1Turn == true)
        {
            Continue1.SetActive(false);
            CapTTxt1.text = "";

            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.Player1TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                {
                    script.TreasureCardInstances[i].UseButt.SetActive(true);
                }
            }
        }
        else if (turnScript.Player2Turn == true)
        {
            Continue2.SetActive(false);
            CapTTxt2.text = "";

            for(int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.Player2TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                {
                    script.TreasureCardInstances[i].UseButt.SetActive(true);
                }
            }
        }
    }

    public void Back()
    {
        Capture1.SetActive(false);
        Capture2.SetActive(false);

        EarthStones = 0;
        FireCrystal = 0;
        WindStatue = 0;
        OceanChalice = 0;

        if (turnScript.Player1Turn == true)
        {
            if (turnScript.Player1 == 3)
            {
                turnScript.MoveP1.SetActive(false);
                turnScript.ShoreUpP1.SetActive(false);
                turnScript.GiveTreasureP1.SetActive(false);
                turnScript.CaptureTreasureP1.SetActive(false);
                turnScript.EndTasksP1.SetActive(false);
                moveScript.P1DrawTreasureCards.SetActive(true);

                InitialCaptureTreasurePanelP1.SetActive(false);
                Continue1.SetActive(true);
            }
            else
            {
                InitialCaptureTreasurePanelP1.SetActive(false);
                Continue1.SetActive(true);
            }           
        }
        else if (turnScript.Player2Turn == true)
        {
            if (turnScript.Player2 == 3)
            {
                turnScript.MoveP2.SetActive(false);
                turnScript.ShoreUpP2.SetActive(false);
                turnScript.GiveTreasureP2.SetActive(false);
                turnScript.CaptureTreasureP2.SetActive(false);
                turnScript.EndTasksP2.SetActive(false);
                moveScript.P2DrawTreasureCards.SetActive(true);

                InitialCaptureTreasurePanelP2.SetActive(false);
                Continue2.SetActive(true);
            }
            else
            {
                InitialCaptureTreasurePanelP2.SetActive(false);
                Continue2.SetActive(true);
            }
        }

        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            script.TreasureCardInstances[i].UseButt.SetActive(false);
        }
    }

    public void Use()
    {
        if (turnScript.Player1Turn == true)
        {
            Capture1.SetActive(true);
            for (int i = 0; i < script.TilesInstances.Count; i++)
                {
                    if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt1.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt1.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt1.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt1.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt1.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt1.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt1.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt1.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt1.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt1.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt1.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt1.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt1.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt1.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt1.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt1.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt1.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt1.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt1.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt1.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt1.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt1.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt1.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt1.text = "Statue of Wind Cards: " + WindStatue;
                    }
                }

            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.TreasureCardInstances[i].Use == true)
                {
                    script.TreasureCardInstances[i].UseButt.SetActive(false);
                }
            }
        }
        else if (turnScript.Player2Turn == true)
        {
            Capture2.SetActive(true);
            for (int i = 0; i < script.TilesInstances.Count; i++)
                {
                    if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt2.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt2.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt2.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.greenToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt2.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt2.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt2.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt2.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.blueToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt2.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt2.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt2.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt2.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.blackToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt2.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt2.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt2.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt2.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.redToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt2.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt2.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt2.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt2.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.whiteToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt2.text = "Statue of Wind Cards: " + WindStatue;
                    }
                    else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].EarthStone == true)
                    {
                        EarthStones += 1;
                        CapTTxt2.text = "Earth Stone Cards: " + EarthStones;
                    }
                    else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].OceanChalice == true)
                    {
                        OceanChalice += 1;
                        CapTTxt2.text = "Ocean's Chalice Cards: " + OceanChalice;
                    }
                    else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].FireCrystal == true)
                    {
                        FireCrystal += 1;
                        CapTTxt2.text = "Crystal of Fire Cards: " + FireCrystal;
                    }
                    else if (tradeScript.yellowToken.transform.position == script.TilesInstances[i].Tile.transform.position && script.TilesInstances[i].WindStatue == true)
                    {
                        WindStatue += 1;
                        CapTTxt2.text = "Statue of Wind Cards: " + WindStatue;
                    }
                }

            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.TreasureCardInstances[i].Use == true)
                {
                    script.TreasureCardInstances[i].UseButt.SetActive(false);
                }
            }
        }
    }

    public void Capture()
    {
        if (turnScript.Player1Turn == true)
        {
            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (EarthStones == 4)
                {
                    EarthStone.transform.SetParent(setupScript.Player1.transform);
                    Capturedtreasures.Add(EarthStone);
                    turnScript.Player1 += 1;

                    if (script.Player1TreasureCards.Contains(script.TreasureCardInstances[i].CardType) && script.TreasureCardInstances[i].EarthStone == true)
                    {
                        script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                    }
                }
                else if (FireCrystal == 4)
                {
                    CrystalOfFire.transform.SetParent(setupScript.Player1.transform);
                    Capturedtreasures.Add(CrystalOfFire);
                    turnScript.Player1 += 1;

                    if (script.Player1TreasureCards.Contains(script.TreasureCardInstances[i].CardType) && script.TreasureCardInstances[i].FireCrystal == true)
                    {
                        script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                    }
                }
                else if (OceanChalice == 4)
                {
                    OceansChalice.transform.SetParent(setupScript.Player1.transform);
                    Capturedtreasures.Add(OceansChalice);
                    turnScript.Player1 += 1;

                    if (script.Player1TreasureCards.Contains(script.TreasureCardInstances[i].CardType) && script.TreasureCardInstances[i].OceansChalice == true)
                    {
                        script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                    }
                }
                else if (WindStatue == 4)
                {
                    StatueOfTheWind.transform.SetParent(setupScript.Player1.transform);
                    Capturedtreasures.Add(StatueOfTheWind);
                    turnScript.Player1 += 1;

                    if (script.Player1TreasureCards.Contains(script.TreasureCardInstances[i].CardType) && script.TreasureCardInstances[i].WindStatue == true)
                    {
                        script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                    }
                }
            }
        }
        else if (turnScript.Player2Turn == true)
        {
            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (EarthStones == 4)
                {
                    EarthStone.transform.SetParent(setupScript.Player2.transform);
                    Capturedtreasures.Add(EarthStone);
                    turnScript.Player2 += 1;

                    if (script.Player2TreasureCards.Contains(script.TreasureCardInstances[i].CardType) && script.TreasureCardInstances[i].EarthStone == true)
                    {
                        script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                    }
                }
                else if (FireCrystal == 4)
                {
                    CrystalOfFire.transform.SetParent(setupScript.Player2.transform);
                    Capturedtreasures.Add(CrystalOfFire);
                    turnScript.Player2 += 1;

                    if (script.Player2TreasureCards.Contains(script.TreasureCardInstances[i].CardType) && script.TreasureCardInstances[i].FireCrystal == true)
                    {
                        script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                    }
                }
                else if (OceanChalice == 4)
                {
                    OceansChalice.transform.SetParent(setupScript.Player2.transform);
                    Capturedtreasures.Add(OceansChalice);
                    turnScript.Player2 += 1;

                    if (script.Player2TreasureCards.Contains(script.TreasureCardInstances[i].CardType) && script.TreasureCardInstances[i].OceansChalice == true)
                    {
                        script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                    }
                }
                else if (WindStatue == 4)
                {
                    StatueOfTheWind.transform.SetParent(setupScript.Player2.transform);
                    Capturedtreasures.Add(StatueOfTheWind);
                    turnScript.Player2 += 1;

                    if (script.Player2TreasureCards.Contains(script.TreasureCardInstances[i].CardType) && script.TreasureCardInstances[i].WindStatue == true)
                    {
                        script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                    }
                }
            }
        }
    }
}

