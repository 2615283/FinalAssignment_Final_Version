using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasures : MonoBehaviour
{
    public GameObject OceansChalice;
    public GameObject CrystalOfFire;
    public GameObject StatueOfTheWind;
    public GameObject EarthStone;

    public void TreasureInitial()
    {
        OceansChalice.transform.position = new Vector3(-4, 3, 0);
        CrystalOfFire.transform.position = new Vector3(4, 3, 0);
        StatueOfTheWind.transform.position = new Vector3(-4, -3, 0);
        EarthStone.transform.position = new Vector3(4, -3, 0);
    }
}
