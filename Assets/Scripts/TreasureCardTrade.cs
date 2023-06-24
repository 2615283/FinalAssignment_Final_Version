using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCardTrade : MonoBehaviour
{
    public GameObject redToken;
    public GameObject blackToken;
    public GameObject blueToken;
    public GameObject greenToken;
    public GameObject whiteToken;
    public GameObject yellowToken;

    public GameObject GiveTreasurePanelP1;
    public GameObject GiveTreasurePanelP2;
    public GameObject NoGivingP1;
    public GameObject NoGivingP2;

    ObjectManager script;
    PlayerTurns turnScript;
    Setup setupScript;

    public List<GameObject> Tokenlist1 = new List<GameObject>();
    public List<GameObject> Tokenlist2 = new List<GameObject>();

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        setupScript = GameObject.Find("GameCanvas").GetComponent<Setup>();
    }

    // Enables and disables relevant objects and adds things to lists
    private void Start()
    {
        GiveTreasurePanelP1.SetActive(false);
        GiveTreasurePanelP2.SetActive(false);

        NoGivingP1.SetActive(false);
        NoGivingP2.SetActive(false);

        Tokenlist1.Add(greenToken);
        Tokenlist1.Add(blueToken);
        Tokenlist1.Add(blackToken);
        Tokenlist1.Add(redToken);
        Tokenlist1.Add(whiteToken);
        Tokenlist1.Add(yellowToken);

        Tokenlist2.Add(greenToken);
        Tokenlist2.Add(blueToken);
        Tokenlist2.Add(blackToken);
        Tokenlist2.Add(redToken);
        Tokenlist2.Add(whiteToken);
        Tokenlist2.Add(yellowToken);

        // sets give buttons to false at the beginning of the game
        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            script.TreasureCardInstances[i].GiveButt.SetActive(false);
        }
    }

    // Checkes whether the two tokens are on the same tile. If they are, Players can give cards by pressing the enabled give button
    // if not, Nothing happens and a message pops up saying you cant do so.
    // Unless you are the messenger
    public void GivingTreasure()
    {
        for (int i = 0; i < script.AdventurersInstances.Count; i++)
        {
            if (turnScript.Player1Turn == true)
            {
                if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Explorer")
                {
                    if (greenToken.transform.position == blueToken.transform.position || greenToken.transform.position == blackToken.transform.position || greenToken.transform.position == redToken.transform.position || greenToken.transform.position == whiteToken.transform.position || greenToken.transform.position == yellowToken.transform.position)
                    {
                        GiveTreasurePanelP1.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP1.SetActive(true);
                    }
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Pilot")
                {
                    if (blueToken.transform.position == greenToken.transform.position || blueToken.transform.position == blackToken.transform.position || blueToken.transform.position == redToken.transform.position || blueToken.transform.position == whiteToken.transform.position || blueToken.transform.position == yellowToken.transform.position)
                    {
                        GiveTreasurePanelP1.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP1.SetActive(true);
                    }
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver")
                {
                    if (blackToken.transform.position == greenToken.transform.position || blackToken.transform.position == blueToken.transform.position || blackToken.transform.position == redToken.transform.position || blackToken.transform.position == whiteToken.transform.position || blackToken.transform.position == yellowToken.transform.position)
                    {
                        GiveTreasurePanelP1.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP1.SetActive(true);
                    }
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Engineer")
                {
                    if (redToken.transform.position == greenToken.transform.position || redToken.transform.position == blueToken.transform.position || redToken.transform.position == blackToken.transform.position || redToken.transform.position == whiteToken.transform.position || redToken.transform.position == yellowToken.transform.position)
                    {
                        GiveTreasurePanelP1.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP1.SetActive(true);
                    }
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Messenger")
                {
                        GiveTreasurePanelP1.SetActive(true);
                        GiveButtActive();
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Navigator")
                {
                    if (yellowToken.transform.position == greenToken.transform.position || yellowToken.transform.position == blueToken.transform.position || yellowToken.transform.position == blackToken.transform.position || yellowToken.transform.position == redToken.transform.position || yellowToken.transform.position == whiteToken.transform.position)
                    {
                        GiveTreasurePanelP1.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP1.SetActive(true);
                    }
                }
            }
            else if (turnScript.Player2Turn == true)
            {
                if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Explorer")
                {
                    if (greenToken.transform.position == blueToken.transform.position || greenToken.transform.position == blackToken.transform.position || greenToken.transform.position == redToken.transform.position || greenToken.transform.position == whiteToken.transform.position || greenToken.transform.position == yellowToken.transform.position)
                    {
                        GiveTreasurePanelP2.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP2.SetActive(true);
                    }
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Pilot")
                {
                    if (blueToken.transform.position == greenToken.transform.position || blueToken.transform.position == blackToken.transform.position || blueToken.transform.position == redToken.transform.position || blueToken.transform.position == whiteToken.transform.position || blueToken.transform.position == yellowToken.transform.position)
                    {
                        GiveTreasurePanelP2.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP2.SetActive(true);
                    }
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver")
                {
                    if (blackToken.transform.position == greenToken.transform.position || blackToken.transform.position == blueToken.transform.position || blackToken.transform.position == redToken.transform.position || blackToken.transform.position == whiteToken.transform.position || blackToken.transform.position == yellowToken.transform.position)
                    {
                        GiveTreasurePanelP2.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP2.SetActive(true);
                    }
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Engineer")
                {
                    if (redToken.transform.position == greenToken.transform.position || redToken.transform.position == blueToken.transform.position || redToken.transform.position == blackToken.transform.position || redToken.transform.position == whiteToken.transform.position || redToken.transform.position == yellowToken.transform.position)
                    {
                        GiveTreasurePanelP2.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP2.SetActive(true);
                    }
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Messenger")
                {
                    GiveTreasurePanelP1.SetActive(true);
                    GiveButtActive();
                }
                else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Navigator")
                {
                    if (yellowToken.transform.position == greenToken.transform.position || yellowToken.transform.position == blueToken.transform.position || yellowToken.transform.position == blackToken.transform.position || yellowToken.transform.position == redToken.transform.position || yellowToken.transform.position == whiteToken.transform.position)
                    {
                        GiveTreasurePanelP2.SetActive(true);
                        GiveButtActive();
                    }
                    else
                    {
                        NoGivingP2.SetActive(true);
                    }
                }
            }
        }
    }

    // checks if the action limit has been reached, if so, it goes to the end turn tasks immediately, if not, it goes back to the normal actions
    public void Done()
    {
        if (turnScript.Player1Turn == true)
        {
            if (turnScript.Player1 == 3)
            {
                turnScript.DrawTreasureP1.SetActive(true);
                turnScript.MoveP1.SetActive(false);
                turnScript.ShoreUpP1.SetActive(false);
                turnScript.GiveTreasureP1.SetActive(false);
                turnScript.CaptureTreasureP1.SetActive(false);
                turnScript.EndTasksP1.SetActive(false);
                setupScript.Player1Actions.SetActive(true);

                GiveTreasurePanelP1.SetActive(false);
                NoGivingP1.SetActive(false);
            }
            else
            {
                GiveTreasurePanelP1.SetActive(false);
                NoGivingP1.SetActive(false);
            }            

            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                script.TreasureCardInstances[i].GiveButt.SetActive(false);
            }
        }
        else if (turnScript.Player2Turn == true)
        {
            if (turnScript.Player2 == 3)
            {
                turnScript.DrawTreasureP2.SetActive(true);
                turnScript.MoveP2.SetActive(false);
                turnScript.ShoreUpP2.SetActive(false);
                turnScript.GiveTreasureP2.SetActive(false);
                turnScript.CaptureTreasureP2.SetActive(false);
                turnScript.EndTasksP2.SetActive(false);
                setupScript.Player2Actions.SetActive(true);

                GiveTreasurePanelP2.SetActive(false);
                NoGivingP2.SetActive(false);
            }
            else
            {
                GiveTreasurePanelP2.SetActive(false);
                NoGivingP2.SetActive(false);
            }

            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                script.TreasureCardInstances[i].GiveButt.SetActive(false);
            }
        }
    }

    // checks if a card is in the player hand, and if so, it enables the give button
    public void GiveButtActive()
    {
        if (turnScript.Player1Turn == true)
        {
            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.Player1TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                {
                    script.TreasureCardInstances[i].GiveButt.SetActive(true);
                }
            }
        }
        else if (turnScript.Player2Turn == true)
        {
            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.Player2TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                {
                    script.TreasureCardInstances[i].GiveButt.SetActive(true);
                }
            }
        }
    }

    // Removes the relevant card from the player hand and adds it to the other player's hand after checking whether the give boolean is true
    public void CardChangeHand()
    {
        if (turnScript.Player1Turn == true)
        {
            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.Player1TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                {
                    script.TreasureCardInstances[i].GiveButt.SetActive(true);
                }
            }

            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.TreasureCardInstances[i].Give == true)
                {
                    script.Player1TreasureCards.Remove(script.TreasureCardInstances[i].CardType);
                    script.Player2TreasureCards.Add(script.TreasureCardInstances[i].CardType);

                }
            }
        }
        else if (turnScript.Player2Turn == true)
        {
            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.Player2TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                {
                    script.TreasureCardInstances[i].GiveButt.SetActive(true);
                }
            }

            for (int i = 0; i < script.TreasureCardInstances.Count; i++)
            {
                if (script.TreasureCardInstances[i].Give == true)
                {
                    script.Player2TreasureCards.Remove(script.TreasureCardInstances[i].CardType);
                    script.Player1TreasureCards.Add(script.TreasureCardInstances[i].CardType);

                }
            }
        }
    }

    //Changes the give boolean to false
    public void GiveFalse()
    {
        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            script.TreasureCardInstances[i].Give = false;
            script.TreasureCardInstances[i].GiveButt.SetActive(false);
        }
    }

    // The following are booleans that when the give button is pressed, the boolean is enables and the above code
    // (CardsChangHands) can run

    public void Give1()
    {
        script.TreasureCardInstances[0].Give = true;
    }

    public void Give2()
    {
        script.TreasureCardInstances[1].Give = true;
    }

    public void Give3()
    {
        script.TreasureCardInstances[2].Give = true;
    }

    public void Give4()
    {
        script.TreasureCardInstances[3].Give = true;
    }

    public void Give5()
    {
        script.TreasureCardInstances[4].Give = true;
    }

    public void Give6()
    {
        script.TreasureCardInstances[5].Give = true;
    }

    public void Give7()
    {
        script.TreasureCardInstances[6].Give = true;
    }

    public void Give8()
    {
        script.TreasureCardInstances[7].Give = true;
    }

    public void Give9()
    {
        script.TreasureCardInstances[8].Give = true;
    }

    public void Give10()
    {
        script.TreasureCardInstances[9].Give = true;
    }

    public void Give11()
    {
        script.TreasureCardInstances[10].Give = true;
    }

    public void Give12()
    {
        script.TreasureCardInstances[11].Give = true;
    }

    public void Give13()
    {
        script.TreasureCardInstances[12].Give = true;
    }

    public void Give14()
    {
        script.TreasureCardInstances[13].Give = true;
    }

    public void Give15()
    {
        script.TreasureCardInstances[14].Give = true;
    }

    public void Give16()
    {
        script.TreasureCardInstances[15].Give = true;
    }

    public void Give17()
    {
        script.TreasureCardInstances[16].Give = true;
    }

    public void Give18()
    {
        script.TreasureCardInstances[17].Give = true;
    }

    public void Give19()
    {
        script.TreasureCardInstances[18].Give = true;
    }

    public void Give20()
    {
        script.TreasureCardInstances[19].Give = true;
    }

    public void Give21()
    {
        script.TreasureCardInstances[20].Give = true;
    }

    public void Give22()
    {
        script.TreasureCardInstances[21].Give = true;
    }

    public void Give23()
    {
        script.TreasureCardInstances[22].Give = true;
    }

    public void Give24()
    {
        script.TreasureCardInstances[23].Give = true;
    }

    public void Give25()
    {
        script.TreasureCardInstances[24].Give = true;
    }
}
