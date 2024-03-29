using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// All zee objects. All them. 
public class ObjectManager : MonoBehaviour
{
    // Spaces in the Player panels, that function as a hand
    public GameObject Space1P1;
    public GameObject Space2P1;
    public GameObject Space3P1;
    public GameObject Space4P1;
    public GameObject Space5P1;
    public GameObject Space6P1;
    public GameObject Space7P1;
    public GameObject Space8P1;

    public GameObject Space1P2;
    public GameObject Space2P2;
    public GameObject Space3P2;
    public GameObject Space4P2;
    public GameObject Space5P2;
    public GameObject Space6P2;
    public GameObject Space7P2;
    public GameObject Space8P2;

    // All the original objects in their lists.
    // This makes use of the classes below so you can add an instance in the inspector in unity.
    [SerializeField] public List<Tiles> TilesInstances = new List<Tiles>();
    [SerializeField] public List<Adventurers> AdventurersInstances = new List<Adventurers>();
    [SerializeField] public List<TreasureCards> TreasureCardInstances = new List<TreasureCards>();
    [SerializeField] public List<TreasureCards> WaterRiseInstances = new List<TreasureCards>();


    // The lists that the objects of above mentioned gets passed around in.
    public List<GameObject> TilesObjects = new List<GameObject>();
    public List<GameObject> Flooded = new List<GameObject>();
    public List<GameObject> Sunk = new List<GameObject>();
    public List<GameObject> TreasureCardsObjects = new List<GameObject>();
    public List<GameObject> TreasureCardsDiscard = new List<GameObject>();
    public List<GameObject> WaterRiseObjects = new List<GameObject>();
    public List<GameObject> AdventurerCardsObjects = new List<GameObject>();
    public List<GameObject> FloodCards = new List<GameObject>();
    public List<GameObject> FloodCardsDiscard = new List<GameObject>();

    // Player hand
    public List<GameObject> Player1TreasureCards = new List<GameObject>();
    public List<GameObject> Player2TreasureCards = new List<GameObject>();

    // Player hand that make sit possible to see what is in player hand
    public List<GameObject> Player1TreasureCardsSpaces = new List<GameObject>();
    public List<GameObject> Player2TreasureCardsSpaces = new List<GameObject>();

    // Everything in the start function is just some UI stuff
    // It makes the text on the cards say what they have to, and they add the objects to the different piles in the game
    private void Start()
    {
        for (int i = 0; i < TilesInstances.Count; i++)
        {
            TilesInstances[i].TileNameText.text = TilesInstances[i].TileName;
        }

        for (int i = 0; i < TilesInstances.Count; i++)
        {
            TilesObjects.Add(TilesInstances[i].Tile);
        }

        for (int i = 0; i < TilesInstances.Count; i++)
        {
            FloodCards.Add(TilesInstances[i].Tile);
        }

        for (int i = 0; i < AdventurersInstances.Count; i++)
        {
            AdventurersInstances[i].TypeText.text = AdventurersInstances[i].AdventurerType;
        }

        for (int i = 0; i < AdventurersInstances.Count; i++)
        {
            AdventurerCardsObjects.Add(AdventurersInstances[i].Title);
        }

        for (int i = 0; i < TreasureCardInstances.Count; i++)
        {
            TreasureCardInstances[i].CardTypeText.text = TreasureCardInstances[i].TreasureCardType;
        }

        for (int i = 0; i < TreasureCardInstances.Count; i++)
        {
            TreasureCardsObjects.Add(TreasureCardInstances[i].CardType);
        }

        for (int i = 0; i < WaterRiseInstances.Count; i++)
        {
            WaterRiseInstances[i].CardTypeText.text = WaterRiseInstances[i].TreasureCardType;
        }

        for (int i = 0; i < WaterRiseInstances.Count; i++)
        {
            WaterRiseObjects.Add(WaterRiseInstances[i].CardType);
        }

        Player1TreasureCardsSpaces.Add(Space1P1);
        Player1TreasureCardsSpaces.Add(Space2P1);
        Player1TreasureCardsSpaces.Add(Space3P1);
        Player1TreasureCardsSpaces.Add(Space4P1);
        Player1TreasureCardsSpaces.Add(Space5P1);
        Player1TreasureCardsSpaces.Add(Space6P1);
        Player1TreasureCardsSpaces.Add(Space7P1);
        Player1TreasureCardsSpaces.Add(Space8P1);

        Player2TreasureCardsSpaces.Add(Space1P2);
        Player2TreasureCardsSpaces.Add(Space2P2);
        Player2TreasureCardsSpaces.Add(Space3P2);
        Player2TreasureCardsSpaces.Add(Space4P2);
        Player2TreasureCardsSpaces.Add(Space5P2);
        Player2TreasureCardsSpaces.Add(Space6P2);
        Player2TreasureCardsSpaces.Add(Space7P2);
        Player2TreasureCardsSpaces.Add(Space8P2);
    }

    // Update function just updates the position of the tiles in the game so you can see where they are
    private void Update()
    {
        for (int i = 0; i < TilesInstances.Count; i++)
        {
            TilesInstances[i].pos = TilesInstances[i].Tile.transform.position;
        }

    }


    // I present the classes 
    [System.Serializable]
    public class Tiles
    {
        [Header("Tile Identifiers")]
        public string TileName;
        public TextMeshProUGUI TileNameText;
        public GameObject Tile;
        public Vector3 pos;

        [Header("Tile State")]
        public bool Flooded;

        [Header("StartingTile?")]
        public bool Yellow;
        public bool Red;
        public bool Blue;
        public bool Black;
        public bool Green;
        public bool White;

        [Header("Treasure Tile?")]
        public bool EarthStone;
        public bool WindStatue;
        public bool FireCrystal;
        public bool OceanChalice;
    }

    [System.Serializable]
    public class Adventurers
    {
        public string AdventurerType;
        public TextMeshProUGUI TypeText;
        public GameObject Title;
        public bool Active;

        public bool Player1;
        public bool Player2;

        public bool Yellow;
        public bool Red;
        public bool Blue;
        public bool Black;
        public bool Green;
        public bool White;

        public GameObject Token;
    }

    [System.Serializable]
    public class TreasureCards
    {
        public string TreasureCardType;
        public TextMeshProUGUI CardTypeText;
        public GameObject CardType;
        public GameObject DiscardButt;
        public GameObject GiveButt;
        public GameObject UseButt;

        public bool Discard;
        public bool Give;
        public bool Use;

        public bool OceansChalice;
        public bool WindStatue;
        public bool FireCrystal;
        public bool EarthStone;

        public bool WaterRise;

        public bool HelicopterLift;

        public bool Sadbag;
    }

}
