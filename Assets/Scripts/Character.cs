using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name { get; private set; }
    public string NickName { get; private set; }
    public int LV { get; private set; }
    public int EXP { get; private set; }
    public int MaxEXP => LV * 3 + 9; // 예시 공식
    public int HP { get; private set; }
    public int ATK { get; private set; }
    public int DEF { get; private set; }
    public int CRI { get; private set; }

    public List<Item> Inventory { get; private set; }

    public Character(string name, string nickname, int lv, int exp, int hp, int atk, int def, int cri, List<Item> inventory)
    {
        Name = name;
        NickName = nickname;
        LV = lv;
        EXP = exp;
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