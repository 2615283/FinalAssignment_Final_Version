using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoreUp : MonoBehaviour
{
    ObjectManager script;
    PlayerTurns turnsScript;
    Setup setupScript;
    Positions posScript;
    TokenMovement moveScript;

    public GameObject ShoreUpPanelP1;
    public GameObject ShoreUpPanelP2;

    public GameObject redToken;
    public GameObject blackToken;
    public GameObject blueToken;
    public GameObject greenToken;
    public GameObject whiteToken;
    public GameObject yellowToken;

    public List<ShoreUpIndicator> IndicatorSU = new List<ShoreUpIndicator>();

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnsScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        posScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
        moveScript = GameObject.Find("GameCanvas").GetComponent<TokenMovement>();
    }

    private void Start()
    {
        ShoreUpPanelP1.SetActive(false);
        ShoreUpPanelP2.SetActive(false);

        for (int i = 0; i < script.TilesInstances.Count; i++)
        {
            GameObject Tile = script.TilesInstances[i].Tile;
            Tile.GetComponent<Button>().enabled = false;
        }
    }

    public void IndsMoveAway()
    {
        for (int i = 0; i < IndicatorSU.Count; i++)
        {
            GameObject Ind = IndicatorSU[i].Indicator;
            Ind.transform.position = new Vector3(0, 10, 0);
        }
    }

    public void positionOfIndsP1()
    {
        if (turnsScript.Player1Turn == true)
        {
            for (int i = 0; i < script.AdventurersInstances.Count; i++)
            {
                for (int j = 0; j < script.TilesInstances.Count; j++)
                {
                    if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Explorer" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                    {
                        if (greenToken.transform.position == posScript.pos17 || greenToken.transform.position == posScript.pos21 || greenToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == posScript.pos18 || greenToken.transform.position == posScript.pos22 || greenToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == posScript.pos15 || greenToken.transform.position == posScript.pos23 || greenToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == posScript.pos16 || greenToken.transform.position == posScript.pos24 || greenToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Pilot" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                    {
                        if (blueToken.transform.position == posScript.pos17 || blueToken.transform.position == posScript.pos21 || blueToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == posScript.pos18 || blueToken.transform.position == posScript.pos22 || blueToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == posScript.pos15 || blueToken.transform.position == posScript.pos23 || blueToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == posScript.pos16 || blueToken.transform.position == posScript.pos24 || blueToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                    {
                        if (blackToken.transform.position == posScript.pos17 || blackToken.transform.position == posScript.pos21 || blackToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == posScript.pos18 || blackToken.transform.position == posScript.pos22 || blackToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == posScript.pos15 || blackToken.transform.position == posScript.pos23 || blackToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == posScript.pos16 || blackToken.transform.position == posScript.pos24 || blackToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Engineer" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                    {
                        if (redToken.transform.position == posScript.pos17 || redToken.transform.position == posScript.pos21 || redToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == posScript.pos18 || redToken.transform.position == posScript.pos22 || redToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == posScript.pos15 || redToken.transform.position == posScript.pos23 || redToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == posScript.pos16 || redToken.transform.position == posScript.pos24 || redToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Messenger" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                    {
                        if (whiteToken.transform.position == posScript.pos17 || whiteToken.transform.position == posScript.pos21 || whiteToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == posScript.pos18 || whiteToken.transform.position == posScript.pos22 || whiteToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == posScript.pos15 || whiteToken.transform.position == posScript.pos23 || whiteToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == posScript.pos16 || whiteToken.transform.position == posScript.pos24 || whiteToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Navigator" && script.AdventurersInstances[i].Title.transform.position == posScript.player1Title.transform.position)
                    {
                        if (yellowToken.transform.position == posScript.pos17 || yellowToken.transform.position == posScript.pos21 || yellowToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == posScript.pos18 || yellowToken.transform.position == posScript.pos22 || yellowToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == posScript.pos15 || yellowToken.transform.position == posScript.pos23 || yellowToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == posScript.pos16 || yellowToken.transform.position == posScript.pos24 || yellowToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                }
            }
        }
    }

    public void positionOfIndsP2()
    {
        if (turnsScript.Player2Turn == true)
        {
            for (int i = 0; i < script.AdventurersInstances.Count; i++)
            {
                for (int j = 0; j < script.TilesInstances.Count; j++)
                {
                    if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Explorer" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                    {
                        if (greenToken.transform.position == posScript.pos17 || greenToken.transform.position == posScript.pos21 || greenToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == posScript.pos18 || greenToken.transform.position == posScript.pos22 || greenToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == posScript.pos15 || greenToken.transform.position == posScript.pos23 || greenToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (greenToken.transform.position == posScript.pos16 || greenToken.transform.position == posScript.pos24 || greenToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = greenToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = greenToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = greenToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = greenToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == greenToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = greenToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Pilot" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                    {
                        if (blueToken.transform.position == posScript.pos17 || blueToken.transform.position == posScript.pos21 || blueToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == posScript.pos18 || blueToken.transform.position == posScript.pos22 || blueToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == posScript.pos15 || blueToken.transform.position == posScript.pos23 || blueToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blueToken.transform.position == posScript.pos16 || blueToken.transform.position == posScript.pos24 || blueToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blueToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blueToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blueToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = blueToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blueToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = blueToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Diver" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                    {
                        if (blackToken.transform.position == posScript.pos17 || blackToken.transform.position == posScript.pos21 || blackToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == posScript.pos18 || blackToken.transform.position == posScript.pos22 || blackToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == posScript.pos15 || blackToken.transform.position == posScript.pos23 || blackToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (blackToken.transform.position == posScript.pos16 || blackToken.transform.position == posScript.pos24 || blackToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = blackToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = blackToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = blackToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = blackToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == blackToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = blackToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Engineer" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                    {
                        if (redToken.transform.position == posScript.pos17 || redToken.transform.position == posScript.pos21 || redToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == posScript.pos18 || redToken.transform.position == posScript.pos22 || redToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == posScript.pos15 || redToken.transform.position == posScript.pos23 || redToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (redToken.transform.position == posScript.pos16 || redToken.transform.position == posScript.pos24 || redToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = redToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = redToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = redToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = redToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == redToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = redToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Messenger" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                    {
                        if (whiteToken.transform.position == posScript.pos17 || whiteToken.transform.position == posScript.pos21 || whiteToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == posScript.pos18 || whiteToken.transform.position == posScript.pos22 || whiteToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == posScript.pos15 || whiteToken.transform.position == posScript.pos23 || whiteToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (whiteToken.transform.position == posScript.pos16 || whiteToken.transform.position == posScript.pos24 || whiteToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = whiteToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = whiteToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = whiteToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = whiteToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == whiteToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = whiteToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                    else if (script.AdventurersInstances[i].Active == true && script.AdventurersInstances[i].AdventurerType == "Navigator" && script.AdventurersInstances[i].Title.transform.position == posScript.player2Title.transform.position)
                    {
                        if (yellowToken.transform.position == posScript.pos17 || yellowToken.transform.position == posScript.pos21 || yellowToken.transform.position == posScript.pos13)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == posScript.pos18 || yellowToken.transform.position == posScript.pos22 || yellowToken.transform.position == posScript.pos14)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == posScript.pos15 || yellowToken.transform.position == posScript.pos23 || yellowToken.transform.position == posScript.pos19)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else if (yellowToken.transform.position == posScript.pos16 || yellowToken.transform.position == posScript.pos24 || yellowToken.transform.position == posScript.pos20)
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }

                            IndicatorSU[3].Indicator.transform.position = new Vector3(0, 10, 0);
                            IndicatorSU[4].Indicator.transform.position = new Vector3(0, 10, 0);
                        }
                        else
                        {
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[0].Indicator.transform.position = yellowToken.transform.position;
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[1].Indicator.transform.position = yellowToken.transform.position + new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position + new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[2].Indicator.transform.position = yellowToken.transform.position + new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(1.4f, 0, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[3].Indicator.transform.position = yellowToken.transform.position - new Vector3(1.4f, 0, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                            if (script.TilesInstances[j].Tile.transform.position == yellowToken.transform.position - new Vector3(0, 1.4f, 0) && script.TilesInstances[j].Tile.GetComponent<Image>().color == Color.cyan)
                            {
                                IndicatorSU[4].Indicator.transform.position = yellowToken.transform.position - new Vector3(0, 1.4f, 0);
                                script.TilesInstances[j].Tile.GetComponent<Button>().enabled = true;
                            }
                        }
                    }
                }
            }
        }
    }

    public void ShoreUpAction()
    {
        for (int i = 0; i < script.TilesInstances.Count; i++)
        {
            if (script.TilesInstances[i].Flooded == false && script.TilesInstances[i].Tile.GetComponent<Image>().color == Color.cyan)
            {
                script.TilesInstances[i].Tile.GetComponent<Image>().color = Color.white;
                script.Flooded.Remove(script.TilesInstances[i].Tile);
            }
        }

        if (turnsScript.Player1Turn == true)
        {
            turnsScript.Player1 += 1;
        }
        else if (turnsScript.Player2Turn == true)
        {
            turnsScript.Player2 += 1;
        }
    }

    public void ShoreUpP1Panel()
    {
        turnsScript.MoveP1.SetActive(false);
        turnsScript.ShoreUpP1.SetActive(false);
        turnsScript.GiveTreasureP1.SetActive(false);
        turnsScript.CaptureTreasureP1.SetActive(false);
        turnsScript.EndTasksP1.SetActive(false);

        ShoreUpPanelP1.SetActive(true);
    }

    public void ShoreUpDoneP1()
    {
        if (turnsScript.Player1 == 3)
        {
            turnsScript.MoveP1.SetActive(false);
            turnsScript.ShoreUpP1.SetActive(false);
            turnsScript.GiveTreasureP1.SetActive(false);
            turnsScript.CaptureTreasureP1.SetActive(false);
            turnsScript.EndTasksP1.SetActive(false);

            moveScript.P1DrawTreasureCards.SetActive(true);

            ShoreUpPanelP1.SetActive(false);
        }
        else
        {
            turnsScript.MoveP1.SetActive(true);
            turnsScript.ShoreUpP1.SetActive(true);
            turnsScript.GiveTreasureP1.SetActive(true);
            turnsScript.CaptureTreasureP1.SetActive(true);
            turnsScript.EndTasksP1.SetActive(true);

            ShoreUpPanelP1.SetActive(false);
        }        
    }

    public void ShoreUpP2Panel()
    {
        turnsScript.MoveP2.SetActive(false);
        turnsScript.ShoreUpP2.SetActive(false);
        turnsScript.GiveTreasureP2.SetActive(false);
        turnsScript.CaptureTreasureP2.SetActive(false);
        turnsScript.EndTasksP2.SetActive(false);

        ShoreUpPanelP2.SetActive(true);
    }

    public void ShoreUpDoneP2()
    {
        if (turnsScript.Player2 == 3)
        {
            turnsScript.MoveP2.SetActive(false);
            turnsScript.ShoreUpP2.SetActive(false);
            turnsScript.GiveTreasureP2.SetActive(false);
            turnsScript.CaptureTreasureP2.SetActive(false);
            turnsScript.EndTasksP2.SetActive(false);

            moveScript.P2DrawTreasureCards.SetActive(true);

            ShoreUpPanelP2.SetActive(false);
        }
        else
        {
            turnsScript.MoveP2.SetActive(true);
            turnsScript.ShoreUpP2.SetActive(true);
            turnsScript.GiveTreasureP2.SetActive(true);
            turnsScript.CaptureTreasureP2.SetActive(true);
            turnsScript.EndTasksP2.SetActive(true);

            ShoreUpPanelP1.SetActive(false);
        }
    }

    public void DisablingButtons()
    {
        for (int i = 0; i < script.TilesInstances.Count; i++)
        {
            GameObject Tile = script.TilesInstances[i].Tile;
            Tile.GetComponent<Button>().enabled = false;
        }

        for (int i = 0; i < IndicatorSU.Count; i++)
        {
            GameObject Ind = IndicatorSU[i].Indicator;
            Ind.transform.position = new Vector3(0, 10, 0);
        }
    }

    public void ShoreUp1()
    {
        script.TilesInstances[0].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp2()
    {
        script.TilesInstances[1].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp3()
    {
        script.TilesInstances[2].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp4()
    {
        script.TilesInstances[3].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp5()
    {
        script.TilesInstances[4].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp6()
    {
        script.TilesInstances[5].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp7()
    {
        script.TilesInstances[6].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp8()
    {
        script.TilesInstances[7].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp9()
    {
        script.TilesInstances[8].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp10()
    {
        script.TilesInstances[9].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp11()
    {
        script.TilesInstances[10].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp12()
    {
        script.TilesInstances[11].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp13()
    {
        script.TilesInstances[12].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp14()
    {
        script.TilesInstances[13].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp15()
    {
        script.TilesInstances[14].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp16()
    {
        script.TilesInstances[15].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp17()
    {
        script.TilesInstances[16].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp18()
    {
        script.TilesInstances[17].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp19()
    {
        script.TilesInstances[18].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp20()
    {
        script.TilesInstances[19].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp21()
    {
        script.TilesInstances[20].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp22()
    {
        script.TilesInstances[21].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp23()
    {
        script.TilesInstances[22].Flooded = false;

        ShoreUpAction();
    }

    public void ShoreUp24()
    {
        script.TilesInstances[23].Flooded = false;

        ShoreUpAction();
    }

    [System.Serializable]
    public class ShoreUpIndicator
    {
        public GameObject Indicator;

    }
}
