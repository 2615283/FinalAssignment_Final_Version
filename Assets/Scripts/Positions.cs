using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions : MonoBehaviour
{
    ObjectManager script;
    TokenMovement movementScript;
    PlayerTurns turnsScript;

    public GameObject player1Title;
    public GameObject player2Title;

    public GameObject FirstTitle;
    public GameObject SecondTitle;

    public GameObject redToken;
    public GameObject blackToken;
    public GameObject blueToken;
    public GameObject greenToken;
    public GameObject whiteToken;
    public GameObject yellowToken;

    //positions
    #region
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 pos3;
    public Vector3 pos4;
    public Vector3 pos5;
    public Vector3 pos6;
    public Vector3 pos7;
    public Vector3 pos8;
    public Vector3 pos9;
    public Vector3 pos10;
    public Vector3 pos11;
    public Vector3 pos12;
    public Vector3 pos13;
    public Vector3 pos14;
    public Vector3 pos15;
    public Vector3 pos16;
    public Vector3 pos17;
    public Vector3 pos18;
    public Vector3 pos19;
    public Vector3 pos20;
    public Vector3 pos21;
    public Vector3 pos22;
    public Vector3 pos23;
    public Vector3 pos24;
    #endregion

    public List<Indicators> Indicator = new List<Indicators>();
    public List<GameObject> AdvendurersInPosition = new List<GameObject>();

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnsScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
    }

    private void Update()
    {
        for (int i = 0; i < Indicator.Count; i++)
        {
            Indicator[i].pos = Indicator[i].IndicatorObject.transform.position;
        }
    }

    public void TilePostions()
    {
        pos1 = new Vector2(-0.7f, 0.7f);
        GameObject firstTile = script.TilesObjects[Random.Range(0, 23)];
        firstTile.transform.position = pos1;
        script.TilesObjects.Remove(firstTile);

        pos2 = new Vector2(0.7f, 0.7f);
        GameObject secondTile = script.TilesObjects[Random.Range(0, 22)];
        secondTile.transform.position = pos2;
        script.TilesObjects.Remove(secondTile);

        pos3 = new Vector2(-0.7f, -0.7f);
        GameObject thirdTile = script.TilesObjects[Random.Range(0, 21)];
        thirdTile.transform.position = pos3;
        script.TilesObjects.Remove(thirdTile);

        pos4 = new Vector2(0.7f, -0.7f);
        GameObject fourthTile = script.TilesObjects[Random.Range(0, 20)];
        fourthTile.transform.position = pos4;
        script.TilesObjects.Remove(fourthTile);

        pos5 = new Vector2(-0.7f, 2.1f);
        GameObject fifthTile = script.TilesObjects[Random.Range(0, 19)];
        fifthTile.transform.position = pos5;
        script.TilesObjects.Remove(fifthTile);

        pos6 = new Vector2(0.7f, 2.1f);
        GameObject sixthTile = script.TilesObjects[Random.Range(0, 18)];
        sixthTile.transform.position = pos6;
        script.TilesObjects.Remove(sixthTile);

        pos7 = new Vector2(-0.7f, -2.1f);
        GameObject seventhTile = script.TilesObjects[Random.Range(0, 17)];
        seventhTile.transform.position = pos7;
        script.TilesObjects.Remove(seventhTile);

        pos8 = new Vector2(0.7f, -2.1f);
        GameObject eighthTile = script.TilesObjects[Random.Range(0, 16)];
        eighthTile.transform.position = pos8;
        script.TilesObjects.Remove(eighthTile);

        pos9 = new Vector2(-2.1f, 0.7f);
        GameObject ninthTile = script.TilesObjects[Random.Range(0, 15)];
        ninthTile.transform.position = pos9;
        script.TilesObjects.Remove(ninthTile);

        pos10 = new Vector2(2.1f, 0.7f);
        GameObject tenthTile = script.TilesObjects[Random.Range(0, 14)];
        tenthTile.transform.position = pos10;
        script.TilesObjects.Remove(tenthTile);

        pos11 = new Vector2(-2.1f, -0.7f);
        GameObject eleventhTile = script.TilesObjects[Random.Range(0, 13)];
        eleventhTile.transform.position = pos11;
        script.TilesObjects.Remove(eleventhTile);

        pos12 = new Vector2(2.1f, -0.7f);
        GameObject twelthTile = script.TilesObjects[Random.Range(0, 12)];
        twelthTile.transform.position = pos12;
        script.TilesObjects.Remove(twelthTile);

        pos13 = new Vector2(-3.5f, 0.7f);
        GameObject thirteenthTile = script.TilesObjects[Random.Range(0, 11)];
        thirteenthTile.transform.position = pos13;
        script.TilesObjects.Remove(thirteenthTile);

        pos14 = new Vector2(3.5f, 0.7f);
        GameObject fourteenthTile = script.TilesObjects[Random.Range(0, 10)];
        fourteenthTile.transform.position = pos14;
        script.TilesObjects.Remove(fourteenthTile);

        pos15 = new Vector2(-3.5f, -0.7f);
        GameObject fifteenthTile = script.TilesObjects[Random.Range(0, 9)];
        fifteenthTile.transform.position = pos15;
        script.TilesObjects.Remove(fifteenthTile);

        pos16 = new Vector2(3.5f, -0.7f);
        GameObject sixteenthTile = script.TilesObjects[Random.Range(0, 8)];
        sixteenthTile.transform.position = pos16;
        script.TilesObjects.Remove(sixteenthTile);

        pos17 = new Vector2(-0.7f, 3.5f);
        GameObject seventeenthTile = script.TilesObjects[Random.Range(0, 7)];
        seventeenthTile.transform.position = pos17;
        script.TilesObjects.Remove(seventeenthTile);

        pos18 = new Vector2(0.7f, 3.5f);
        GameObject eightteenthTile = script.TilesObjects[Random.Range(0, 6)];
        eightteenthTile.transform.position = pos18;
        script.TilesObjects.Remove(eightteenthTile);

        pos19 = new Vector2(-0.7f, -3.5f);
        GameObject ninteenthTile = script.TilesObjects[Random.Range(0, 5)];
        ninteenthTile.transform.position = pos19;
        script.TilesObjects.Remove(ninteenthTile);

        pos20 = new Vector2(0.7f, -3.5f);
        GameObject twentiethTile = script.TilesObjects[Random.Range(0, 4)];
        twentiethTile.transform.position = pos20;
        script.TilesObjects.Remove(twentiethTile);

        pos21 = new Vector2(-2.1f, 2.1f);
        GameObject twentyfirstTile = script.TilesObjects[Random.Range(0, 3)];
        twentyfirstTile.transform.position = pos21;
        script.TilesObjects.Remove(twentyfirstTile);

        pos22 = new Vector2(2.1f, 2.1f);
        GameObject twentysecondTile = script.TilesObjects[Random.Range(0, 2)];
        twentysecondTile.transform.position = pos22;
        script.TilesObjects.Remove(twentysecondTile);

        pos23 = new Vector2(-2.1f, -2.1f);
        GameObject twentythirdTile = script.TilesObjects[Random.Range(0, 1)];
        twentythirdTile.transform.position = pos23;
        script.TilesObjects.Remove(twentythirdTile);

        pos24 = new Vector2(2.1f, -2.1f);
        GameObject twentyfourthTile = script.TilesObjects[Random.Range(0, 0)];
        twentyfourthTile.transform.position = pos24;
        script.TilesObjects.Remove(twentyfourthTile);
    }

    public void AdventurersPositions()
    {
        FirstTitle =  script.AdventurerCardsObjects[Random.Range(0, 5)];
        FirstTitle.transform.position = player1Title.transform.position;
        script.AdventurerCardsObjects.Remove(FirstTitle);
        AdvendurersInPosition.Add(FirstTitle);


        SecondTitle = script.AdventurerCardsObjects[Random.Range(0, 4)];
        SecondTitle.transform.position = player2Title.transform.position;
        script.AdventurerCardsObjects.Remove(SecondTitle);
        AdvendurersInPosition.Add(SecondTitle);

        for (int i = 0; i < script.AdventurersInstances.Count; i++)
        {
            if(script.AdventurersInstances[i].Title.transform.position == player1Title.transform.position)
            {
                script.AdventurersInstances[i].Active = true;
            }
            else if (script.AdventurersInstances[i].Title.transform.position == player2Title.transform.position)
            {
                script.AdventurersInstances[i].Active = true;
            }
            else 
            {
            
            }
        }

    }

    public void DealingTreasureCardsToPlayers()
    {
        GameObject Player1SetupCard1 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
        script.Player1TreasureCards.Add(Player1SetupCard1);
        script.TreasureCardsObjects.Remove(Player1SetupCard1);
        script.Player1TreasureCards[script.Player1TreasureCards.Count - 1].transform.position = script.Player1TreasureCardsSpaces[script.Player1TreasureCards.Count - 1].transform.position;

        GameObject Player1SetupCard2 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
        script.Player1TreasureCards.Add(Player1SetupCard2);
        script.TreasureCardsObjects.Remove(Player1SetupCard2);
        script.Player1TreasureCards[script.Player1TreasureCards.Count - 1].transform.position = script.Player1TreasureCardsSpaces[script.Player1TreasureCards.Count - 1].transform.position;

        GameObject Player2SetupCard1 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
        script.Player2TreasureCards.Add(Player2SetupCard1);
        script.TreasureCardsObjects.Remove(Player2SetupCard1);
        script.Player2TreasureCards[script.Player2TreasureCards.Count - 1].transform.position = script.Player2TreasureCardsSpaces[script.Player2TreasureCards.Count - 1].transform.position;

        GameObject Player2SetupCard2 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
        script.Player2TreasureCards.Add(Player2SetupCard2);
        script.TreasureCardsObjects.Remove(Player2SetupCard2);
        script.Player2TreasureCards[script.Player2TreasureCards.Count - 1].transform.position = script.Player2TreasureCardsSpaces[script.Player2TreasureCards.Count - 1].transform.position;
    }

    public void PositionsOfIndicatorsPlayer1()
    {
        if (turnsScript.Player1Turn == true)
        {
            for (int i = 0; i < script.AdventurersInstances.Count; i++)
            {
                for (int j = 0; j < script.TilesInstances.Count; j++)
                {
                    if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Explorer" && script.AdventurersInstances[i].Title.transform.position == player1Title.transform.position)
                    {
                        if (greenToken.transform.position == pos17 || greenToken.transform.position == pos21 || greenToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, -1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, -1.4f, 0);
                            }
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[4].IndicatorObject.transform.position = new Vector3(0, 10, 0);

                        }
                        else if (greenToken.transform.position == pos18 || greenToken.transform.position == pos22 || greenToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 1.4f, 0);
                            }
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[4].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == pos15 || greenToken.transform.position == pos23 || greenToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 1.4f, 0);
                            }
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[4].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == pos16 || greenToken.transform.position == pos24 || greenToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0);
                            }
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[4].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, -1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, -1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0))
                            {
                                Indicator[5].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[6].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[7].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Pilot" && script.AdventurersInstances[i].Title.transform.position == player1Title.transform.position)
                    {
                        if (blueToken.transform.position == pos17 || blueToken.transform.position == pos21 || blueToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == pos18 || blueToken.transform.position == pos22 || blueToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == pos15 || blueToken.transform.position == pos23 || blueToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == pos16 || blueToken.transform.position == pos24 || blueToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver" && script.AdventurersInstances[i].Title.transform.position == player1Title.transform.position)
                    {
                        if (blackToken.transform.position == pos17 || blackToken.transform.position == pos21 || blackToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == pos18 || blackToken.transform.position == pos22 || blackToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == pos15 || blackToken.transform.position == pos23 || blackToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == pos16 || blackToken.transform.position == pos24 || blackToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Engineer" && script.AdventurersInstances[i].Title.transform.position == player1Title.transform.position)
                    {
                        if (redToken.transform.position == pos17 || redToken.transform.position == pos21 || redToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == pos18 || redToken.transform.position == pos22 || redToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == pos15 || redToken.transform.position == pos23 || redToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == pos16 || redToken.transform.position == pos24 || redToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Messenger" && script.AdventurersInstances[i].Title.transform.position == player1Title.transform.position)
                    {
                        if (whiteToken.transform.position == pos17 || whiteToken.transform.position == pos21 || whiteToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == pos18 || whiteToken.transform.position == pos22 || whiteToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == pos15 || whiteToken.transform.position == pos23 || whiteToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == pos16 || whiteToken.transform.position == pos24 || whiteToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Navigator" && script.AdventurersInstances[i].Title.transform.position == player1Title.transform.position)
                    {
                        if (yellowToken.transform.position == pos17 || yellowToken.transform.position == pos21 || yellowToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == pos18 || yellowToken.transform.position == pos22 || yellowToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == pos15 || yellowToken.transform.position == pos23 || yellowToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == pos16 || yellowToken.transform.position == pos24 || yellowToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                }                
            }
        }
    }

    public void PositionsOfIndicatorsPlayer2()
    {
        if (turnsScript.Player2Turn == true)
        {
            for (int i = 0; i < script.AdventurersInstances.Count; i++)
            {
                for (int j = 0; j < script.TilesInstances.Count; j++)
                {
                    if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Explorer" && script.AdventurersInstances[i].Title.transform.position == player2Title.transform.position)
                    {
                        if (greenToken.transform.position == pos17 || greenToken.transform.position == pos21 || greenToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, -1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, -1.4f, 0);
                            }
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[4].IndicatorObject.transform.position = new Vector3(0, 10, 0);

                        }
                        else if (greenToken.transform.position == pos18 || greenToken.transform.position == pos22 || greenToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 1.4f, 0);
                            }
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[4].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == pos15 || greenToken.transform.position == pos23 || greenToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 1.4f, 0);
                            }
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[4].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == pos16 || greenToken.transform.position == pos24 || greenToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0);
                            }
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[4].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, -1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, -1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0))
                            {
                                Indicator[5].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[6].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[7].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Pilot" && script.AdventurersInstances[i].Title.transform.position == player2Title.transform.position)
                    {
                        if (blueToken.transform.position == pos17 || blueToken.transform.position == pos21 || blueToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == pos18 || blueToken.transform.position == pos22 || blueToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == pos15 || blueToken.transform.position == pos23 || blueToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == pos16 || blueToken.transform.position == pos24 || blueToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver" && script.AdventurersInstances[i].Title.transform.position == player2Title.transform.position)
                    {
                        if (blackToken.transform.position == pos17 || blackToken.transform.position == pos21 || blackToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == pos18 || blackToken.transform.position == pos22 || blackToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == pos15 || blackToken.transform.position == pos23 || blackToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == pos16 || blackToken.transform.position == pos24 || blackToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Engineer" && script.AdventurersInstances[i].Title.transform.position == player2Title.transform.position)
                    {
                        if (redToken.transform.position == pos17 || redToken.transform.position == pos21 || redToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == pos18 || redToken.transform.position == pos22 || redToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == pos15 || redToken.transform.position == pos23 || redToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == pos16 || redToken.transform.position == pos24 || redToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Messenger" && script.AdventurersInstances[i].Title.transform.position == player2Title.transform.position)
                    {
                        if (whiteToken.transform.position == pos17 || whiteToken.transform.position == pos21 || whiteToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == pos18 || whiteToken.transform.position == pos22 || whiteToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == pos15 || whiteToken.transform.position == pos23 || whiteToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == pos16 || whiteToken.transform.position == pos24 || whiteToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Navigator" && script.AdventurersInstances[i].Title.transform.position == player2Title.transform.position)
                    {
                        if (yellowToken.transform.position == pos17 || yellowToken.transform.position == pos21 || yellowToken.transform.position == pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == pos18 || yellowToken.transform.position == pos22 || yellowToken.transform.position == pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == pos15 || yellowToken.transform.position == pos23 || yellowToken.transform.position == pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == pos16 || yellowToken.transform.position == pos24 || yellowToken.transform.position == pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            Indicator[2].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[3].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0))
                            {
                                Indicator[0].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0))
                            {
                                Indicator[1].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0))
                            {
                                Indicator[2].IndicatorObject.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                            }
                        }
                    }
                }
            }
        }
    }

    public void IndicatorFin()
    {
        for (int i = 0; i < Indicator.Count; i++)
        {
            Indicator[i].IndicatorObject.transform.position = new Vector3(0, 10, 0);
        }
    }

    [System.Serializable]
    public class Indicators
    {
        public GameObject IndicatorObject;
        public Vector3 pos;

        public bool click;
    }
}
