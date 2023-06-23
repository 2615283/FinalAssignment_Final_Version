using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineerScript : MonoBehaviour
{
    ObjectManager script;
    PlayerTurns turnsScript;
    Positions posScript;

    public int Engineer;

    private void Awake()
    {
        script = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
        turnsScript = GameObject.Find("GameCanvas").GetComponent<PlayerTurns>();
        posScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
    }

    // The Engineer can Shore up 2 tiles on one turn.
    // The turns are tracked by an integer.
    // This function was added to the Shore Up Another button.
    public void EngineerActionNums()
    {
        if (turnsScript.Player1Turn == true)
        {
            if (script.AdventurersInstances[2].Active == true && script.AdventurersInstances[2].AdventurerType == "Engineer" && script.AdventurersInstances[2].Title.transform.position == posScript.FirstTitle.transform.position)
            {
                // This integer indicates the engineer has pressed the shore up another button
                Engineer += 1;

                if (Engineer == 1)
                {
                    // If the engineer has onky pressed it once, it removes a number from the action indicator
                    turnsScript.Player1 -= 1;
                }        
                else if (Engineer > 1)
                {

                }
            }
        }
        else if (turnsScript.Player2Turn == true)
        {
            if (script.AdventurersInstances[2].Active == true && script.AdventurersInstances[2].AdventurerType == "Engineer" && script.AdventurersInstances[2].Title.transform.position == posScript.SecondTitle.transform.position)
            {
                if (Engineer == 1)
                {
                    turnsScript.Player1 -= 1;
                }
                else if (Engineer > 1)
                {

                }
            }
        }
    }

    // This function is added to the done button to revert the Engineer integer back to zero to start again the next time the engineer shores up a tile
    public void Done()
    {
        Engineer = 0;
    }
}
