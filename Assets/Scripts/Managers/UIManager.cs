using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    
    [SerializeField] private UIMainMenu mainMenu;
    [SerializeField] private UIStatus statusUI;
    [SerializeField] private UIInventory inventoryUI;
    [SerializeField] private UIPlayerInfo playerInfo;
    
    public UIMainMenu MainMenu => mainMenu;
    public UIStatus StatusUI => statusUI;
    public UIInventory InventoryUI => inventoryUI;
    public UIPlayerInfo PlayerInfo => playerInfo;

    private void Awake()
    {
        // 싱글톤 초기화
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    
    public void ShowOnly(GameObject ui)
    {
        mainMenu.gameObject.SetActive(ui == mainMenu.gameObject);
        statusUI.gameObject.SetActive(ui == statusUI.gameObject);
        inventoryUI.gameObject.SetActive(ui == inventoryUI.gameObject);
    }
}