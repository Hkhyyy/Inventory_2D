using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player { get; private set; }

    [SerializeField] private UIManager uiManager;
    [SerializeField] private string itemDataPath = "ItemData";

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        ItemData[] itemDatas = Resources.LoadAll<ItemData>(itemDataPath);
        List<Item> items = new List<Item>();

        foreach (ItemData data in itemDatas)
        {
            items.Add(new Item(data));
        }
        
        Player = new Character("HKK", "Developer",10, 25, 100, 25, 10, 5, items);
        uiManager.StatusUI.UpdateStatus(Player);
        uiManager.InventoryUI.UpdateInventory(Player);
        uiManager.PlayerInfo.UpdatePlayerInfo(Player);
    }

}