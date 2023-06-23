using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurns : MonoBehaviour
{
    Setup setupScript;
    Positions positionScript;
    ObjectManager script;
    TokenMovement movementScript;
    ShoreUp shoreScript;


    // Many, many objects. This was me making a lot of work for myself.
    public GameObject MoveP1;
    public GameObject ShoreUpP1;
    public GameObject GiveTreasureP1;
    public GameObject CaptureTreasureP1;
    public GameObject EndTasksP1;
    public GameObject DoneP1;

    public GameObject DrawTreasureP1;
    public GameObject DrawFloodP1;

    public GameObject MoveP2;
    public GameObject ShoreUpP2;
    public GameObject GiveTreasureP2;
    public GameObject CaptureTreasureP2;
    public GameObject EndTasksP2;
    public GameObject DoneP2;

    public GameObject DrawTreasureP2;
    public GameObject DrawFloodP2;

    public bool Player1Turn;
    public bool Player2Turn;

    public int Player1;
    public int Player2;

    public GameObject WaterRise;

    public GameObject MoveAgain1;
    public GameObject MoveAgain2;

    public GameObject ShoreUpAgain1;
    public GameObject ShoreUpAgain2;

    private void Awake()
    {
        setupScript = GameObject.Find("GameCanvas").GetComponent<Setup>();
        positionScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        movementScript = GameObject.Find("GameCanvas").GetComponent<TokenMovement>();
        shoreScript = GameObject.Find("GameCanvas").GetComponent<ShoreUp>();
    }


    // Start function Enables and Disables relevant objects
    private void Start()
    {
        MoveP1.SetActive(true);
        ShoreUpP1.SetActive(true);
        GiveTreasureP1.SetActive(true);
        CaptureTreasureP1.SetActive(true);
        EndTasksP1.SetActive(true);

        DrawTreasureP1.SetActive(false);
        DrawFloodP1.SetActive(false);
        DoneP1.SetActive(false);

        MoveP2.SetActive(true);
        ShoreUpP2.SetActive(true);
        GiveTreasureP2.SetActive(true);
        CaptureTreasureP2.SetActive(true);
        EndTasksP2.SetActive(true);

        DrawTreasureP2.SetActive(false);
        DrawFloodP2.SetActive(false);
        DoneP2.SetActive(false);

        WaterRise.SetActive(false);
    }

    // This Update function tracks the player actions, and disables the ability to do an action again, if the action limit is reached
    private void Update()
    {
        if (Player1 == 3)
        {
            MoveAgain1.SetActive(false);
            ShoreUpAgain1.SetActive(false);
        }
        else if (Player2 == 3)
        {
            MoveAgain2.SetActive(false);
            ShoreUpAgain2.SetActive(false);
        }
    }

    // End of turn tasks. Just disables the actions and enables the tasks
    public void Player1TurnEndTasks()
    {
        MoveP1.SetActive(false);
        ShoreUpP1.SetActive(false);
        GiveTreasureP1.SetActive(false);
        CaptureTreasureP1.SetActive(false);
        EndTasksP1.SetActive(false);

        DrawTreasureP1.SetActive(true);
    }

    //Disables the First task and then enables the next one
    public void Player1TreasureCard()
    {
        DrawFloodP1.SetActive(true);
        WaterRise.SetActive(true);
    }

    //Enables the Done button
    public void Player1FloodCard()
    {
        DoneP1.SetActive(true);
    }

    // Reverts All the UI back to whatit was before the turn started
    public void Player1Done()
    {
        TurnRevert();

        MoveP1.SetActive(true);
        ShoreUpP1.SetActive(true);
        GiveTreasureP1.SetActive(true);
        CaptureTreasureP1.SetActive(true);
        EndTasksP1.SetActive(true);
        MoveAgain1.SetActive(true);
        ShoreUpAgain1.SetActive(true);

        DrawTreasureP1.SetActive(false);
        DrawFloodP1.SetActive(false);
        DoneP1.SetActive(false);

        setupScript.Player1.SetActive(false);
        setupScript.Player1Actions.SetActive(false);
        setupScript.Player2.SetActive(true);
        setupScript.Player2Actions.SetActive(true);

        positionScript.FirstTitle.SetActive(false);
        positionScript.SecondTitle.SetActive(true);

        WaterRise.SetActive(false);

        Player1Turn = false;
        Player2Turn = true;
    }

    public void Player2TurnEndTasks()
    {
        MoveP2.SetActive(false);
        ShoreUpP2.SetActive(false);
        GiveTreasureP2.SetActive(false);
        CaptureTreasureP2.SetActive(false);
        EndTasksP2.SetActive(false);

        DrawTreasureP2.SetActive(true);
    }

    public void Player2TreasureCard()
    {
        DrawFloodP2.SetActive(true);
        WaterRise.SetActive(true);
    }

    public void Player2FloodCard()
    {
        DoneP2.SetActive(true);
    }

    public void Player2Done()
    {
        TurnRevert();

        MoveP2.SetActive(true);
        ShoreUpP2.SetActive(true);
        GiveTreasureP2.SetActive(true);
        CaptureTreasureP2.SetActive(true);
        EndTasksP2.SetActive(true);
        MoveAgain2.SetActive(true);
        ShoreUpAgain2.SetActive(true);

        DrawTreasureP2.SetActive(false);
        DrawFloodP2.SetActive(false);
        DoneP2.SetActive(false);

        setupScript.Player2.SetActive(false);
        setupScript.Player2Actions.SetActive(false);
        setupScript.Player1.SetActive(true);
        setupScript.Player1Actions.SetActive(true);

        positionScript.FirstTitle.SetActive(true);
        positionScript.SecondTitle.SetActive(false);

        WaterRise.SetActive(false);

        Player1Turn = true;
        Player2Turn = false;
    }

    // This function is put on a button so when it is pressed the turns are added to.
    public void TurnsIndicator()
    {
        if (Player1Turn == true)
        {
            Player1 += 1;
        }
        else if (Player2Turn == true)
        {
            Player2 += 1;
        }
    }

    //Reverts all the Actions back to zero
    public void TurnRevert()
    {
        if (Player1Turn == true)
        {
            Player1 = 0;
        }
        else if (Player2Turn == true)
        {
            Player2 = 0;
        }
    }
}
