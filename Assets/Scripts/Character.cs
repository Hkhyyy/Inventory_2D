using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name { get; private set; }
    public int HP { get; private set; }
    public int ATK { get; private set; }
    public int DEF { get; private set; }
    public int CRI { get; private set; }

    public List<Item> Inventory { get; private set; }

    public Character(string name, int hp, int atk, int def, int cri, List<Item> inventory)
    {
        Name = name;
        HP = hp;
        ATK = atk;
        DEF = def;
        CRI = cri;
        Inventory = inventory;
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void Equip(Item item)
    {
        if (!item.IsEquipped)
        {
            ATK += item.ATK;
            DEF += item.DEF;
            CRI += item.CRI;
            item.Equip();
        }
    }

    public void UnEquip(Item item)
    {
        if (item.IsEquipped)
        {
            ATK -= item.ATK;
            DEF -= item.DEF;
            CRI -= item.CRI;
            item.UnEquip();
        }
    }
}