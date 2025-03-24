using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI equipText;

    private Item item;

    public void SetItem(Item newItem)
    {
        item = newItem;

        if (item != null)
        {
            itemImage.sprite = item.Icon;
            itemImage.enabled = true;
            RefreshUI();
        }
        else
        {
            itemImage.enabled = false;
            equipText.text = "";
        }
    }

    public void RefreshUI()
    {
        equipText.text = item.IsEquipped ? "E" : "";
        equipText.enabled = item.IsEquipped;
    }

    public void OnClick()
    {
        if (item == null) return;

        Character player = GameManager.Instance.Player;

        if (item.IsEquipped)
        {
            player.UnEquip(item);
        }
        else
        {
            player.Equip(item);
        }

        RefreshUI();
        UIManager.Instance.StatusUI.UpdateStatus(player);
    }
}