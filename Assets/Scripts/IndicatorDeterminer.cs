using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndicatorDeterminer : MonoBehaviour
{
    Positions positionScript;
    ObjectManager script;

    private void Awake()
    {
        positionScript = GameObject.Find("GameCanvas").GetComponent<Positions>();
        script  = GameObject.Find("GameCanvas").GetComponent<ObjectManager>();
    }

    public void indDisable()
    {
        for (int i = 0; i < positionScript.Indicator.Count; i++)
        {
            GameObject Indicator = positionScript.Indicator[i].IndicatorObject;
            Indicator.GetComponent<Button>().enabled = false;
        }
    }

    public void indEnable()
    {
        for (int i = 0; i < positionScript.Indicator.Count; i++)
        {
            GameObject Indicator = positionScript.Indicator[i].IndicatorObject;
            Indicator.GetComponent<Button>().enabled = true;
        }
    }

    public void IndFin()
    {
        for (int i = 0; i < positionScript.Indicator.Count; i++)
        {
            positionScript.Indicator[i].click = false;
        }
    }

    public void Ind1()
    {
        positionScript.Indicator[0].click = true;
    }

    public void Ind2()
    {
        positionScript.Indicator[1].click = true;
    }

    public void Ind3()
    {
        positionScript.Indicator[2].click = true;
    }
    public void Ind4()
    {
        positionScript.Indicator[3].click = true;
    }

    public void Ind5()
    {
        positionScript.Indicator[4].click = true;
    }

    public void Ind6()
    {
        positionScript.Indicator[5].click = true;
    }

    public void Ind7()
    {
        positionScript.Indicator[6].click = true;
    }

    public void Ind8()
    {
        positionScript.Indicator[7].click = true;
    }

    public void Ind9()
    {
        positionScript.Indicator[8].click = true;
    }

    public void Ind10()
    {
        positionScript.Indicator[9].click = true;
    }

    public void Ind11()
    {
        positionScript.Indicator[10].click = true;
    }

    public void Ind12()
    {
        positionScript.Indicator[11].click = true;
    }

    public void Ind13()
    {
        positionScript.Indicator[12].click = true;
    }

    public void Ind14()
    {
        positionScript.Indicator[13].click = true;
    }

    public void Ind15()
    {
        positionScript.Indicator[14].click = true;
    }

    public void Ind16()
    {
        positionScript.Indicator[15].click = true;
    }

    public void Ind17()
    {
        positionScript.Indicator[16].click = true;
    }

    public void Ind18()
    {
        positionScript.Indicator[17].click = true;
    }

    public void Ind19()
    {
        positionScript.Indicator[18].click = true;
    }

    public void Ind20()
    {
        positionScript.Indicator[19].click = true;
    }

    public void Ind21()
    {
        positionScript.Indicator[20].click = true;
    }

    public void Ind22()
    {
        positionScript.Indicator[21].click = true;
    }

    public void Ind23()
    {
        positionScript.Indicator[22].click = true;
    }

    public void Ind24()
    {
        positionScript.Indicator[23].click = true;
    }
}
