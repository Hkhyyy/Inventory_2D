using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name { get; private set; }
    public int HP { get; private set; }
    public int ATK { get; private set; }
    public int DEF { get; private set; }
    public int CRI { get; private set; }
    public List<Sprite> Inventory { get; private set; } = new List<Sprite>();

    public Character(string name, int hp, int atk, int def, int cri, List<Sprite> inventory)
    {
        Name = name;
        HP = hp;
        ATK = atk;
        DEF = def;
        CRI = cri;
        Inventory = inventory;
    }
}