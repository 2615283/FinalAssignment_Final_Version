using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCardDiscard : MonoBehaviour
{
    ObjectManager script;
    PlayerTurns turnScript;

    public GameObject DiscardPanelP1;
    public GameObject DiscardPanelP2;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
    }

    // Disables the Discard buttons
    private void Start()
    {
        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            script.TreasureCardInstances[i].DiscardButt.SetActive(false);
        }
    }

    // Update function checks if the Discard Pile contains a certain card and then disables the discard button
    // Also checks if the treasure cards run out. If the Treasure cards count reaches 1 or less, the cards in the discard pile goes back into the card pile
    private void Update()
    {   
        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            if (script.TreasureCardsDiscard.Contains(script.TreasureCardInstances[i].CardType))
            {
                script.TreasureCardInstances[i].Discard = false;
            }
        }

        if (script.TreasureCardsObjects.Count <= 1)
        {
            for (int i = 0; i < script.TreasureCardsDiscard.Count; i++)
            {
                script.TreasureCardsObjects.Add(script.TreasureCardsDiscard[i]);
                script.TreasureCardsDiscard.Remove(script.TreasureCardsDiscard[i]);
            }
        }
    }

    // Checks if the hand amount has exceeded its limit when treasure cards are drawn. If it has exceeded 5, the dic=scard panel and buttons are
    // enabled
    public void DiscardStuff()
    {
        if (turnScript.Player1Turn == true)
        {
            if (script.Player1TreasureCards.Count > 5)
            {
                DiscardPanelP1.SetActive(true);

                for (int i = 0; i < script.TreasureCardInstances.Count; i++)
                {
                    if (script.Player1TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                    {
                        script.TreasureCardInstances[i].DiscardButt.SetActive(true);
                
                    }                    
                }
            }
            else if (script.Player1TreasureCards.Count <= 5)
            {
                DiscardPanelP1.SetActive(false);

                for (int i = 0; i < script.TreasureCardInstances.Count; i++)
                {
                    if (script.Player1TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                    {
                        script.TreasureCardInstances[i].DiscardButt.SetActive(false);

                    }
                }

            }
        }
        else if (turnScript.Player2Turn == true)
        {
            if (script.Player2TreasureCards.Count > 5)
            {
                DiscardPanelP2.SetActive(true);

                for (int i = 0; i < script.TreasureCardInstances.Count; i++)
                {
                    if (script.Player2TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                    {
                        script.TreasureCardInstances[i].DiscardButt.SetActive(true);

                    }
                }
            }
            else if (script.Player2TreasureCards.Count <= 5)
            {
                DiscardPanelP2.SetActive(false);

                for (int i = 0; i < script.TreasureCardInstances.Count; i++)
                {
                    if (script.Player2TreasureCards.Contains(script.TreasureCardInstances[i].CardType))
                    {
                        script.TreasureCardInstances[i].DiscardButt.SetActive(false);

                    }
                }
            }
        }
    }

    // checks player turn, and if the discard button is pressed, the discard boolean is enabled and the card is added to the 
    // discard pile, and removed from the player hand. The cards in the player hand then moves accordingly.
    public void DiscardCard()
    {
        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            if (turnScript.Player1Turn == true)
            {
                if (script.TreasureCardInstances[i].Discard == true)
                {
                    script.Player1TreasureCards.Remove(script.TreasureCardInstances[i].CardType);
                    script.TreasureCardsDiscard.Add(script.TreasureCardInstances[i].CardType);
                    script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                }
            }
        }

        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            if (turnScript.Player2Turn == true)
            {
                if (script.TreasureCardInstances[i].Discard == true)
                {
                    script.Player2TreasureCards.Remove(script.TreasureCardInstances[i].CardType);
                    script.TreasureCardsDiscard.Add(script.TreasureCardInstances[i].CardType);
                    script.TreasureCardInstances[i].CardType.transform.position = new Vector3(20, 0, 0);
                }
            }
        }        
    }

    // Changes all the Discard booleans to false
    public void DiscardFalse()
    {
        for (int i = 0; i < script.TreasureCardInstances.Count; i++)
        {
            script.TreasureCardInstances[i].Discard = false;
        }
    }

    // The following is the discard Booleans. when the Discard button is pressed, the boolean is set to true, an the above code (DiscardCard)
    // can run

    public void Discard1()
    {
        script.TreasureCardInstances[0].Discard = true;
    }

    public void Discard2()
    {
        script.TreasureCardInstances[1].Discard = true;
    }

    public void Discard3()
    {
        script.TreasureCardInstances[2].Discard = true;
    }

    public void Discard4()
    {
        script.TreasureCardInstances[3].Discard = true;
    }

    public void Discard5()
    {
        script.TreasureCardInstances[4].Discard = true;
    }

    public void Discard6()
    {
        script.TreasureCardInstances[5].Discard = true;
    }

    public void Discard7()
    {
        script.TreasureCardInstances[6].Discard = true;
    }

    public void Discard8()
    {
        script.TreasureCardInstances[7].Discard = true;
    }

    public void Discard9()
    {
        script.TreasureCardInstances[8].Discard = true;
    }

    public void Discard10()
    {
        script.TreasureCardInstances[9].Discard = true;
    }

    public void Discard11()
    {
        script.TreasureCardInstances[10].Discard = true;
    }

    public void Discard12()
    {
        script.TreasureCardInstances[11].Discard = true;
    }

    public void Discard13()
    {
        script.TreasureCardInstances[12].Discard = true;
    }

    public void Discard14()
    {
        script.TreasureCardInstances[13].Discard = true;
    }

    public void Discard15()
    {
        script.TreasureCardInstances[14].Discard = true;
    }

    public void Discard16()
    {
        script.TreasureCardInstances[15].Discard = true;
    }

    public void Discard17()
    {
        script.TreasureCardInstances[16].Discard = true;
    }

    public void Discard18()
    {
        script.TreasureCardInstances[17].Discard = true;
    }

    public void Discard19()
    {
        script.TreasureCardInstances[18].Discard = true;
    }

    public void Discard20()
    {
        script.TreasureCardInstances[19].Discard = true;
    }

    public void Discard21()
    {
        script.TreasureCardInstances[20].Discard = true;
    }

    public void Discard22()
    {
        script.TreasureCardInstances[21].Discard = true;
    }

    public void Discard23()
    {
        script.TreasureCardInstances[22].Discard = true;
    }

    public void Discard24()
    {
        script.TreasureCardInstances[23].Discard = true;
    }

    public void Discard25()
    {
        script.TreasureCardInstances[24].Discard = true;
    }
}
