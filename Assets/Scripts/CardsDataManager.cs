using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DTOs;
using Inventory.Cards;
using UnityEngine;
using Utils;

public class CardsDataManager : MonoBehaviour
{
    private void Start()
    {
        // Seteo el path del archivo JSON
        var _localPath = Application.dataPath + "/StreamingAssets/card.json";
        
        // Leo el archivo 
        var data = File.ReadAllText(_localPath);
        
        // Parseo el archivo JSON a CardDTO
        var parsedCards = ParseCardJson(data);
        
        SetCardValue(parsedCards);

        //LoadCardsData();
    }

    // Seteamos el listado de valores que traemos del JSON a los ScriptablesObjects
    private void SetCardValue(List<CardDTO> cardsList)
    {
        foreach (var card in cardsList)
        {
            var newCard = Resources.Load<GeneralCardScript>("Cards Headers/" + card.cardName);
            if (newCard != null)
            {
                newCard.rarity = (Rarity) Enum.Parse(typeof(Rarity), card.rarity);
                newCard.category = (Category) Enum.Parse(typeof(Category), card.category);
                newCard.sprite = Resources.Load<Sprite>("Cards Assets/" + card.sprite);
                Debug.Log($"{newCard.cardName} RARITY: {newCard.rarity} CATEGORY: {newCard.category}");
            }
        }
    }

    private List<CardDTO> ParseCardJson(string json)
    {
        string parsed = JsonHelper.FixJson(json);
        return JsonHelper.FromJson<CardDTO>(parsed).ToList();
    }
}