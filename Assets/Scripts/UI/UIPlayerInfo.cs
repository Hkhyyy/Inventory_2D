using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPlayerInfo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI LVText;
    [SerializeField] private TextMeshProUGUI EXPText;
    [SerializeField] private TextMeshProUGUI NameText;
    [SerializeField] private TextMeshProUGUI NickNameText;
    [SerializeField] private Image expBarFill; // 경험치 바 (Fill Amount)

    public void UpdatePlayerInfo(Character character)
    {
        NameText.text = character.Name;
        NickNameText.text = character.NickName;
        LVText.text = $"LV {character.LV}";

        int curExp = character.EXP;
        int maxExp = character.MaxEXP;

        EXPText.text = $"{curExp} / {maxExp}";
        expBarFill.fillAmount = (float)curExp / maxExp;
    }
}