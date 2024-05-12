using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VInspector;
using TMPro;

using UnityEngine.UI;

public class Card : MonoBehaviour
{
    #region References & Variables
    [SerializeField] private TMP_Text cardNameUI;
    [SerializeField] private TMP_Text cardTextUI;
    [SerializeField] private TMP_Text cardCostUI;

    [SerializeField] private string cardName;
    [SerializeField] private string cardText;
    [SerializeField] private int cardCost;

    CardState cardState;

    enum CardState
    {
        Playable, Display
    }

    #endregion

    private void Start()
    {
        cardNameUI.text = cardName;
        cardTextUI.text = cardText;
        cardCostUI.text = cardCost.ToString();
    }

    protected virtual void CardEffect()
    {
        // functionality of card
        // sfx
    }

    private void CardDraw()
    {
        // movement from deck to hand
        // sfx
    }

    private void CardSelected() // on click
    {
        // target targeting if required
        // sfx
    }

    private void CardHovered()
    {

    }
}
