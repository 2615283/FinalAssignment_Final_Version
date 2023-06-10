using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurns : MonoBehaviour
{
    Setup setupScript;
    Positions positionScript;
    ObjectManager script;

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

    public GameObject WaterRise;

    private void Awake()
    {
        setupScript = GameObject.Find("GameCanvas").GetComponent<Setup>();
        positionScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
    }

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

    public void Player1TurnEndTasks()
    {
        MoveP1.SetActive(false);
        ShoreUpP1.SetActive(false);
        GiveTreasureP1.SetActive(false);
        CaptureTreasureP1.SetActive(false);
        EndTasksP1.SetActive(false);

        DrawTreasureP1.SetActive(true);
        DrawFloodP1.SetActive(true);
        DoneP1.SetActive(true);

        WaterRise.SetActive(true);
    }

    public void Player1Done()
    {
        MoveP1.SetActive(true);
        ShoreUpP1.SetActive(true);
        GiveTreasureP1.SetActive(true);
        CaptureTreasureP1.SetActive(true);
        EndTasksP1.SetActive(true);

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
        DrawFloodP2.SetActive(true);
        DoneP2.SetActive(true);

        WaterRise.SetActive(true);
    }

    public void Player2Done()
    {
        MoveP2.SetActive(true);
        ShoreUpP2.SetActive(true);
        GiveTreasureP2.SetActive(true);
        CaptureTreasureP2.SetActive(true);
        EndTasksP2.SetActive(true);

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

        Player1Turn = false;
        Player2Turn = true;
    }
}
