using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public string character;
    public string cardName;
    public string description;
    public int cardId;
    public int grade;
    public int level;
    public Sprite profileImage;
}

[CreateAssetMenu(fileName = "CardSO", menuName = "ScriptableObject/CardSO")]
public class CardSO : ScriptableObject
{
    public Card[] cards;
}
