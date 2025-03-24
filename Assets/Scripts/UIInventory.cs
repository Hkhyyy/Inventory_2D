using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Transform slotGrid;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private Button backButton;

    private List<GameObject> slots = new List<GameObject>();

    private void Awake()
    {
        // 뒤로가기 버튼 연결
        backButton.onClick.AddListener(() => UIManager.Instance.MainMenu.OpenMainMenu());

        // 9개의 기본 슬롯 미리 생성
        for (int i = 0; i < 9; i++)
        {
            GameObject slot = Instantiate(slotPrefab, slotGrid);
            slots.Add(slot);
        }
    }

    public void UpdateInventory(Character character)
    {
        for (int i = 0; i < slots.Count; i++)
        {
            Transform itemImageTransform = slots[i].transform.Find("ItemImage");

            if (itemImageTransform == null)
            {
                continue;
            }

            Image itemImage = itemImageTransform.GetComponent<Image>();

            if (itemImage == null)
            {
                continue;
            }

            if (i < character.Inventory.Count)
            {
                Sprite sprite = character.Inventory[i];
                itemImage.sprite = sprite;
                itemImage.color = Color.white; // 알파값 복구
                itemImage.enabled = true;
            }
            else
            {
                itemImage.sprite = null;
                itemImage.enabled = false;
            }
        }

        countText.text = $"{character.Inventory.Count} / 120";
    }


}