using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clue Inventory", menuName = "Inventories/Clues")]
public class ClueInventory : ScriptableObject
{
    public List<Clue> Clues = new List<Clue>();
}

