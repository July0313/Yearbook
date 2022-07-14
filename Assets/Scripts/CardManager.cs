using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardManager : MonoBehaviour
{
    public SetCardData setCardData;

    public CardSO card;
    public CardSO[] cardList;
    public GameObject[] memories;
    public GameObject[] locks;
    public List<int> cardLockList;
    public List<int> percentList;
    public int totalNum;

    public GameObject cardCover;

    [SerializeField] private int randomNum;

    public Button cardSelectBtn;
    public Text coinWarningTxt;
    public Text coinTxt;

    private void Start()
    {
        setCardData = GetComponentInChildren<SetCardData>();

        for (int i = 0; i < cardList.Length; i++)
        {
            cardLockList.Add(0);
            totalNum += cardList[i].percent;
        }

        Debug.Log(DataManager.instance.coin);
        coinTxt.text = "Coin : " + DataManager.instance.coin;

        for (int i = 0; i < DataManager.instance.cardMemories.Count; i++)
        {
            memories[DataManager.instance.unlockedNums[i]].GetComponent<SetCardData>().ApplyCardData(i, DataManager.instance.cardMemories[i]);
            locks[DataManager.instance.unlockedNums[i]].SetActive(false);
        }
    }

    public void SelectItem()
    {
        if (DataManager.instance.coin < 500)
        {
            cardCover.SetActive(true);
            coinWarningTxt.text = "코인이 부족합니다";
            return;
        }

        if (cardCover.activeSelf)
        {
            cardCover.SetActive(false);
        }

        randomNum = Random.Range(0, totalNum);

        for (int i = 0; i < cardList.Length; i++)
        {
            if (CalculatePercent(i))
            {
                card = cardList[i];
                setCardData.ApplyCardData(i, card);
                memories[i].GetComponent<SetCardData>().ApplyCardData(i, card);
                DataManager.instance.cardMemories.Add(cardList[i]);
                DataManager.instance.unlockedNums.Add(i);
                locks[i].SetActive(false);
                coinWarningTxt.text = " ";
                DataManager.instance.coin -= 500;
                coinTxt.text = "Coin : " + DataManager.instance.coin;

                break;
            }
        }
    }

    public void MoveToIngame()
    {
        SceneManager.LoadScene(1);
    }

    private bool CalculatePercent(int order)
    {
        int num = 0;

        for (int i = 0; i <= order; i++)
        {
            num += cardList[i].percent;
        }

        return randomNum <= num ? true : false;
    }
}
