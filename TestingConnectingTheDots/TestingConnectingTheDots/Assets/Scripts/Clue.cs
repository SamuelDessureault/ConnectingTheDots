using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clue", menuName = "Collectibles/Clue")]
public class Clue : ScriptableObject
{
    public GameObject prefab;

    public new string name;

    [TextArea(1,2)] public string description;

    public Sprite clueArt;

    public List<Clue> commonWith;
    public List<Clue> contradictsWith;
}
