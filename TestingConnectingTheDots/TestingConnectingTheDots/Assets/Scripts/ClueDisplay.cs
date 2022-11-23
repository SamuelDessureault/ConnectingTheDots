using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClueDisplay : MonoBehaviour
{

    public Clue clue;

    public TMP_Text nameText;
    public TMP_Text descriptionText;

    public Image clueArtImage;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = clue.name;
        descriptionText.text = clue.description;

        clueArtImage.sprite = clue.clueArt;
    }
}
