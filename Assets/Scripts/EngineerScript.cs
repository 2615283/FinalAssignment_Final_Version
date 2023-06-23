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

    public void EngineerActionNums()
    {
        Engineer += 1;

        if (turnsScript.Player1Turn == true)
        {
            if (script.AdventurersInstances[2].Active == true && script.AdventurersInstances[2].AdventurerType == "Engineer" && script.AdventurersInstances[2].Title.transform.position == posScript.FirstTitle.transform.position)
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

    public void Done()
    {
        Engineer = 0;
    }
}
