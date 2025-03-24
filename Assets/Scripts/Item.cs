using UnityEngine;

public class Item
{
    public ItemData Data { get; private set; }
    public bool IsEquipped { get; private set; }

    public string Name => Data.itemName;
    public Sprite Icon => Data.icon;
    public int ATK => Data.atk;
    public int DEF => Data.def;
    public int CRI => Data.cri;

    public Item(ItemData data)
    {
        Data = data;
        IsEquipped = false;
    }

    public void Equip() => IsEquipped = true;
    public void UnEquip() => IsEquipped = false;
}