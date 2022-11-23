using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectedClues : MonoBehaviour
{
    public Player player;

    public GameObject clueObjectAtStart;
    public GameObject clueObjectAtEnd;

    public void ColorChange()
    {
        if (clueObjectAtStart != null && clueObjectAtEnd != null)
        {
            if (clueObjectAtStart.GetComponent<ClueDisplay>().clue.commonWith.Contains(clueObjectAtEnd.GetComponent<ClueDisplay>().clue) ||
                clueObjectAtEnd.GetComponent<ClueDisplay>().clue.commonWith.Contains(clueObjectAtStart.GetComponent<ClueDisplay>().clue))
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            else if (clueObjectAtStart.GetComponent<ClueDisplay>().clue.contradictsWith.Contains(clueObjectAtEnd.GetComponent<ClueDisplay>().clue) ||
                clueObjectAtEnd.GetComponent<ClueDisplay>().clue.contradictsWith.Contains(clueObjectAtStart.GetComponent<ClueDisplay>().clue))
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                clueObjectAtStart = null;
                clueObjectAtEnd = null;
                Debug.Log("here");
                player.TakeDamage(1);
                Destroy(this.gameObject.transform.parent.gameObject);
            }
        }
    }
}
