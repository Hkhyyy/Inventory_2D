using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private TextMeshProUGUI statusText;

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.ShowOnly(UIManager.Instance.MainMenu.gameObject);
    }

    public void OpenStatus()
    {
        UIManager.Instance.ShowOnly(UIManager.Instance.StatusUI.gameObject);
        UIManager.Instance.StatusUI.UpdateStatus(GameManager.Instance.Player);
    }

    public void OpenInventory()
    {
        UIManager.Instance.ShowOnly(UIManager.Instance.InventoryUI.gameObject);
        UIManager.Instance.InventoryUI.UpdateInventory(GameManager.Instance.Player);
    }
}