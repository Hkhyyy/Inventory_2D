using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Transform slotGrid;
    [SerializeField] private UISlot slotPrefab; // 이렇게!
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private Button backButton;

    private List<UISlot> slotList = new List<UISlot>();

    private void Awake()
    {
        // 뒤로가기 버튼 연결
        backButton.onClick.AddListener(() => UIManager.Instance.MainMenu.OpenMainMenu());
    }

    public void UpdateInventory(Character character)
    {
        // 기존 슬롯 삭제
        foreach (Transform child in slotGrid)
        {
            Destroy(child.gameObject);
        }
        slotList.Clear();

        // 동적 슬롯 생성
        foreach (Sprite sprite in character.Inventory)
        {
            UISlot slot = Instantiate(slotPrefab, slotGrid);
            slot.SetItem(sprite);
            slotList.Add(slot);
        }

        // 수량 텍스트 업데이트
        countText.text = $"{character.Inventory.Count} / 120";
    }
}