using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RopeClueDetection : MonoBehaviour
{
    public ConnectedClues connectedClues;

    public GameObject startAnchor;
    public GameObject endAnchor;
    public GameObject ropeBody;

    public GameObject ropeObject;
    public GameObject clueObject;

    void Awake()
    {
        ropeBody.GetComponent<Renderer>().material.color = Color.white;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        connectedClues.ColorChange();

        //if (clueObjectAtStart != null && clueObjectAtEnd != null)
        //{
        //    if (clueObjectAtStart.GetComponent<ClueDisplay>().clue.commonWith.Contains(clueObjectAtEnd.GetComponent<ClueDisplay>().clue) ||
        //        clueObjectAtEnd.GetComponent<ClueDisplay>().clue.commonWith.Contains(clueObjectAtStart.GetComponent<ClueDisplay>().clue))
        //    {
        //        ropeBody.GetComponent<Renderer>().material.color = Color.green;
        //    }
        //    else if (clueObjectAtStart.GetComponent<ClueDisplay>().clue.contradictsWith.Contains(clueObjectAtEnd.GetComponent<ClueDisplay>().clue) ||
        //        clueObjectAtEnd.GetComponent<ClueDisplay>().clue.contradictsWith.Contains(clueObjectAtStart.GetComponent<ClueDisplay>().clue))
        //    {
        //        ropeBody.GetComponent<Renderer>().material.color = Color.red;
        //    }
        //    else
        //    {
        //        Destroy(this.gameObject.transform.parent);
        //    }
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Clue"))
        {
            if (name.Equals("BeginAnchor"))
            {
                connectedClues.clueObjectAtStart = other.gameObject;
            }
            if (name.Equals("EndAnchor"))
            {
                connectedClues.clueObjectAtEnd = other.gameObject;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Clue"))
        {
            if (name.Equals("BeginAnchor"))
            {
                connectedClues.clueObjectAtStart = null;
            }
            if (name.Equals("EndAnchor"))
            {
                connectedClues.clueObjectAtEnd = null;
            }
        }
    }

    void OnMouseDown()
    {
        ropeBody.GetComponent<Renderer>().material.color = Color.white;
    }
}
