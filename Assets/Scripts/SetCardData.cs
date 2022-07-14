using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCardData : MonoBehaviour
{
    public CardManager cardManager;

    public GameObject profile;
    public GameObject characterName;
    public GameObject explain;


    public void ApplyCardData(int order, CardSO card)
    {
        cardManager.cardLockList[order] += 1;

        profile.GetComponent<SpriteRenderer>().sprite = card.profileImage;
        characterName.GetComponent<SpriteRenderer>().sprite = card.nameImage;
        explain.GetComponent<SpriteRenderer>().sprite = card.explainImage;

        Debug.Log(card.name + " " + cardManager.cardLockList[order] + "개 중복");
    }

    public void ShowArrayCard(int order, CardSO card)
    {
        cardManager.cardLockList[order] += 1;

        profile.GetComponent<SpriteRenderer>().sprite = card.profileImage;
        characterName.GetComponent<SpriteRenderer>().sprite = card.nameImage;
        explain.GetComponent<SpriteRenderer>().sprite = card.explainImage;

        Debug.Log(card.name + " " + cardManager.cardLockList[order] + "개 중복");
    }
}
