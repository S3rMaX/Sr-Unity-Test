using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DTOs;
using Inventory.Cards;
using UnityEngine;
using UnityEngine.UI;
using Utils;

public class CardsDataManager : MonoBehaviour
{
    [Header("Bird Properties")]
    [SerializeField]
    public List<GameObject> inventoryItems;

    [SerializeField] public GameObject inventoryItemPrefab;
    [SerializeField] public GameObject inventoryContainer;
    
    private void Start()
    {
        // I set the JSON file path
        var localPath = Application.dataPath + "/StreamingAssets/cards.json";
        // I read the file
        var data = File.ReadAllText(localPath);
        // Parse the JSON file to CardDTO
        var parsedCards = ParseCardJson(data);
        
        SetCardValue(parsedCards);

        //LoadCardsData();
    }

    // We set the list of values that we bring from the JSON to the ScriptablesObjects
    private void SetCardValue(List<CardDTO> cardsList)
    {
        foreach (var card in cardsList)
        {
            var newCard = Resources.Load<GeneralCardScript>("Cards Headers/" + card.cardName);
            newCard.sprite = Resources.Load<Sprite>("Cards Assets/" + card.sprite);
            if (newCard != null)
            {
                newCard.level = card.level;
                newCard.rarity = (Rarity)Enum.Parse(typeof(Rarity), card.rarity);
                newCard.sprite = Resources.Load<Sprite>("Cards Assets/" + card.sprite);
                
                Debug.Log($"{newCard.cardName} LEVEL: {newCard.level} RARITY: {newCard.rarity} SPRITE: {newCard.sprite}");
                
                // Instantiate InventoryItem prefab and set card data
                var inventoryItem = Instantiate(inventoryItemPrefab, inventoryContainer.transform);
                inventoryItem.GetComponentInChildren<Image>().sprite = newCard.sprite;
                inventoryItem.GetComponentInChildren<Text>().text = newCard.cardName;
            }
        }
    }

    private List<CardDTO> ParseCardJson(string json)
    {
        string parsed = JsonHelper.FixJson(json);
        return JsonHelper.FromJson<CardDTO>(parsed).ToList();
    }
}