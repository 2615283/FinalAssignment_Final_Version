using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions : MonoBehaviour
{
    ObjectManager script;
    public GameObject player1Title;
    public GameObject player2Title;

    public GameObject FirstTitle;
    public GameObject SecondTitle;

    public List<GameObject> AdvendurersInPosition = new List<GameObject>();

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
    }

    public void TilePostions()
    {
        Vector2 pos1 = new Vector2(-0.7f, 0.7f);
        GameObject firstTile = script.TilesObjects[Random.Range(0, 23)];
        firstTile.transform.position = pos1;
        script.TilesObjects.Remove(firstTile);

        Vector2 pos2 = new Vector2(0.7f, 0.7f);
        GameObject secondTile = script.TilesObjects[Random.Range(0, 22)];
        secondTile.transform.position = pos2;
        script.TilesObjects.Remove(secondTile);

        Vector2 pos3 = new Vector2(-0.7f, -0.7f);
        GameObject thirdTile = script.TilesObjects[Random.Range(0, 21)];
        thirdTile.transform.position = pos3;
        script.TilesObjects.Remove(thirdTile);

        Vector2 pos4 = new Vector2(0.7f, -0.7f);
        GameObject fourthTile = script.TilesObjects[Random.Range(0, 20)];
        fourthTile.transform.position = pos4;
        script.TilesObjects.Remove(fourthTile);

        Vector2 pos5 = new Vector2(-0.7f, 2.1f);
        GameObject fifthTile = script.TilesObjects[Random.Range(0, 19)];
        fifthTile.transform.position = pos5;
        script.TilesObjects.Remove(fifthTile);

        Vector2 pos6 = new Vector2(0.7f, 2.1f);
        GameObject sixthTile = script.TilesObjects[Random.Range(0, 18)];
        sixthTile.transform.position = pos6;
        script.TilesObjects.Remove(sixthTile);

        Vector2 pos7 = new Vector2(-0.7f, -2.1f);
        GameObject seventhTile = script.TilesObjects[Random.Range(0, 17)];
        seventhTile.transform.position = pos7;
        script.TilesObjects.Remove(seventhTile);

        Vector2 pos8 = new Vector2(0.7f, -2.1f);
        GameObject eighthTile = script.TilesObjects[Random.Range(0, 16)];
        eighthTile.transform.position = pos8;
        script.TilesObjects.Remove(eighthTile);

        Vector2 pos9 = new Vector2(-2.1f, 0.7f);
        GameObject ninthTile = script.TilesObjects[Random.Range(0, 15)];
        ninthTile.transform.position = pos9;
        script.TilesObjects.Remove(ninthTile);

        Vector2 pos10 = new Vector2(2.1f, 0.7f);
        GameObject tenthTile = script.TilesObjects[Random.Range(0, 14)];
        tenthTile.transform.position = pos10;
        script.TilesObjects.Remove(tenthTile);

        Vector2 pos11 = new Vector2(-2.1f, -0.7f);
        GameObject eleventhTile = script.TilesObjects[Random.Range(0, 13)];
        eleventhTile.transform.position = pos11;
        script.TilesObjects.Remove(eleventhTile);

        Vector2 pos12 = new Vector2(2.1f, -0.7f);
        GameObject twelthTile = script.TilesObjects[Random.Range(0, 12)];
        twelthTile.transform.position = pos12;
        script.TilesObjects.Remove(twelthTile);

        Vector2 pos13 = new Vector2(-3.5f, 0.7f);
        GameObject thirteenthTile = script.TilesObjects[Random.Range(0, 11)];
        thirteenthTile.transform.position = pos13;
        script.TilesObjects.Remove(thirteenthTile);

        Vector2 pos14 = new Vector2(3.5f, 0.7f);
        GameObject fourteenthTile = script.TilesObjects[Random.Range(0, 10)];
        fourteenthTile.transform.position = pos14;
        script.TilesObjects.Remove(fourteenthTile);

        Vector2 pos15 = new Vector2(-3.5f, -0.7f);
        GameObject fifteenthTile = script.TilesObjects[Random.Range(0, 9)];
        fifteenthTile.transform.position = pos15;
        script.TilesObjects.Remove(fifteenthTile);

        Vector2 pos16 = new Vector2(3.5f, -0.7f);
        GameObject sixteenthTile = script.TilesObjects[Random.Range(0, 8)];
        sixteenthTile.transform.position = pos16;
        script.TilesObjects.Remove(sixteenthTile);

        Vector2 pos17 = new Vector2(-0.7f, 3.5f);
        GameObject seventeenthTile = script.TilesObjects[Random.Range(0, 7)];
        seventeenthTile.transform.position = pos17;
        script.TilesObjects.Remove(seventeenthTile);

        Vector2 pos18 = new Vector2(0.7f, 3.5f);
        GameObject eightteenthTile = script.TilesObjects[Random.Range(0, 6)];
        eightteenthTile.transform.position = pos18;
        script.TilesObjects.Remove(eightteenthTile);

        Vector2 pos19 = new Vector2(-0.7f, -3.5f);
        GameObject ninteenthTile = script.TilesObjects[Random.Range(0, 5)];
        ninteenthTile.transform.position = pos19;
        script.TilesObjects.Remove(ninteenthTile);

        Vector2 pos20 = new Vector2(0.7f, -3.5f);
        GameObject twentiethTile = script.TilesObjects[Random.Range(0, 4)];
        twentiethTile.transform.position = pos20;
        script.TilesObjects.Remove(twentiethTile);

        Vector2 pos21 = new Vector2(-2.1f, 2.1f);
        GameObject twentyfirstTile = script.TilesObjects[Random.Range(0, 3)];
        twentyfirstTile.transform.position = pos21;
        script.TilesObjects.Remove(twentyfirstTile);

        Vector2 pos22 = new Vector2(2.1f, 2.1f);
        GameObject twentysecondTile = script.TilesObjects[Random.Range(0, 2)];
        twentysecondTile.transform.position = pos22;
        script.TilesObjects.Remove(twentysecondTile);

        Vector2 pos23 = new Vector2(-2.1f, -2.1f);
        GameObject twentythirdTile = script.TilesObjects[Random.Range(0, 1)];
        twentythirdTile.transform.position = pos23;
        script.TilesObjects.Remove(twentythirdTile);

        Vector2 pos24 = new Vector2(2.1f, -2.1f);
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
        GameObject Player1SetupCard1 = script.TreasureCardsObjects[Random.Range(0, 24)];
        script.Player1TreasureCards.Add(Player1SetupCard1);
        script.TreasureCardsObjects.Remove(Player1SetupCard1);
        script.Player1TreasureCards[script.Player1TreasureCards.Count - 1].transform.position = script.Player1TreasureCardsSpaces[script.Player1TreasureCards.Count - 1].transform.position;

        GameObject Player1SetupCard2 = script.TreasureCardsObjects[Random.Range(0, 23)];
        script.Player1TreasureCards.Add(Player1SetupCard2);
        script.TreasureCardsObjects.Remove(Player1SetupCard2);
        script.Player1TreasureCards[script.Player1TreasureCards.Count - 1].transform.position = script.Player1TreasureCardsSpaces[script.Player1TreasureCards.Count - 1].transform.position;

        GameObject Player2SetupCard1 = script.TreasureCardsObjects[Random.Range(0, 22)];
        script.Player2TreasureCards.Add(Player2SetupCard1);
        script.TreasureCardsObjects.Remove(Player2SetupCard1);
        script.Player2TreasureCards[script.Player2TreasureCards.Count - 1].transform.position = script.Player2TreasureCardsSpaces[script.Player2TreasureCards.Count - 1].transform.position;

        GameObject Player2SetupCard2 = script.TreasureCardsObjects[Random.Range(0, 21)];
        script.Player2TreasureCards.Add(Player2SetupCard2);
        script.TreasureCardsObjects.Remove(Player2SetupCard2);
        script.Player2TreasureCards[script.Player2TreasureCards.Count - 1].transform.position = script.Player2TreasureCardsSpaces[script.Player2TreasureCards.Count - 1].transform.position;
    }
}
