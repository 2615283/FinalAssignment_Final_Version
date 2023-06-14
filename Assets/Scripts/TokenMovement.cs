using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TokenMovement : MonoBehaviour
{
    public GameObject redToken;
    public GameObject blackToken;
    public GameObject blueToken;
    public GameObject greenToken;
    public GameObject whiteToken;
    public GameObject yellowToken;

    public GameObject P1MovePanel;
    public GameObject P2MovePanel;

    public GameObject P1DrawTreasureCards;
    public GameObject P2DrawTreasureCards;
    public GameObject P1DrawFloodCards;
    public GameObject P2DrawFloodCards;
    public GameObject P1Done;
    public GameObject P2Done;

    ObjectManager script;
    Setup setupScript;
    PlayerTurns turnScript;
    Positions posScript;
    IndicatorDeterminer indScript;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        setupScript = GameObject.Find("GameCanvas").GetComponent<Setup>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        posScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
        indScript = GameObject.Find("GameCanvas").GetComponent<IndicatorDeterminer>();
    }

    private void Start()
    {
        P1MovePanel.SetActive(false);
        P2MovePanel.SetActive(false);
    }

    private void Update()
    {
        for (int i = 0; i < script.AdventurersInstances.Count; i++)
        {
            for (int j = 0; j < posScript.Indicator.Count; j++)
            {
                if (turnScript.Player1Turn == true)
                {
                    if (posScript.Indicator[j].click == true)
                    {
                        if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Explorer" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                        {
                            greenToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Pilot" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                        {
                            blueToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Messenger" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                        {
                            whiteToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Navigator" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                        {
                            yellowToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                        {
                            blackToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Engineer" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                        {
                            redToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                    }
                }
                else if (turnScript.Player2Turn == true)
                {
                    if (posScript.Indicator[j].click == true)
                    {
                        if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Explorer" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                        {
                            greenToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Pilot" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                        {
                            blueToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Messenger" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                        {
                            whiteToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Navigator" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                        {
                            yellowToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                        {
                            blackToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                        else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Engineer" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                        {
                            redToken.transform.position = posScript.Indicator[j].IndicatorObject.transform.position;
                        }
                    }
                }
            }
        }
    }

    public void DisableButton()
    {
        for (int i = 0; i < script.TilesInstances.Count; i++)
        {
            GameObject Tile = script.TilesInstances[i].Tile;
            Tile.GetComponent<Button>().enabled = false;
        }
    }

    public void InitialPlacement()
    {
        for (int i = 0; i < script.AdventurersInstances.Count; i++)
        {
            for (int j = 0; j < script.TilesInstances.Count; j++)
            {
                if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].Green == true && script.TilesInstances[j].Green == true)
                {
                    greenToken.transform.position = script.TilesInstances[j].pos;
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].Blue == true && script.TilesInstances[j].Blue == true)
                {
                    blueToken.transform.position = script.TilesInstances[j].pos;
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].Black == true && script.TilesInstances[j].Black == true)
                {
                    blackToken.transform.position = script.TilesInstances[j].pos;
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].Red == true && script.TilesInstances[j].Red == true)
                {
                    redToken.transform.position = script.TilesInstances[j].pos;
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].Yellow == true && script.TilesInstances[j].Yellow == true)
                {
                    yellowToken.transform.position = script.TilesInstances[j].pos;
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].White == true && script.TilesInstances[j].White == true)
                {
                    whiteToken.transform.position = script.TilesInstances[j].pos;
                }
            }
        }
    }

    public void MoveP1Button()
    {
        setupScript.Player1Actions.SetActive(false);
        P1MovePanel.SetActive(true);
    }

    public void DoneMoveP1()
    {
        if (turnScript.Player1 == 3)
        {
            P1DrawTreasureCards.SetActive(true);
            P1DrawFloodCards.SetActive(true);
            P1Done.SetActive(true);
            P1MovePanel.SetActive(false);
            turnScript.MoveP1.SetActive(false);
            turnScript.ShoreUpP1.SetActive(false);
            turnScript.GiveTreasureP1.SetActive(false);
            turnScript.CaptureTreasureP1.SetActive(false);
            turnScript.EndTasksP1.SetActive(false);
            setupScript.Player1Actions.SetActive(true);
        }
        else
        {
            setupScript.Player1Actions.SetActive(true);
            P1MovePanel.SetActive(false);
        }
    }

    public void MoveP2Button()
    {
        setupScript.Player2Actions.SetActive(false);
        P2MovePanel.SetActive(true);
    }

    public void DoneMoveP2()
    {
        if (turnScript.Player2 == 3)
        {
            P2DrawTreasureCards.SetActive(true);
            P2DrawFloodCards.SetActive(true);
            P2Done.SetActive(true);
            P2MovePanel.SetActive(false);
            turnScript.MoveP2.SetActive(false);
            turnScript.ShoreUpP2.SetActive(false);
            turnScript.GiveTreasureP2.SetActive(false);
            turnScript.CaptureTreasureP2.SetActive(false);
            turnScript.EndTasksP2.SetActive(false);
            setupScript.Player2Actions.SetActive(true);
        }
        else
        {
            setupScript.Player2Actions.SetActive(true);
            P2MovePanel.SetActive(false);
        }
    }

    public void Movement()
    {
        
        
        

        

        
    }
}
