using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Transform slotGrid;
    [SerializeField] private UISlot slotPrefab; 
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private Button backButton;

    private void Awake()
    {
        // 뒤로가기 버튼 연결
        backButton.onClick.AddListener(() => UIManager.Instance.MainMenu.OpenMainMenu());
    }

    public void UpdateInventory(Character character)
    {
        foreach (Transform child in slotGrid)
            Destroy(child.gameObject);

        foreach (var item in character.Inventory)
        {
            UISlot slot = Instantiate(slotPrefab, slotGrid);
            slot.SetItem(item);
        }

        countText.text = $"{character.Inventory.Count} / 120";
    }

}