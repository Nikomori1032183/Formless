using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VInspector;
using TMPro;

using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] private TMP_Text cardNameUI;
    [SerializeField] private TMP_Text cardTextUI;
    [SerializeField] private TMP_Text cardCostUI;

    [SerializeField] private string cardName;
    [SerializeField] private string cardText;
    [SerializeField] private int cardCost;

    private void Start()
    {
        cardNameUI.text = cardName;
        cardTextUI.text = cardText;
        cardCostUI.text = cardCost.ToString();
    }

    protected virtual void CardEffect()
    {

    }
}
