using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions : MonoBehaviour
{
    ObjectManager script;
    TokenMovement movementScript;
    PlayerTurns turnsScript;
    PilotScript pilotScript;
    DiverScript diverScript;

    public Vector3[,] grid = new Vector3[6,6];

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

    public int x = 6;
    public int y = 6;

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
    public List<Vector3> pos = new List<Vector3>();

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnsScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        pilotScript = GameObject.Find("GameCanvas").GetComponent<PilotScript>();
        diverScript = GameObject.Find("GameCanvas").GetComponent<DiverScript>();
    }

    // Positions... Crazy... I am well aware
    private void Start()
    {
        pos1 = new Vector3(-0.7f, 0.7f);
        pos2 = new Vector3(0.7f, 0.7f);
        pos3 = new Vector3(-0.7f, -0.7f);
        pos4 = new Vector3(0.7f, -0.7f);
        pos5 = new Vector3(-0.7f, 2.1f);
        pos6 = new Vector3(0.7f, 2.1f);
        pos7 = new Vector3(-0.7f, -2.1f);
        pos8 = new Vector3(0.7f, -2.1f);
        pos9 = new Vector3(-2.1f, 0.7f);
        pos10 = new Vector3(2.1f, 0.7f);
        pos11 = new Vector3(-2.1f, -0.7f);
        pos12 = new Vector3(2.1f, -0.7f);
        pos13 = new Vector3(-3.5f, 0.7f);
        pos14 = new Vector3(3.5f, 0.7f);
        pos15 = new Vector3(-3.5f, -0.7f);
        pos16 = new Vector3(3.5f, -0.7f);
        pos17 = new Vector3(-0.7f, 3.5f);
        pos18 = new Vector3(0.7f, 3.5f);
        pos19 = new Vector3(-0.7f, -3.5f);
        pos20 = new Vector3(0.7f, -3.5f);
        pos21 = new Vector3(-2.1f, 2.1f);
        pos22 = new Vector3(2.1f, 2.1f);
        pos23 = new Vector3(-2.1f, -2.1f);
        pos24 = new Vector3(2.1f, -2.1f);

        grid[0, 2] = pos17;
        grid[0, 3] = pos18;        
        grid[1, 1] = pos21;
        grid[1, 2] = pos5;
        grid[1, 3] = pos6;
        grid[1, 4] = pos22;
        grid[2, 0] = pos13;
        grid[2, 1] = pos9;
        grid[2, 2] = pos1;
        grid[2, 3] = pos2;
        grid[2, 4] = pos10;
        grid[2, 5] = pos14;
        grid[3, 0] = pos15;
        grid[3, 1] = pos11;
        grid[3, 2] = pos3;
        grid[3, 3] = pos4;
        grid[3, 4] = pos12;
        grid[3, 5] = pos16;
        grid[4, 1] = pos23;
        grid[4, 2] = pos7;
        grid[4, 3] = pos8;
        grid[4, 4] = pos24;
        grid[5, 2] = pos19;
        grid[5, 3] = pos20;

        Debug.Log(grid[0,0]);

        pos.Add(pos1);
        pos.Add(pos2);
        pos.Add(pos3);
        pos.Add(pos4);
        pos.Add(pos5);
        pos.Add(pos6);
        pos.Add(pos7);
        pos.Add(pos8);
        pos.Add(pos9);
        pos.Add(pos10); 
        pos.Add(pos11);
        pos.Add(pos12);
        pos.Add(pos13);
        pos.Add(pos14);
        pos.Add(pos15);
        pos.Add(pos16);
        pos.Add(pos17);
        pos.Add(pos18);
        pos.Add(pos19);
        pos.Add(pos20);
        pos.Add(pos21);
        pos.Add(pos22);
        pos.Add(pos23);
        pos.Add(pos24);
    }

    // Updates the position of the indicator as it moves
    private void Update()
    {
        for (int i = 0; i < Indicator.Count; i++)
        {
            Indicator[i].pos = Indicator[i].IndicatorObject.transform.position;
        }

        if (script.Player1TreasureCards.Count > 0)
        {
            for (int i = 0; i < script.Player1TreasureCards.Count; i++)
            {
                script.Player1TreasureCards[i].transform.position = script.Player1TreasureCardsSpaces[i].transform.position;
            }
        }

        if (script.Player2TreasureCards.Count > 0)
        {
            for (int i = 0; i < script.Player2TreasureCards.Count; i++)
            {
                script.Player2TreasureCards[i].transform.position = script.Player2TreasureCardsSpaces[i].transform.position;
            }
        }
    }

    // Initial placement of the tiles. Just chooses a random one from the pile and places it on the board. Not great or efficient
    // but it works...
    public void TilePostions()
    {
        GameObject firstTile = script.TilesObjects[Random.Range(0, 23)];
        firstTile.transform.position = pos1;
        script.TilesObjects.Remove(firstTile);

        GameObject secondTile = script.TilesObjects[Random.Range(0, 22)];
        secondTile.transform.position = pos2;
        script.TilesObjects.Remove(secondTile);

        GameObject thirdTile = script.TilesObjects[Random.Range(0, 21)];
        thirdTile.transform.position = pos3;
        script.TilesObjects.Remove(thirdTile);

        GameObject fourthTile = script.TilesObjects[Random.Range(0, 20)];
        fourthTile.transform.position = pos4;
        script.TilesObjects.Remove(fourthTile);

        GameObject fifthTile = script.TilesObjects[Random.Range(0, 19)];
        fifthTile.transform.position = pos5;
        script.TilesObjects.Remove(fifthTile);

        GameObject sixthTile = script.TilesObjects[Random.Range(0, 18)];
        sixthTile.transform.position = pos6;
        script.TilesObjects.Remove(sixthTile);

        GameObject seventhTile = script.TilesObjects[Random.Range(0, 17)];
        seventhTile.transform.position = pos7;
        script.TilesObjects.Remove(seventhTile);

        GameObject eighthTile = script.TilesObjects[Random.Range(0, 16)];
        eighthTile.transform.position = pos8;
        script.TilesObjects.Remove(eighthTile);

        GameObject ninthTile = script.TilesObjects[Random.Range(0, 15)];
        ninthTile.transform.position = pos9;
        script.TilesObjects.Remove(ninthTile);

        GameObject tenthTile = script.TilesObjects[Random.Range(0, 14)];
        tenthTile.transform.position = pos10;
        script.TilesObjects.Remove(tenthTile);

        GameObject eleventhTile = script.TilesObjects[Random.Range(0, 13)];
        eleventhTile.transform.position = pos11;
        script.TilesObjects.Remove(eleventhTile);

        GameObject twelthTile = script.TilesObjects[Random.Range(0, 12)];
        twelthTile.transform.position = pos12;
        script.TilesObjects.Remove(twelthTile);

        GameObject thirteenthTile = script.TilesObjects[Random.Range(0, 11)];
        thirteenthTile.transform.position = pos13;
        script.TilesObjects.Remove(thirteenthTile);

        GameObject fourteenthTile = script.TilesObjects[Random.Range(0, 10)];
        fourteenthTile.transform.position = pos14;
        script.TilesObjects.Remove(fourteenthTile);

        GameObject fifteenthTile = script.TilesObjects[Random.Range(0, 9)];
        fifteenthTile.transform.position = pos15;
        script.TilesObjects.Remove(fifteenthTile);

        GameObject sixteenthTile = script.TilesObjects[Random.Range(0, 8)];
        sixteenthTile.transform.position = pos16;
        script.TilesObjects.Remove(sixteenthTile);

        GameObject seventeenthTile = script.TilesObjects[Random.Range(0, 7)];
        seventeenthTile.transform.position = pos17;
        script.TilesObjects.Remove(seventeenthTile);

        GameObject eightteenthTile = script.TilesObjects[Random.Range(0, 6)];
        eightteenthTile.transform.position = pos18;
        script.TilesObjects.Remove(eightteenthTile);

        GameObject ninteenthTile = script.TilesObjects[Random.Range(0, 5)];
        ninteenthTile.transform.position = pos19;
        script.TilesObjects.Remove(ninteenthTile);

        GameObject twentiethTile = script.TilesObjects[Random.Range(0, 4)];
        twentiethTile.transform.position = pos20;
        script.TilesObjects.Remove(twentiethTile);

        GameObject twentyfirstTile = script.TilesObjects[Random.Range(0, 3)];
        twentyfirstTile.transform.position = pos21;
        script.TilesObjects.Remove(twentyfirstTile);

        GameObject twentysecondTile = script.TilesObjects[Random.Range(0, 2)];
        twentysecondTile.transform.position = pos22;
        script.TilesObjects.Remove(twentysecondTile);

        GameObject twentythirdTile = script.TilesObjects[Random.Range(0, 1)];
        twentythirdTile.transform.position = pos23;
        script.TilesObjects.Remove(twentythirdTile);

        GameObject twentyfourthTile = script.TilesObjects[Random.Range(0, 0)];
        twentyfourthTile.transform.position = pos24;
        script.TilesObjects.Remove(twentyfourthTile);
    }


    // Title of Adventurer is placed on the player panels.
    public void AdventurersPositions()
    {
        FirstTitle =  script.AdventurerCardsObjects[Random.Range(0, 3)];
        FirstTitle.transform.position = player1Title.transform.position;
        script.AdventurerCardsObjects.Remove(FirstTitle);
        AdvendurersInPosition.Add(FirstTitle);


        SecondTitle = script.AdventurerCardsObjects[Random.Range(0, 2)];
        SecondTitle.transform.position = player2Title.transform.position;
        script.AdventurerCardsObjects.Remove(SecondTitle);
        AdvendurersInPosition.Add(SecondTitle);

        // Sets the relevant Adventurers to active, and the Player that is associated with the adventurer to true
        //... I think that makes sense
        for (int i = 0; i < script.AdventurersInstances.Count; i++)
        {
            if(script.AdventurersInstances[i].Title.transform.position == player1Title.transform.position)
            {
                script.AdventurersInstances[i].Active = true;
                script.AdventurersInstances[i].Player1 = true;
            }
            else if (script.AdventurersInstances[i].Title.transform.position == player2Title.transform.position)
            {
                script.AdventurersInstances[i].Active = true;
                script.AdventurersInstances[i].Player2 = true;
            }
            else 
            {
            
            }
        }

    }

    // Deals Initial two treasure cards to the players.
    // Chooses a random card from the list or pile, removes it from the list and adds it to the relevant player hand
    // Also indicates where the card should be placed in the player hand by using the lists
    public void DealingTreasureCardsToPlayers()
    {
        GameObject Player1SetupCard1 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
        script.Player1TreasureCards.Add(Player1SetupCard1);
        script.TreasureCardsObjects.Remove(Player1SetupCard1);
        
        GameObject Player1SetupCard2 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
        script.Player1TreasureCards.Add(Player1SetupCard2);
        script.TreasureCardsObjects.Remove(Player1SetupCard2);
        
        GameObject Player2SetupCard1 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
        script.Player2TreasureCards.Add(Player2SetupCard1);
        script.TreasureCardsObjects.Remove(Player2SetupCard1);
        
        GameObject Player2SetupCard2 = script.TreasureCardsObjects[Random.Range(0, script.TreasureCardsObjects.Count)];
        script.Player2TreasureCards.Add(Player2SetupCard2);
        script.TreasureCardsObjects.Remove(Player2SetupCard2);
    }

    // So... Extra Crazy Code. This indicates where the movement indicator goes, depending on where the token is currently placed. It checks
    // which player turn is currently active, then it checks which adventurer is active and if it is that adventurer is starts
    // checking on which tiles they are placed and then it places the indicators around the token, if there are tiles.
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
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 1.4f, 0);
                            }
                            Indicator[5].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[6].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[7].IndicatorObject.transform.position = new Vector3(0, 10, 0);

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
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, -1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, -1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0);
                            }
                            Indicator[5].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[6].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[7].IndicatorObject.transform.position = new Vector3(0, 10, 0);
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
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, -1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, -1.4f, 0);
                            }
                            Indicator[5].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[6].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[7].IndicatorObject.transform.position = new Vector3(0, 10, 0);
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
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 1.4f, 0);
                            }
                            Indicator[5].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[6].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[7].IndicatorObject.transform.position = new Vector3(0, 10, 0);
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
                        // Pilot has different movement, which is a bit intense so it is in it's own script.
                        pilotScript.PilotMove();
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver" && script.AdventurersInstances[i].Title.transform.position == player1Title.transform.position)
                    {
                        // Also has it's own movement, will be added soon
                        diverScript.Diver();
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

    // Same as previous, just for player 2, because it wanted to be a hater and not work together
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
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 1.4f, 0);
                            }
                            Indicator[5].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[6].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[7].IndicatorObject.transform.position = new Vector3(0, 10, 0);

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
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, -1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, -1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0);
                            }
                            Indicator[5].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[6].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[7].IndicatorObject.transform.position = new Vector3(0, 10, 0);
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
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(-1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, -1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, -1.4f, 0);
                            }
                            Indicator[5].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[6].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[7].IndicatorObject.transform.position = new Vector3(0, 10, 0);
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
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[3].IndicatorObject.transform.position = greenToken.transform.position + new Vector3(1.4f, 1.4f, 0);
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 1.4f, 0))
                            {
                                Indicator[4].IndicatorObject.transform.position = greenToken.transform.position - new Vector3(1.4f, 1.4f, 0);
                            }
                            Indicator[5].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[6].IndicatorObject.transform.position = new Vector3(0, 10, 0);
                            Indicator[7].IndicatorObject.transform.position = new Vector3(0, 10, 0);
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
                        pilotScript.PilotMove();
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver" && script.AdventurersInstances[i].Title.transform.position == player2Title.transform.position)
                    {
                        diverScript.Diver();
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

    // Removes the Indicators from the board
    public void IndicatorFin()
    {
        for (int i = 0; i < Indicator.Count; i++)
        {
            Indicator[i].IndicatorObject.transform.position = new Vector3(0, 10, 0);
        }
    }

    // Indicator Class... should this be in the Object Manager? probably. 
    [System.Serializable]
    public class Indicators
    {
        public GameObject IndicatorObject;
        public Vector3 pos;

        public bool click;
    }
}
