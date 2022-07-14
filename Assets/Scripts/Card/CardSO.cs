using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardSO", menuName = "ScriptableObject/CardSO")]
public class CardSO : ScriptableObject
{
    public Sprite profileImage;
    public Sprite nameImage;
    public Sprite explainImage;

    public int percent;
}
